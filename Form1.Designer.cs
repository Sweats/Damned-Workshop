namespace DamnedWorkshop
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.publicTestPatchStableButton = new System.Windows.Forms.Button();
            this.publicTestPatchTestingButton = new System.Windows.Forms.Button();
            this.defaultPatchButton = new System.Windows.Forms.Button();
            this.loggingTextBox = new System.Windows.Forms.RichTextBox();
            this.setDamnedFolderButton = new System.Windows.Forms.Button();
            this.toolTipSetDamnedFolder = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPublicTestPatchStable = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPublicTestPatchTesting = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLatestOfficialPatch = new System.Windows.Forms.ToolTip(this.components);
            this.damnedDirectoryLabel = new System.Windows.Forms.Label();
            this.damnedDirectoryStringLabel = new System.Windows.Forms.Label();
            this.checkPathButton = new System.Windows.Forms.Button();
            this.toolTipCheckButton = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // publicTestPatchStableButton
            // 
            this.publicTestPatchStableButton.Enabled = false;
            this.publicTestPatchStableButton.Location = new System.Drawing.Point(12, 112);
            this.publicTestPatchStableButton.Name = "publicTestPatchStableButton";
            this.publicTestPatchStableButton.Size = new System.Drawing.Size(140, 23);
            this.publicTestPatchStableButton.TabIndex = 0;
            this.publicTestPatchStableButton.Text = "Public Test Patch Stable";
            this.publicTestPatchStableButton.UseVisualStyleBackColor = true;
            this.publicTestPatchStableButton.Click += new System.EventHandler(this.PublicTestPatchStableButton_Click);
            // 
            // publicTestPatchTestingButton
            // 
            this.publicTestPatchTestingButton.Enabled = false;
            this.publicTestPatchTestingButton.Location = new System.Drawing.Point(12, 174);
            this.publicTestPatchTestingButton.Name = "publicTestPatchTestingButton";
            this.publicTestPatchTestingButton.Size = new System.Drawing.Size(140, 23);
            this.publicTestPatchTestingButton.TabIndex = 1;
            this.publicTestPatchTestingButton.Text = "Public Test Patch Testing";
            this.publicTestPatchTestingButton.UseVisualStyleBackColor = true;
            this.publicTestPatchTestingButton.Click += new System.EventHandler(this.PublicTestPatchTestingButtion_Click);
            // 
            // defaultPatchButton
            // 
            this.defaultPatchButton.Enabled = false;
            this.defaultPatchButton.Location = new System.Drawing.Point(12, 234);
            this.defaultPatchButton.Name = "defaultPatchButton";
            this.defaultPatchButton.Size = new System.Drawing.Size(140, 23);
            this.defaultPatchButton.TabIndex = 2;
            this.defaultPatchButton.Text = "Default Patch";
            this.defaultPatchButton.UseVisualStyleBackColor = true;
            this.defaultPatchButton.Click += new System.EventHandler(this.DefaultPatchButton_Click);
            // 
            // loggingTextBox
            // 
            this.loggingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loggingTextBox.Location = new System.Drawing.Point(3, 275);
            this.loggingTextBox.Name = "loggingTextBox";
            this.loggingTextBox.ReadOnly = true;
            this.loggingTextBox.Size = new System.Drawing.Size(529, 127);
            this.loggingTextBox.TabIndex = 3;
            this.loggingTextBox.Text = "";
            // 
            // setDamnedFolderButton
            // 
            this.setDamnedFolderButton.Location = new System.Drawing.Point(12, 50);
            this.setDamnedFolderButton.Name = "setDamnedFolderButton";
            this.setDamnedFolderButton.Size = new System.Drawing.Size(140, 23);
            this.setDamnedFolderButton.TabIndex = 4;
            this.setDamnedFolderButton.Text = "Set Damned Folder...";
            this.setDamnedFolderButton.UseVisualStyleBackColor = true;
            this.setDamnedFolderButton.Click += new System.EventHandler(this.SetDamnedFolderButton_Click);
            // 
            // toolTipSetDamnedFolder
            // 
            this.toolTipSetDamnedFolder.ShowAlways = true;
            // 
            // toolTipPublicTestPatchStable
            // 
            this.toolTipPublicTestPatchStable.ShowAlways = true;
            // 
            // toolTipPublicTestPatchTesting
            // 
            this.toolTipPublicTestPatchTesting.ShowAlways = true;
            // 
            // toolTipLatestOfficialPatch
            // 
            this.toolTipLatestOfficialPatch.ShowAlways = true;
            // 
            // damnedDirectoryLabel
            // 
            this.damnedDirectoryLabel.AutoSize = true;
            this.damnedDirectoryLabel.Location = new System.Drawing.Point(9, 24);
            this.damnedDirectoryLabel.Name = "damnedDirectoryLabel";
            this.damnedDirectoryLabel.Size = new System.Drawing.Size(95, 13);
            this.damnedDirectoryLabel.TabIndex = 5;
            this.damnedDirectoryLabel.Text = "Damned Directory:";
            // 
            // damnedDirectoryStringLabel
            // 
            this.damnedDirectoryStringLabel.AutoSize = true;
            this.damnedDirectoryStringLabel.Location = new System.Drawing.Point(100, 24);
            this.damnedDirectoryStringLabel.Name = "damnedDirectoryStringLabel";
            this.damnedDirectoryStringLabel.Size = new System.Drawing.Size(35, 13);
            this.damnedDirectoryStringLabel.TabIndex = 6;
            this.damnedDirectoryStringLabel.Text = "label1";
            // 
            // checkPathButton
            // 
            this.checkPathButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.checkPathButton.Location = new System.Drawing.Point(158, 50);
            this.checkPathButton.Name = "checkPathButton";
            this.checkPathButton.Size = new System.Drawing.Size(47, 23);
            this.checkPathButton.TabIndex = 7;
            this.checkPathButton.Text = "Check";
            this.checkPathButton.UseVisualStyleBackColor = true;
            this.checkPathButton.Click += new System.EventHandler(this.ButtonCheckPath_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 404);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkPathButton);
            this.Controls.Add(this.damnedDirectoryStringLabel);
            this.Controls.Add(this.damnedDirectoryLabel);
            this.Controls.Add(this.setDamnedFolderButton);
            this.Controls.Add(this.loggingTextBox);
            this.Controls.Add(this.defaultPatchButton);
            this.Controls.Add(this.publicTestPatchTestingButton);
            this.Controls.Add(this.publicTestPatchStableButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Damned Workshop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button publicTestPatchStableButton;
        private System.Windows.Forms.Button publicTestPatchTestingButton;
        private System.Windows.Forms.Button defaultPatchButton;
        private System.Windows.Forms.RichTextBox loggingTextBox;
        private System.Windows.Forms.Button setDamnedFolderButton;
        private System.Windows.Forms.ToolTip toolTipSetDamnedFolder;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTipPublicTestPatchStable;
        private System.Windows.Forms.ToolTip toolTipPublicTestPatchTesting;
        private System.Windows.Forms.ToolTip toolTipLatestOfficialPatch;
        private System.Windows.Forms.Label damnedDirectoryLabel;
        private System.Windows.Forms.Label damnedDirectoryStringLabel;
        private System.Windows.Forms.Button checkPathButton;
        private System.Windows.Forms.ToolTip toolTipCheckButton;
        private System.Windows.Forms.Button button1;
    }
}

