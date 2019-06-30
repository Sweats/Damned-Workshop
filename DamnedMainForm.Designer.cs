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
            this.damnedWelcomeTextbox = new System.Windows.Forms.RichTextBox();
            this.buttonPatcherForm = new System.Windows.Forms.Button();
            this.buttonMappingForm = new System.Windows.Forms.Button();
            this.buttonSelectDamnedDirectory = new System.Windows.Forms.Button();
            this.labelDamnedDirectory = new System.Windows.Forms.Label();
            this.labelDamnedDirectoryPath = new System.Windows.Forms.Label();
            this.buttonCheckPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // damnedWelcomeTextbox
            // 
            this.damnedWelcomeTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.damnedWelcomeTextbox.Location = new System.Drawing.Point(448, 12);
            this.damnedWelcomeTextbox.Name = "damnedWelcomeTextbox";
            this.damnedWelcomeTextbox.Size = new System.Drawing.Size(340, 426);
            this.damnedWelcomeTextbox.TabIndex = 0;
            this.damnedWelcomeTextbox.Text = "";
            // 
            // buttonPatcherForm
            // 
            this.buttonPatcherForm.Enabled = false;
            this.buttonPatcherForm.Location = new System.Drawing.Point(12, 91);
            this.buttonPatcherForm.Name = "buttonPatcherForm";
            this.buttonPatcherForm.Size = new System.Drawing.Size(189, 23);
            this.buttonPatcherForm.TabIndex = 1;
            this.buttonPatcherForm.Text = "Patching Tools";
            this.buttonPatcherForm.UseVisualStyleBackColor = true;
            this.buttonPatcherForm.Click += new System.EventHandler(this.ButtonPatcherForm_Click);
            // 
            // buttonMappingForm
            // 
            this.buttonMappingForm.Enabled = false;
            this.buttonMappingForm.Location = new System.Drawing.Point(12, 132);
            this.buttonMappingForm.Name = "buttonMappingForm";
            this.buttonMappingForm.Size = new System.Drawing.Size(189, 23);
            this.buttonMappingForm.TabIndex = 2;
            this.buttonMappingForm.Text = "Mapping Tools";
            this.buttonMappingForm.UseVisualStyleBackColor = true;
            this.buttonMappingForm.Click += new System.EventHandler(this.ButtonMappingForm_Click);
            // 
            // buttonSelectDamnedDirectory
            // 
            this.buttonSelectDamnedDirectory.Location = new System.Drawing.Point(12, 50);
            this.buttonSelectDamnedDirectory.Name = "buttonSelectDamnedDirectory";
            this.buttonSelectDamnedDirectory.Size = new System.Drawing.Size(189, 23);
            this.buttonSelectDamnedDirectory.TabIndex = 3;
            this.buttonSelectDamnedDirectory.Text = "Select Damned Directory";
            this.buttonSelectDamnedDirectory.UseVisualStyleBackColor = true;
            this.buttonSelectDamnedDirectory.Click += new System.EventHandler(this.ButtonSelectDamnedDirectory_Click);
            // 
            // labelDamnedDirectory
            // 
            this.labelDamnedDirectory.AutoSize = true;
            this.labelDamnedDirectory.Location = new System.Drawing.Point(12, 15);
            this.labelDamnedDirectory.Name = "labelDamnedDirectory";
            this.labelDamnedDirectory.Size = new System.Drawing.Size(95, 13);
            this.labelDamnedDirectory.TabIndex = 4;
            this.labelDamnedDirectory.Text = "Damned Directory:";
            // 
            // labelDamnedDirectoryPath
            // 
            this.labelDamnedDirectoryPath.AutoSize = true;
            this.labelDamnedDirectoryPath.Location = new System.Drawing.Point(104, 15);
            this.labelDamnedDirectoryPath.Name = "labelDamnedDirectoryPath";
            this.labelDamnedDirectoryPath.Size = new System.Drawing.Size(35, 13);
            this.labelDamnedDirectoryPath.TabIndex = 5;
            this.labelDamnedDirectoryPath.Text = "label2";
            // 
            // buttonCheckPath
            // 
            this.buttonCheckPath.AutoSize = true;
            this.buttonCheckPath.Location = new System.Drawing.Point(207, 50);
            this.buttonCheckPath.Name = "buttonCheckPath";
            this.buttonCheckPath.Size = new System.Drawing.Size(57, 23);
            this.buttonCheckPath.TabIndex = 6;
            this.buttonCheckPath.Text = "Check...";
            this.buttonCheckPath.UseVisualStyleBackColor = true;
            this.buttonCheckPath.Click += new System.EventHandler(this.ButtonCheckPath_Click);
            // 
            // DamnedMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCheckPath);
            this.Controls.Add(this.labelDamnedDirectoryPath);
            this.Controls.Add(this.labelDamnedDirectory);
            this.Controls.Add(this.buttonSelectDamnedDirectory);
            this.Controls.Add(this.buttonMappingForm);
            this.Controls.Add(this.buttonPatcherForm);
            this.Controls.Add(this.damnedWelcomeTextbox);
            this.Name = "DamnedMainForm";
            this.Text = "Damned Workshop";
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
    }
}