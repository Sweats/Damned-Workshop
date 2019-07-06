namespace DamnedWorkshop
{
    partial class DamnedPatcherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DamnedPatcherForm));
            this.publicTestPatchStableButton = new System.Windows.Forms.Button();
            this.publicTestPatchTestingButton = new System.Windows.Forms.Button();
            this.loggingTextBox = new System.Windows.Forms.RichTextBox();
            this.toolTipSetDamnedFolder = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPublicTestPatchStable = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPublicTestPatchTesting = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipLatestOfficialPatch = new System.Windows.Forms.ToolTip(this.components);
            this.damnedDirectoryLabel = new System.Windows.Forms.Label();
            this.damnedDirectoryStringLabel = new System.Windows.Forms.Label();
            this.toolTipCheckButton = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSelectBackupFolder = new System.Windows.Forms.Button();
            this.damnedBackupFolderLabel = new System.Windows.Forms.Label();
            this.damnedBackupFolderStringLabel = new System.Windows.Forms.Label();
            this.keepPublicTestPatchStableCheckbox = new System.Windows.Forms.CheckBox();
            this.keepPublicTestPatchTestingCheckbox = new System.Windows.Forms.CheckBox();
            this.buttonSetPublicTestPatchStableLocation = new System.Windows.Forms.Button();
            this.buttonSetPublicTestPatchTestingLocation = new System.Windows.Forms.Button();
            this.publicTestPatchStablePathLabel = new System.Windows.Forms.Label();
            this.publicTestPatchTestingPathLabel = new System.Windows.Forms.Label();
            this.buttonBackUp = new System.Windows.Forms.Button();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.buttonOnlyCheck = new System.Windows.Forms.Button();
            this.toolTipOnlyCheckButton = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBackupAndCheck = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSelectBackupFolder = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipKeepPublicTestPatchStableCheckbox = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPublicTestPatchTestingCheckbox = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipRestoreButton = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSetPublicTestPatchStableLocationButton = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSetPublicTestPatchTestingLocationButton = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // publicTestPatchStableButton
            // 
            this.publicTestPatchStableButton.FlatAppearance.BorderSize = 0;
            this.publicTestPatchStableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publicTestPatchStableButton.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicTestPatchStableButton.ForeColor = System.Drawing.Color.White;
            this.publicTestPatchStableButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.publicTestPatchStableButton.Location = new System.Drawing.Point(6, 109);
            this.publicTestPatchStableButton.Name = "publicTestPatchStableButton";
            this.publicTestPatchStableButton.Size = new System.Drawing.Size(144, 23);
            this.publicTestPatchStableButton.TabIndex = 0;
            this.publicTestPatchStableButton.Text = "Public Test Patch Stable";
            this.publicTestPatchStableButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.publicTestPatchStableButton.UseVisualStyleBackColor = true;
            this.publicTestPatchStableButton.Click += new System.EventHandler(this.PublicTestPatchStableButton_Click);
            // 
            // publicTestPatchTestingButton
            // 
            this.publicTestPatchTestingButton.FlatAppearance.BorderSize = 0;
            this.publicTestPatchTestingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.publicTestPatchTestingButton.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicTestPatchTestingButton.ForeColor = System.Drawing.Color.White;
            this.publicTestPatchTestingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.publicTestPatchTestingButton.Location = new System.Drawing.Point(6, 148);
            this.publicTestPatchTestingButton.Name = "publicTestPatchTestingButton";
            this.publicTestPatchTestingButton.Size = new System.Drawing.Size(150, 23);
            this.publicTestPatchTestingButton.TabIndex = 1;
            this.publicTestPatchTestingButton.Text = "Public Test Patch Testing";
            this.publicTestPatchTestingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.publicTestPatchTestingButton.UseVisualStyleBackColor = true;
            this.publicTestPatchTestingButton.Click += new System.EventHandler(this.PublicTestPatchTestingButtion_Click);
            // 
            // loggingTextBox
            // 
            this.loggingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loggingTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.loggingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loggingTextBox.Font = new System.Drawing.Font("Romance Fatal Serif Std", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggingTextBox.ForeColor = System.Drawing.Color.White;
            this.loggingTextBox.Location = new System.Drawing.Point(3, 229);
            this.loggingTextBox.Name = "loggingTextBox";
            this.loggingTextBox.ReadOnly = true;
            this.loggingTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.loggingTextBox.Size = new System.Drawing.Size(529, 174);
            this.loggingTextBox.TabIndex = 3;
            this.loggingTextBox.Text = "";
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
            this.damnedDirectoryLabel.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damnedDirectoryLabel.ForeColor = System.Drawing.Color.White;
            this.damnedDirectoryLabel.Location = new System.Drawing.Point(3, 17);
            this.damnedDirectoryLabel.Name = "damnedDirectoryLabel";
            this.damnedDirectoryLabel.Size = new System.Drawing.Size(108, 14);
            this.damnedDirectoryLabel.TabIndex = 5;
            this.damnedDirectoryLabel.Text = "Damned Directory:";
            this.damnedDirectoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // damnedDirectoryStringLabel
            // 
            this.damnedDirectoryStringLabel.AutoSize = true;
            this.damnedDirectoryStringLabel.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damnedDirectoryStringLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(38)))));
            this.damnedDirectoryStringLabel.Location = new System.Drawing.Point(117, 17);
            this.damnedDirectoryStringLabel.Name = "damnedDirectoryStringLabel";
            this.damnedDirectoryStringLabel.Size = new System.Drawing.Size(33, 14);
            this.damnedDirectoryStringLabel.TabIndex = 6;
            this.damnedDirectoryStringLabel.Text = "label1";
            this.damnedDirectoryStringLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSelectBackupFolder
            // 
            this.buttonSelectBackupFolder.FlatAppearance.BorderSize = 0;
            this.buttonSelectBackupFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectBackupFolder.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectBackupFolder.ForeColor = System.Drawing.Color.White;
            this.buttonSelectBackupFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectBackupFolder.Location = new System.Drawing.Point(3, 69);
            this.buttonSelectBackupFolder.Name = "buttonSelectBackupFolder";
            this.buttonSelectBackupFolder.Size = new System.Drawing.Size(147, 23);
            this.buttonSelectBackupFolder.TabIndex = 11;
            this.buttonSelectBackupFolder.Text = "Select Backup Folder...";
            this.buttonSelectBackupFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipSelectBackupFolder.SetToolTip(this.buttonSelectBackupFolder, resources.GetString("buttonSelectBackupFolder.ToolTip"));
            this.buttonSelectBackupFolder.UseVisualStyleBackColor = true;
            this.buttonSelectBackupFolder.Click += new System.EventHandler(this.ButtonSelectBackupFolder_Click);
            // 
            // damnedBackupFolderLabel
            // 
            this.damnedBackupFolderLabel.AutoSize = true;
            this.damnedBackupFolderLabel.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damnedBackupFolderLabel.ForeColor = System.Drawing.Color.White;
            this.damnedBackupFolderLabel.Location = new System.Drawing.Point(3, 40);
            this.damnedBackupFolderLabel.Name = "damnedBackupFolderLabel";
            this.damnedBackupFolderLabel.Size = new System.Drawing.Size(136, 14);
            this.damnedBackupFolderLabel.TabIndex = 12;
            this.damnedBackupFolderLabel.Text = "Damned Backup Folder:";
            this.damnedBackupFolderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // damnedBackupFolderStringLabel
            // 
            this.damnedBackupFolderStringLabel.AutoSize = true;
            this.damnedBackupFolderStringLabel.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damnedBackupFolderStringLabel.ForeColor = System.Drawing.Color.White;
            this.damnedBackupFolderStringLabel.Location = new System.Drawing.Point(140, 40);
            this.damnedBackupFolderStringLabel.Name = "damnedBackupFolderStringLabel";
            this.damnedBackupFolderStringLabel.Size = new System.Drawing.Size(147, 14);
            this.damnedBackupFolderStringLabel.TabIndex = 13;
            this.damnedBackupFolderStringLabel.Text = "No backup folder selected.";
            this.damnedBackupFolderStringLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // keepPublicTestPatchStableCheckbox
            // 
            this.keepPublicTestPatchStableCheckbox.AutoSize = true;
            this.keepPublicTestPatchStableCheckbox.FlatAppearance.BorderSize = 0;
            this.keepPublicTestPatchStableCheckbox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.keepPublicTestPatchStableCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keepPublicTestPatchStableCheckbox.Font = new System.Drawing.Font("Romance Fatal Serif Std", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keepPublicTestPatchStableCheckbox.ForeColor = System.Drawing.Color.White;
            this.keepPublicTestPatchStableCheckbox.Location = new System.Drawing.Point(168, 113);
            this.keepPublicTestPatchStableCheckbox.Name = "keepPublicTestPatchStableCheckbox";
            this.keepPublicTestPatchStableCheckbox.Size = new System.Drawing.Size(52, 17);
            this.keepPublicTestPatchStableCheckbox.TabIndex = 14;
            this.keepPublicTestPatchStableCheckbox.Text = "Keep?";
            this.toolTipKeepPublicTestPatchStableCheckbox.SetToolTip(this.keepPublicTestPatchStableCheckbox, resources.GetString("keepPublicTestPatchStableCheckbox.ToolTip"));
            this.keepPublicTestPatchStableCheckbox.UseVisualStyleBackColor = true;
            this.keepPublicTestPatchStableCheckbox.CheckedChanged += new System.EventHandler(this.KeepPublicTestPatchStableCheckbox_CheckedChanged);
            // 
            // keepPublicTestPatchTestingCheckbox
            // 
            this.keepPublicTestPatchTestingCheckbox.AutoSize = true;
            this.keepPublicTestPatchTestingCheckbox.FlatAppearance.BorderSize = 0;
            this.keepPublicTestPatchTestingCheckbox.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.keepPublicTestPatchTestingCheckbox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(38)))));
            this.keepPublicTestPatchTestingCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keepPublicTestPatchTestingCheckbox.Font = new System.Drawing.Font("Romance Fatal Serif Std", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keepPublicTestPatchTestingCheckbox.ForeColor = System.Drawing.Color.White;
            this.keepPublicTestPatchTestingCheckbox.Location = new System.Drawing.Point(168, 151);
            this.keepPublicTestPatchTestingCheckbox.Name = "keepPublicTestPatchTestingCheckbox";
            this.keepPublicTestPatchTestingCheckbox.Size = new System.Drawing.Size(52, 17);
            this.keepPublicTestPatchTestingCheckbox.TabIndex = 15;
            this.keepPublicTestPatchTestingCheckbox.Text = "Keep?";
            this.toolTipPublicTestPatchTestingCheckbox.SetToolTip(this.keepPublicTestPatchTestingCheckbox, resources.GetString("keepPublicTestPatchTestingCheckbox.ToolTip"));
            this.keepPublicTestPatchTestingCheckbox.UseVisualStyleBackColor = true;
            this.keepPublicTestPatchTestingCheckbox.CheckedChanged += new System.EventHandler(this.KeepPublicTestPatchTestingCheckbox_CheckedChanged);
            // 
            // buttonSetPublicTestPatchStableLocation
            // 
            this.buttonSetPublicTestPatchStableLocation.Enabled = false;
            this.buttonSetPublicTestPatchStableLocation.FlatAppearance.BorderSize = 0;
            this.buttonSetPublicTestPatchStableLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetPublicTestPatchStableLocation.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetPublicTestPatchStableLocation.ForeColor = System.Drawing.Color.White;
            this.buttonSetPublicTestPatchStableLocation.Location = new System.Drawing.Point(226, 109);
            this.buttonSetPublicTestPatchStableLocation.Name = "buttonSetPublicTestPatchStableLocation";
            this.buttonSetPublicTestPatchStableLocation.Size = new System.Drawing.Size(87, 21);
            this.buttonSetPublicTestPatchStableLocation.TabIndex = 16;
            this.buttonSetPublicTestPatchStableLocation.Text = "Set Location...";
            this.toolTipSetPublicTestPatchStableLocationButton.SetToolTip(this.buttonSetPublicTestPatchStableLocation, "Opens up the file explorer for you to select a location where the public test pat" +
        "ch stable will be saved to.");
            this.buttonSetPublicTestPatchStableLocation.UseVisualStyleBackColor = true;
            this.buttonSetPublicTestPatchStableLocation.Click += new System.EventHandler(this.ButtonSetPublicTestPatchStableLocation_Click);
            // 
            // buttonSetPublicTestPatchTestingLocation
            // 
            this.buttonSetPublicTestPatchTestingLocation.Enabled = false;
            this.buttonSetPublicTestPatchTestingLocation.FlatAppearance.BorderSize = 0;
            this.buttonSetPublicTestPatchTestingLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetPublicTestPatchTestingLocation.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetPublicTestPatchTestingLocation.ForeColor = System.Drawing.Color.White;
            this.buttonSetPublicTestPatchTestingLocation.Location = new System.Drawing.Point(226, 148);
            this.buttonSetPublicTestPatchTestingLocation.Name = "buttonSetPublicTestPatchTestingLocation";
            this.buttonSetPublicTestPatchTestingLocation.Size = new System.Drawing.Size(87, 21);
            this.buttonSetPublicTestPatchTestingLocation.TabIndex = 17;
            this.buttonSetPublicTestPatchTestingLocation.Text = "Set Location...";
            this.toolTipSetPublicTestPatchTestingLocationButton.SetToolTip(this.buttonSetPublicTestPatchTestingLocation, "Opens up the file explorer for you to select a location where the public test pat" +
        "ch testing will be saved to.");
            this.buttonSetPublicTestPatchTestingLocation.UseVisualStyleBackColor = true;
            this.buttonSetPublicTestPatchTestingLocation.Click += new System.EventHandler(this.ButtonSetPublicTestPatchTestingLocation_Click);
            // 
            // publicTestPatchStablePathLabel
            // 
            this.publicTestPatchStablePathLabel.AutoSize = true;
            this.publicTestPatchStablePathLabel.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicTestPatchStablePathLabel.ForeColor = System.Drawing.Color.White;
            this.publicTestPatchStablePathLabel.Location = new System.Drawing.Point(313, 113);
            this.publicTestPatchStablePathLabel.Name = "publicTestPatchStablePathLabel";
            this.publicTestPatchStablePathLabel.Size = new System.Drawing.Size(0, 14);
            this.publicTestPatchStablePathLabel.TabIndex = 18;
            // 
            // publicTestPatchTestingPathLabel
            // 
            this.publicTestPatchTestingPathLabel.AutoSize = true;
            this.publicTestPatchTestingPathLabel.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicTestPatchTestingPathLabel.ForeColor = System.Drawing.Color.White;
            this.publicTestPatchTestingPathLabel.Location = new System.Drawing.Point(313, 151);
            this.publicTestPatchTestingPathLabel.Name = "publicTestPatchTestingPathLabel";
            this.publicTestPatchTestingPathLabel.Size = new System.Drawing.Size(0, 14);
            this.publicTestPatchTestingPathLabel.TabIndex = 19;
            // 
            // buttonBackUp
            // 
            this.buttonBackUp.Enabled = false;
            this.buttonBackUp.FlatAppearance.BorderSize = 0;
            this.buttonBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackUp.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackUp.ForeColor = System.Drawing.Color.White;
            this.buttonBackUp.Location = new System.Drawing.Point(217, 69);
            this.buttonBackUp.Name = "buttonBackUp";
            this.buttonBackUp.Size = new System.Drawing.Size(121, 23);
            this.buttonBackUp.TabIndex = 20;
            this.buttonBackUp.Text = "Backup and Check...";
            this.toolTipBackupAndCheck.SetToolTip(this.buttonBackUp, resources.GetString("buttonBackUp.ToolTip"));
            this.buttonBackUp.UseVisualStyleBackColor = true;
            this.buttonBackUp.Click += new System.EventHandler(this.ButtonBackUp_Click);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Enabled = false;
            this.buttonRestore.FlatAppearance.BorderSize = 0;
            this.buttonRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestore.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestore.ForeColor = System.Drawing.Color.White;
            this.buttonRestore.Location = new System.Drawing.Point(6, 187);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(59, 23);
            this.buttonRestore.TabIndex = 21;
            this.buttonRestore.Text = "Restore";
            this.buttonRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipRestoreButton.SetToolTip(this.buttonRestore, resources.GetString("buttonRestore.ToolTip"));
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.ButtonRestore_Click);
            // 
            // buttonOnlyCheck
            // 
            this.buttonOnlyCheck.Enabled = false;
            this.buttonOnlyCheck.FlatAppearance.BorderSize = 0;
            this.buttonOnlyCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOnlyCheck.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOnlyCheck.ForeColor = System.Drawing.Color.White;
            this.buttonOnlyCheck.Location = new System.Drawing.Point(143, 69);
            this.buttonOnlyCheck.Name = "buttonOnlyCheck";
            this.buttonOnlyCheck.Size = new System.Drawing.Size(80, 23);
            this.buttonOnlyCheck.TabIndex = 22;
            this.buttonOnlyCheck.Text = "Only Check...";
            this.toolTipOnlyCheckButton.SetToolTip(this.buttonOnlyCheck, resources.GetString("buttonOnlyCheck.ToolTip"));
            this.buttonOnlyCheck.UseVisualStyleBackColor = true;
            this.buttonOnlyCheck.Click += new System.EventHandler(this.ButtonOnlyCheck_Click);
            // 
            // DamnedPatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(533, 404);
            this.Controls.Add(this.buttonOnlyCheck);
            this.Controls.Add(this.buttonRestore);
            this.Controls.Add(this.buttonBackUp);
            this.Controls.Add(this.publicTestPatchTestingPathLabel);
            this.Controls.Add(this.publicTestPatchStablePathLabel);
            this.Controls.Add(this.buttonSetPublicTestPatchTestingLocation);
            this.Controls.Add(this.buttonSetPublicTestPatchStableLocation);
            this.Controls.Add(this.keepPublicTestPatchTestingCheckbox);
            this.Controls.Add(this.keepPublicTestPatchStableCheckbox);
            this.Controls.Add(this.damnedBackupFolderStringLabel);
            this.Controls.Add(this.damnedBackupFolderLabel);
            this.Controls.Add(this.buttonSelectBackupFolder);
            this.Controls.Add(this.damnedDirectoryStringLabel);
            this.Controls.Add(this.damnedDirectoryLabel);
            this.Controls.Add(this.loggingTextBox);
            this.Controls.Add(this.publicTestPatchTestingButton);
            this.Controls.Add(this.publicTestPatchStableButton);
            this.Font = new System.Drawing.Font("Romance Fatal Serif Std", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DamnedPatcherForm";
            this.Text = "Damned Workshop (Patcher)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DamnedPatcherForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button publicTestPatchStableButton;
        private System.Windows.Forms.Button publicTestPatchTestingButton;
        private System.Windows.Forms.RichTextBox loggingTextBox;
        private System.Windows.Forms.ToolTip toolTipSetDamnedFolder;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTipPublicTestPatchStable;
        private System.Windows.Forms.ToolTip toolTipPublicTestPatchTesting;
        private System.Windows.Forms.ToolTip toolTipLatestOfficialPatch;
        private System.Windows.Forms.Label damnedDirectoryLabel;
        private System.Windows.Forms.Label damnedDirectoryStringLabel;
        private System.Windows.Forms.ToolTip toolTipCheckButton;
        private System.Windows.Forms.Button buttonSelectBackupFolder;
        private System.Windows.Forms.Label damnedBackupFolderLabel;
        private System.Windows.Forms.Label damnedBackupFolderStringLabel;
        private System.Windows.Forms.CheckBox keepPublicTestPatchStableCheckbox;
        private System.Windows.Forms.CheckBox keepPublicTestPatchTestingCheckbox;
        private System.Windows.Forms.Button buttonSetPublicTestPatchStableLocation;
        private System.Windows.Forms.Button buttonSetPublicTestPatchTestingLocation;
        private System.Windows.Forms.Label publicTestPatchStablePathLabel;
        private System.Windows.Forms.Label publicTestPatchTestingPathLabel;
        private System.Windows.Forms.Button buttonBackUp;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.Button buttonOnlyCheck;
        private System.Windows.Forms.ToolTip toolTipOnlyCheckButton;
        private System.Windows.Forms.ToolTip toolTipBackupAndCheck;
        private System.Windows.Forms.ToolTip toolTipSelectBackupFolder;
        private System.Windows.Forms.ToolTip toolTipKeepPublicTestPatchStableCheckbox;
        private System.Windows.Forms.ToolTip toolTipPublicTestPatchTestingCheckbox;
        private System.Windows.Forms.ToolTip toolTipSetPublicTestPatchStableLocationButton;
        private System.Windows.Forms.ToolTip toolTipSetPublicTestPatchTestingLocationButton;
        private System.Windows.Forms.ToolTip toolTipRestoreButton;
    }
}

