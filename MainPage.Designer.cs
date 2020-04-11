namespace EazyFirewallBlockerGUI
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.chkbFilesList = new System.Windows.Forms.CheckedListBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBlkFirewall = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkbFilesList
            // 
            this.chkbFilesList.CheckOnClick = true;
            this.chkbFilesList.FormattingEnabled = true;
            this.chkbFilesList.Location = new System.Drawing.Point(3, 42);
            this.chkbFilesList.Name = "chkbFilesList";
            this.chkbFilesList.Size = new System.Drawing.Size(612, 256);
            this.chkbFilesList.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(3, 6);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(350, 24);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Select the files you want to block in the Windows Defender firewall\r\n*Subdirector" +
    "ies are also included in the search pattern";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkbFilesList);
            this.panel1.Controls.Add(this.lblHeader);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 301);
            this.panel1.TabIndex = 2;
            // 
            // btnBlkFirewall
            // 
            this.btnBlkFirewall.Location = new System.Drawing.Point(425, 319);
            this.btnBlkFirewall.Name = "btnBlkFirewall";
            this.btnBlkFirewall.Size = new System.Drawing.Size(100, 25);
            this.btnBlkFirewall.TabIndex = 3;
            this.btnBlkFirewall.Text = "Block Firewall";
            this.btnBlkFirewall.UseVisualStyleBackColor = true;
            this.btnBlkFirewall.Click += new System.EventHandler(this.BtnBlkFirewall_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(527, 319);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(634, 361);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBlkFirewall);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.Text = "EazyFirewallBlockerGUI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkbFilesList;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBlkFirewall;
        private System.Windows.Forms.Button btnClose;
    }
}

