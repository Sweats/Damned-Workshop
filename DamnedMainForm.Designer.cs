namespace DamnedWorkshop
{
    partial class DamnedMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DamnedMainForm));
            this.damnedWelcomeTextbox = new System.Windows.Forms.RichTextBox();
            this.buttonPatcherForm = new System.Windows.Forms.Button();
            this.buttonMappingForm = new System.Windows.Forms.Button();
            this.buttonSelectDamnedDirectory = new System.Windows.Forms.Button();
            this.labelDamnedDirectory = new System.Windows.Forms.Label();
            this.labelDamnedDirectoryPath = new System.Windows.Forms.Label();
            this.buttonCheckPath = new System.Windows.Forms.Button();
            this.browseStagesButton = new System.Windows.Forms.Button();
            this.toolTipSelectDamnedDirectory = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSelectPatchingTools = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipMappingTools = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBrowseCommunityStages = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCheck = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // damnedWelcomeTextbox
            // 
            this.damnedWelcomeTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.damnedWelcomeTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.damnedWelcomeTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.damnedWelcomeTextbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.damnedWelcomeTextbox.Font = new System.Drawing.Font("Romance Fatal Serif Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damnedWelcomeTextbox.ForeColor = System.Drawing.Color.White;
            this.damnedWelcomeTextbox.Location = new System.Drawing.Point(16, 289);
            this.damnedWelcomeTextbox.Name = "damnedWelcomeTextbox";
            this.damnedWelcomeTextbox.ReadOnly = true;
            this.damnedWelcomeTextbox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.damnedWelcomeTextbox.Size = new System.Drawing.Size(785, 149);
            this.damnedWelcomeTextbox.TabIndex = 0;
            this.damnedWelcomeTextbox.Text = resources.GetString("damnedWelcomeTextbox.Text");
            this.damnedWelcomeTextbox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.DamnedWelcomeTextbox_LinkClicked);
            // 
            // buttonPatcherForm
            // 
            this.buttonPatcherForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonPatcherForm.Enabled = false;
            this.buttonPatcherForm.FlatAppearance.BorderSize = 0;
            this.buttonPatcherForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPatcherForm.Font = new System.Drawing.Font("Romance Fatal Serif Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPatcherForm.ForeColor = System.Drawing.Color.White;
            this.buttonPatcherForm.Location = new System.Drawing.Point(12, 115);
            this.buttonPatcherForm.Name = "buttonPatcherForm";
            this.buttonPatcherForm.Size = new System.Drawing.Size(129, 37);
            this.buttonPatcherForm.TabIndex = 1;
            this.buttonPatcherForm.Text = "Patching Tools";
            this.buttonPatcherForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipSelectPatchingTools.SetToolTip(this.buttonPatcherForm, resources.GetString("buttonPatcherForm.ToolTip"));
            this.buttonPatcherForm.UseVisualStyleBackColor = false;
            this.buttonPatcherForm.Click += new System.EventHandler(this.ButtonPatcherForm_Click);
            // 
            // buttonMappingForm
            // 
            this.buttonMappingForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonMappingForm.Enabled = false;
            this.buttonMappingForm.FlatAppearance.BorderSize = 0;
            this.buttonMappingForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMappingForm.Font = new System.Drawing.Font("Romance Fatal Serif Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMappingForm.ForeColor = System.Drawing.Color.White;
            this.buttonMappingForm.Location = new System.Drawing.Point(12, 170);
            this.buttonMappingForm.Name = "buttonMappingForm";
            this.buttonMappingForm.Size = new System.Drawing.Size(129, 38);
            this.buttonMappingForm.TabIndex = 2;
            this.buttonMappingForm.Text = "Mapping Tools";
            this.buttonMappingForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipMappingTools.SetToolTip(this.buttonMappingForm, resources.GetString("buttonMappingForm.ToolTip"));
            this.buttonMappingForm.UseVisualStyleBackColor = false;
            this.buttonMappingForm.Click += new System.EventHandler(this.ButtonMappingForm_Click);
            // 
            // buttonSelectDamnedDirectory
            // 
            this.buttonSelectDamnedDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonSelectDamnedDirectory.FlatAppearance.BorderSize = 0;
            this.buttonSelectDamnedDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectDamnedDirectory.Font = new System.Drawing.Font("Romance Fatal Serif Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectDamnedDirectory.ForeColor = System.Drawing.Color.White;
            this.buttonSelectDamnedDirectory.Location = new System.Drawing.Point(12, 59);
            this.buttonSelectDamnedDirectory.Name = "buttonSelectDamnedDirectory";
            this.buttonSelectDamnedDirectory.Size = new System.Drawing.Size(208, 41);
            this.buttonSelectDamnedDirectory.TabIndex = 3;
            this.buttonSelectDamnedDirectory.Text = "Select Damned Directory";
            this.buttonSelectDamnedDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipSelectDamnedDirectory.SetToolTip(this.buttonSelectDamnedDirectory, "Opens up the folder explorer window for you to select a directory where Damned is" +
        " installed.\r\n\r\nWhen you think that you have selected the right directory, hit th" +
        "e check button to the right. ");
            this.buttonSelectDamnedDirectory.UseVisualStyleBackColor = false;
            this.buttonSelectDamnedDirectory.Click += new System.EventHandler(this.ButtonSelectDamnedDirectory_Click);
            // 
            // labelDamnedDirectory
            // 
            this.labelDamnedDirectory.AutoSize = true;
            this.labelDamnedDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDamnedDirectory.Font = new System.Drawing.Font("Romance Fatal Serif Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDamnedDirectory.ForeColor = System.Drawing.Color.White;
            this.labelDamnedDirectory.Location = new System.Drawing.Point(12, 15);
            this.labelDamnedDirectory.Name = "labelDamnedDirectory";
            this.labelDamnedDirectory.Size = new System.Drawing.Size(155, 21);
            this.labelDamnedDirectory.TabIndex = 4;
            this.labelDamnedDirectory.Text = "Damned Directory:";
            this.labelDamnedDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDamnedDirectoryPath
            // 
            this.labelDamnedDirectoryPath.AutoSize = true;
            this.labelDamnedDirectoryPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelDamnedDirectoryPath.Font = new System.Drawing.Font("Romance Fatal Serif Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDamnedDirectoryPath.ForeColor = System.Drawing.Color.White;
            this.labelDamnedDirectoryPath.Location = new System.Drawing.Point(173, 15);
            this.labelDamnedDirectoryPath.Name = "labelDamnedDirectoryPath";
            this.labelDamnedDirectoryPath.Size = new System.Drawing.Size(357, 21);
            this.labelDamnedDirectoryPath.TabIndex = 5;
            this.labelDamnedDirectoryPath.Text = "Your Damned directory path will appear here.";
            // 
            // buttonCheckPath
            // 
            this.buttonCheckPath.AutoSize = true;
            this.buttonCheckPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonCheckPath.FlatAppearance.BorderSize = 0;
            this.buttonCheckPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckPath.Font = new System.Drawing.Font("Romance Fatal Serif Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckPath.ForeColor = System.Drawing.Color.White;
            this.buttonCheckPath.Location = new System.Drawing.Point(217, 64);
            this.buttonCheckPath.Name = "buttonCheckPath";
            this.buttonCheckPath.Size = new System.Drawing.Size(84, 31);
            this.buttonCheckPath.TabIndex = 6;
            this.buttonCheckPath.Text = "Check...";
            this.toolTipCheck.SetToolTip(this.buttonCheckPath, resources.GetString("buttonCheckPath.ToolTip"));
            this.buttonCheckPath.UseVisualStyleBackColor = false;
            this.buttonCheckPath.Click += new System.EventHandler(this.ButtonCheckPath_Click);
            // 
            // browseStagesButton
            // 
            this.browseStagesButton.Enabled = false;
            this.browseStagesButton.FlatAppearance.BorderSize = 0;
            this.browseStagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseStagesButton.Font = new System.Drawing.Font("Romance Fatal Serif Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseStagesButton.ForeColor = System.Drawing.Color.White;
            this.browseStagesButton.Location = new System.Drawing.Point(12, 214);
            this.browseStagesButton.Name = "browseStagesButton";
            this.browseStagesButton.Size = new System.Drawing.Size(235, 52);
            this.browseStagesButton.TabIndex = 7;
            this.browseStagesButton.Text = "Browse Community Stages...";
            this.browseStagesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipBrowseCommunityStages.SetToolTip(this.browseStagesButton, "Opens up a new window where you can install new stages into Damned from the commu" +
        "nity repository.");
            this.browseStagesButton.UseVisualStyleBackColor = true;
            this.browseStagesButton.Click += new System.EventHandler(this.BrowseStagesButton_Click);
            // 
            // DamnedMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.browseStagesButton);
            this.Controls.Add(this.buttonCheckPath);
            this.Controls.Add(this.labelDamnedDirectoryPath);
            this.Controls.Add(this.labelDamnedDirectory);
            this.Controls.Add(this.buttonSelectDamnedDirectory);
            this.Controls.Add(this.buttonMappingForm);
            this.Controls.Add(this.buttonPatcherForm);
            this.Controls.Add(this.damnedWelcomeTextbox);
            this.Font = new System.Drawing.Font("Romance Fatal Serif Std", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "DamnedMainForm";
            this.Text = "Damned Workshop";
            this.Load += new System.EventHandler(this.DamnedMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox damnedWelcomeTextbox;
        private System.Windows.Forms.Button buttonPatcherForm;
        private System.Windows.Forms.Button buttonMappingForm;
        private System.Windows.Forms.Button buttonSelectDamnedDirectory;
        private System.Windows.Forms.Label labelDamnedDirectory;
        private System.Windows.Forms.Label labelDamnedDirectoryPath;
        private System.Windows.Forms.Button buttonCheckPath;
        private System.Windows.Forms.Button browseStagesButton;
        private System.Windows.Forms.ToolTip toolTipSelectDamnedDirectory;
        private System.Windows.Forms.ToolTip toolTipSelectPatchingTools;
        private System.Windows.Forms.ToolTip toolTipMappingTools;
        private System.Windows.Forms.ToolTip toolTipBrowseCommunityStages;
        private System.Windows.Forms.ToolTip toolTipCheck;
    }
}