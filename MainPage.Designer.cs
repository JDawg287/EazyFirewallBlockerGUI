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
            this.pnlList = new System.Windows.Forms.Panel();
            this.btnBlkFirewall = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnSelectDir = new System.Windows.Forms.Button();
            this.pnlLabel = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnToggleSelection = new System.Windows.Forms.Button();
            this.pnlList.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlLabel.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkbFilesList
            // 
            this.chkbFilesList.CheckOnClick = true;
            this.chkbFilesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkbFilesList.FormattingEnabled = true;
            this.chkbFilesList.Location = new System.Drawing.Point(0, 0);
            this.chkbFilesList.Name = "chkbFilesList";
            this.chkbFilesList.Size = new System.Drawing.Size(637, 285);
            this.chkbFilesList.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(4, 3);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(350, 24);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Select the files you want to block in the Windows Defender firewall\r\n*Subdirector" +
    "ies are also included in the search pattern";
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.chkbFilesList);
            this.pnlList.Location = new System.Drawing.Point(3, 41);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(637, 285);
            this.pnlList.TabIndex = 2;
            // 
            // btnBlkFirewall
            // 
            this.btnBlkFirewall.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBlkFirewall.Location = new System.Drawing.Point(384, 3);
            this.btnBlkFirewall.Name = "btnBlkFirewall";
            this.btnBlkFirewall.Size = new System.Drawing.Size(125, 25);
            this.btnBlkFirewall.TabIndex = 3;
            this.btnBlkFirewall.Text = "Block Firewall";
            this.btnBlkFirewall.UseVisualStyleBackColor = true;
            this.btnBlkFirewall.Click += new System.EventHandler(this.BtnBlkFirewall_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(515, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 25);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnToggleSelection);
            this.pnlButtons.Controls.Add(this.btnSelectDir);
            this.pnlButtons.Controls.Add(this.btnClose);
            this.pnlButtons.Controls.Add(this.btnBlkFirewall);
            this.pnlButtons.Location = new System.Drawing.Point(0, 332);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(643, 31);
            this.pnlButtons.TabIndex = 4;
            // 
            // btnSelectDir
            // 
            this.btnSelectDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectDir.Location = new System.Drawing.Point(3, 3);
            this.btnSelectDir.Name = "btnSelectDir";
            this.btnSelectDir.Size = new System.Drawing.Size(125, 25);
            this.btnSelectDir.TabIndex = 4;
            this.btnSelectDir.Text = "Select Dir";
            this.btnSelectDir.UseVisualStyleBackColor = true;
            this.btnSelectDir.Click += new System.EventHandler(this.BtnSelectDir_Click);
            // 
            // pnlLabel
            // 
            this.pnlLabel.Controls.Add(this.lblHeader);
            this.pnlLabel.Location = new System.Drawing.Point(0, 0);
            this.pnlLabel.Name = "pnlLabel";
            this.pnlLabel.Size = new System.Drawing.Size(643, 35);
            this.pnlLabel.TabIndex = 5;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlLabel);
            this.pnlMain.Controls.Add(this.pnlButtons);
            this.pnlMain.Controls.Add(this.pnlList);
            this.pnlMain.Location = new System.Drawing.Point(6, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(643, 363);
            this.pnlMain.TabIndex = 6;
            // 
            // btnToggleSelection
            // 
            this.btnToggleSelection.Location = new System.Drawing.Point(134, 3);
            this.btnToggleSelection.Name = "btnToggleSelection";
            this.btnToggleSelection.Size = new System.Drawing.Size(125, 25);
            this.btnToggleSelection.TabIndex = 5;
            this.btnToggleSelection.Text = "Toggle Select";
            this.btnToggleSelection.UseVisualStyleBackColor = true;
            this.btnToggleSelection.Click += new System.EventHandler(this.BtnToggleSelection_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(659, 376);
            this.Controls.Add(this.pnlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EazyFirewallBlockerGUI";
            this.pnlList.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlLabel.ResumeLayout(false);
            this.pnlLabel.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkbFilesList;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Button btnBlkFirewall;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnSelectDir;
        private System.Windows.Forms.Panel pnlLabel;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnToggleSelection;
    }
}

