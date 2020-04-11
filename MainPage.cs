using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Windows.Forms;

namespace EazyFirewallBlockerGUI
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            fetchInfo();
        }

        /// <summary>
        ///  Name of the companion batch file that is required by the program to function
        /// </summary>
        const string BATCHFILENAME = "FirewallBlocker.bat";

        /// <summary>
        /// Fetch the executables in the directory
        /// where the program is copied
        /// </summary>
        private void fetchInfo()
        {
            // Name of the current executable
            string curExeName = System.AppDomain.CurrentDomain.FriendlyName;

            // validate if the companion batch file exists or not
            string curDir = Directory.GetCurrentDirectory();
            string batchFilepath = curDir + "\\" + BATCHFILENAME;
            if (!File.Exists(batchFilepath))
            {
                MessageBox.Show(string.Format("The batch process file \"{0}\" was not found.\r\nThe program will now exit!", batchFilepath), "Error");
                Environment.Exit(0);
            }

            // populate the checkbox list
            var executablesInDir = Directory.GetFiles(curDir, "*.exe", SearchOption.AllDirectories);

            for (int i = 0; i < executablesInDir.Count(); i++)
            {
                if (Path.GetFileNameWithoutExtension(executablesInDir[i]) != Path.GetFileNameWithoutExtension(curExeName)) // do not include own path
                {
                    chkbFilesList.Items.Add(executablesInDir[i], CheckState.Checked);
                }
            }
        }

        /// <summary>
        /// Block program in firewall execute button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBlkFirewall_Click(object sender, EventArgs e)
        {
            // return if no items are checked
            if (chkbFilesList.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please check files to block in the Windows Defender Firewall.", "Info");
                return;
            }

            // get the list of 
            StringBuilder checkedExecList = new StringBuilder();
            foreach (string executable in chkbFilesList.CheckedItems)
            {
                checkedExecList.Append("- " + Path.GetFileName(executable) + Environment.NewLine);
            }

            // confirm the action 
            DialogResult confirmation = MessageBox.Show(string.Format("Are you sure you want to block the following program/programs in Windows Defender Firewall?\r\n{0}", checkedExecList.ToString()), "Inquiry", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                StringBuilder executionResultList = new StringBuilder();
                foreach (string executablePath in chkbFilesList.CheckedItems)
                {
                    string executionResult = string.Empty;
                    bool OK = blockFirewall(executablePath, ref executionResult); // block the selected programs
                    if (!OK)
                    {
                        MessageBox.Show(executionResult, "Error");
                        Environment.Exit(0);
                    }
                    executionResultList.Append(executionResult);
                }

                // handle the batch script execution results
                if (executionResultList.ToString() != string.Empty)
                {
                    MessageBox.Show("Batch file executed successfully!", "Info");
                    DialogResult showResults = MessageBox.Show("Do you want to see the results of executing the batch file?", "Inquiry", MessageBoxButtons.YesNo);
                    if (showResults == DialogResult.Yes)
                    {
                        FileStream currentFileStream = null;
                        DateTime UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                        string tempFilePath = Path.GetTempPath() + string.Format("temp_{0}.txt", (DateTime.UtcNow - UnixEpoch).TotalMilliseconds.ToString());

                        if (!File.Exists(tempFilePath)) // create file if file does not already exist
                        {
                            currentFileStream = File.Create(tempFilePath);
                            currentFileStream.Close(); // frees the file for editing/reading
                        }
                        File.WriteAllText(tempFilePath, executionResultList.ToString()); // overwrites all text in temp file
                        Process.Start(tempFilePath); // opens the file in the default text editor
                    }
                }
            }
        }

        /// <summary>
        /// Close button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Adds a reference in the Windows Defender Firewall for both 
        /// incoming and outgoing connections for a specific program (executable)
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="result"></param>
        /// <returns>true: on successful execution of the batch script</returns>
        private bool blockFirewall(string filePath, ref string outRes)
        {
            try
            {
                using (Runspace myRunSpace = RunspaceFactory.CreateRunspace())
                {
                    myRunSpace.Open();
                    using (PowerShell powershell = PowerShell.Create())
                    {
                        // add the command to run the bat file
                        powershell.AddCommand(".\\" + BATCHFILENAME);
                        powershell.AddArgument(filePath); // first argument: file path for the file which is to be blocked
                        powershell.AddArgument(Path.GetFileName(filePath)); // second argument: filename of the file which is to be blocked

                        // execute the script
                        var results = powershell.Invoke();
                        powershell.Streams.ClearStreams();
                        powershell.Commands.Clear();

                        // convert the script result into a single string
                        StringBuilder stringBuilder = new StringBuilder();
                        for (int i = 0; i < results.Count() - 1; i++) // -1 to omit the final line as it is garbage
                        {
                            stringBuilder.AppendLine(results[i].ToString());
                        }
                        outRes = stringBuilder.ToString();
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                outRes = e.Message;
                return false;
            }
        }
    }
}
