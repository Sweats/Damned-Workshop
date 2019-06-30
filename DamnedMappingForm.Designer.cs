namespace DamnedWorkshop
{
    partial class DamnedMappingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DamnedMappingForm));
            this.buttonAddMapIntoDamned = new System.Windows.Forms.Button();
            this.buttonSelectMapLoadingScreen = new System.Windows.Forms.Button();
            this.buttonSelectLobbyButtonPicture = new System.Windows.Forms.Button();
            this.buttonModifyStages = new System.Windows.Forms.Button();
            this.labelMapToAdd = new System.Windows.Forms.Label();
            this.toolTipAddMapIntoDamnedButton = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSelectLoadingScreen = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSelectLobbyButtonPicture = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAddMapFinalButton = new System.Windows.Forms.ToolTip(this.components);
            this.damnedStagesTextBox = new System.Windows.Forms.RichTextBox();
            this.labelLobbyButtonPicture = new System.Windows.Forms.Label();
            this.labelLoadingScreenImage = new System.Windows.Forms.Label();
            this.labelListOfMaps = new System.Windows.Forms.Label();
            this.buttonRemoveMap = new System.Windows.Forms.Button();
            this.labelMapToRemove = new System.Windows.Forms.Label();
            this.toolTipRemoveMapFromDamnedButton = new System.Windows.Forms.ToolTip(this.components);
            this.buttonResetPendingChanges = new System.Windows.Forms.Button();
            this.buttonAddStageToList = new System.Windows.Forms.Button();
            this.buttonSelectHighlightedLobbyButtons = new System.Windows.Forms.Button();
            this.pictureLobbyButtonHighlightedExample = new System.Windows.Forms.PictureBox();
            this.pictureDamnedButtonLobbyPicture = new System.Windows.Forms.PictureBox();
            this.labelSelectedHighlightedButton = new System.Windows.Forms.Label();
            this.buttonSelectSceneFile = new System.Windows.Forms.Button();
            this.labelScene = new System.Windows.Forms.Label();
            this.toolTipLobbyPicture = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipExamplePicture = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSelectSceneToRemove = new System.Windows.Forms.Button();
            this.labelSelectSceneFileToRemove = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLobbyButtonHighlightedExample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDamnedButtonLobbyPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddMapIntoDamned
            // 
            this.buttonAddMapIntoDamned.Location = new System.Drawing.Point(12, 12);
            this.buttonAddMapIntoDamned.Name = "buttonAddMapIntoDamned";
            this.buttonAddMapIntoDamned.Size = new System.Drawing.Size(159, 23);
            this.buttonAddMapIntoDamned.TabIndex = 0;
            this.buttonAddMapIntoDamned.Text = "Select Stage to Add..";
            this.toolTipAddMapIntoDamnedButton.SetToolTip(this.buttonAddMapIntoDamned, "Opens up the file explorer for you to select a stage fille.\r\n\r\nThe stage file wil" +
        "l be put onto the list on the right in green to be added into the game.");
            this.buttonAddMapIntoDamned.UseVisualStyleBackColor = true;
            this.buttonAddMapIntoDamned.Click += new System.EventHandler(this.ButtonAddMapIntoDamned_Click);
            // 
            // buttonSelectMapLoadingScreen
            // 
            this.buttonSelectMapLoadingScreen.Enabled = false;
            this.buttonSelectMapLoadingScreen.Location = new System.Drawing.Point(12, 459);
            this.buttonSelectMapLoadingScreen.Name = "buttonSelectMapLoadingScreen";
            this.buttonSelectMapLoadingScreen.Size = new System.Drawing.Size(160, 23);
            this.buttonSelectMapLoadingScreen.TabIndex = 1;
            this.buttonSelectMapLoadingScreen.Text = "Select Loading Screen...";
            this.toolTipSelectLoadingScreen.SetToolTip(this.buttonSelectMapLoadingScreen, "Opens up the file explorer for you to select a .png file\r\n\r\nThe dimensions of the" +
        " image must be 1920x1080 for the game to read it properly.");
            this.buttonSelectMapLoadingScreen.UseVisualStyleBackColor = true;
            this.buttonSelectMapLoadingScreen.Click += new System.EventHandler(this.ButtonSelectMapLoadingScreen_Click);
            // 
            // buttonSelectLobbyButtonPicture
            // 
            this.buttonSelectLobbyButtonPicture.Enabled = false;
            this.buttonSelectLobbyButtonPicture.Location = new System.Drawing.Point(12, 160);
            this.buttonSelectLobbyButtonPicture.Name = "buttonSelectLobbyButtonPicture";
            this.buttonSelectLobbyButtonPicture.Size = new System.Drawing.Size(159, 28);
            this.buttonSelectLobbyButtonPicture.TabIndex = 2;
            this.buttonSelectLobbyButtonPicture.Text = "Select Lobby Button Picture...";
            this.toolTipSelectLobbyButtonPicture.SetToolTip(this.buttonSelectLobbyButtonPicture, "Opens up the file explorer for you to select a .png file\r\n\r\nThe dimensions of the" +
        " image must be 300x100 for the game to read it properly.\r\n");
            this.buttonSelectLobbyButtonPicture.UseVisualStyleBackColor = true;
            this.buttonSelectLobbyButtonPicture.Click += new System.EventHandler(this.ButtonSelectLobbyButtonPicture_Click);
            // 
            // buttonModifyStages
            // 
            this.buttonModifyStages.Enabled = false;
            this.buttonModifyStages.Location = new System.Drawing.Point(12, 545);
            this.buttonModifyStages.Name = "buttonModifyStages";
            this.buttonModifyStages.Size = new System.Drawing.Size(160, 23);
            this.buttonModifyStages.TabIndex = 3;
            this.buttonModifyStages.Text = "Modify Stages";
            this.toolTipAddMapFinalButton.SetToolTip(this.buttonModifyStages, "Opens up the file explorer for you to select a .stage file.");
            this.buttonModifyStages.UseVisualStyleBackColor = true;
            this.buttonModifyStages.Click += new System.EventHandler(this.ButtonModifyStages_Click);
            // 
            // labelMapToAdd
            // 
            this.labelMapToAdd.AutoSize = true;
            this.labelMapToAdd.Location = new System.Drawing.Point(178, 17);
            this.labelMapToAdd.Name = "labelMapToAdd";
            this.labelMapToAdd.Size = new System.Drawing.Size(111, 13);
            this.labelMapToAdd.TabIndex = 5;
            this.labelMapToAdd.Text = "Choose a map to add:";
            // 
            // damnedStagesTextBox
            // 
            this.damnedStagesTextBox.Location = new System.Drawing.Point(940, 55);
            this.damnedStagesTextBox.Name = "damnedStagesTextBox";
            this.damnedStagesTextBox.ReadOnly = true;
            this.damnedStagesTextBox.Size = new System.Drawing.Size(205, 293);
            this.damnedStagesTextBox.TabIndex = 6;
            this.damnedStagesTextBox.Text = "";
            // 
            // labelLobbyButtonPicture
            // 
            this.labelLobbyButtonPicture.AutoSize = true;
            this.labelLobbyButtonPicture.Location = new System.Drawing.Point(178, 168);
            this.labelLobbyButtonPicture.Name = "labelLobbyButtonPicture";
            this.labelLobbyButtonPicture.Size = new System.Drawing.Size(151, 13);
            this.labelLobbyButtonPicture.TabIndex = 7;
            this.labelLobbyButtonPicture.Text = "Choose a lobby button picture:";
            // 
            // labelLoadingScreenImage
            // 
            this.labelLoadingScreenImage.AutoSize = true;
            this.labelLoadingScreenImage.Location = new System.Drawing.Point(178, 464);
            this.labelLoadingScreenImage.Name = "labelLoadingScreenImage";
            this.labelLoadingScreenImage.Size = new System.Drawing.Size(162, 13);
            this.labelLoadingScreenImage.TabIndex = 9;
            this.labelLoadingScreenImage.Text = "Choose a loading screen picture:";
            // 
            // labelListOfMaps
            // 
            this.labelListOfMaps.AutoSize = true;
            this.labelListOfMaps.Location = new System.Drawing.Point(937, 16);
            this.labelListOfMaps.Name = "labelListOfMaps";
            this.labelListOfMaps.Size = new System.Drawing.Size(218, 13);
            this.labelListOfMaps.TabIndex = 10;
            this.labelListOfMaps.Text = "List of maps that you curerntly have installed:";
            // 
            // buttonRemoveMap
            // 
            this.buttonRemoveMap.Location = new System.Drawing.Point(12, 95);
            this.buttonRemoveMap.Name = "buttonRemoveMap";
            this.buttonRemoveMap.Size = new System.Drawing.Size(159, 23);
            this.buttonRemoveMap.TabIndex = 12;
            this.buttonRemoveMap.Text = "Select Stage to Remove...";
            this.toolTipRemoveMapFromDamnedButton.SetToolTip(this.buttonRemoveMap, "Opens up the file explorer for you to select a stage file.\r\n\r\nThe stage file will" +
        " be marked on the list at the right in red to be removed from the game.");
            this.buttonRemoveMap.UseVisualStyleBackColor = true;
            this.buttonRemoveMap.Click += new System.EventHandler(this.ButtonRemoveMap_Click);
            // 
            // labelMapToRemove
            // 
            this.labelMapToRemove.AutoSize = true;
            this.labelMapToRemove.Location = new System.Drawing.Point(178, 100);
            this.labelMapToRemove.Name = "labelMapToRemove";
            this.labelMapToRemove.Size = new System.Drawing.Size(128, 13);
            this.labelMapToRemove.TabIndex = 13;
            this.labelMapToRemove.Text = "Choose a map to remove:";
            // 
            // buttonResetPendingChanges
            // 
            this.buttonResetPendingChanges.Location = new System.Drawing.Point(12, 583);
            this.buttonResetPendingChanges.Name = "buttonResetPendingChanges";
            this.buttonResetPendingChanges.Size = new System.Drawing.Size(160, 23);
            this.buttonResetPendingChanges.TabIndex = 14;
            this.buttonResetPendingChanges.Text = "Reset Pending Changes";
            this.buttonResetPendingChanges.UseVisualStyleBackColor = true;
            this.buttonResetPendingChanges.Click += new System.EventHandler(this.ButtonResetPendingChanges_Click);
            // 
            // buttonAddStageToList
            // 
            this.buttonAddStageToList.Enabled = false;
            this.buttonAddStageToList.Location = new System.Drawing.Point(12, 499);
            this.buttonAddStageToList.Name = "buttonAddStageToList";
            this.buttonAddStageToList.Size = new System.Drawing.Size(160, 23);
            this.buttonAddStageToList.TabIndex = 15;
            this.buttonAddStageToList.Text = "Add New Stage To List";
            this.buttonAddStageToList.UseVisualStyleBackColor = true;
            this.buttonAddStageToList.Click += new System.EventHandler(this.ButtonAddStageToList_Click);
            // 
            // buttonSelectHighlightedLobbyButtons
            // 
            this.buttonSelectHighlightedLobbyButtons.Enabled = false;
            this.buttonSelectHighlightedLobbyButtons.Location = new System.Drawing.Point(12, 309);
            this.buttonSelectHighlightedLobbyButtons.Name = "buttonSelectHighlightedLobbyButtons";
            this.buttonSelectHighlightedLobbyButtons.Size = new System.Drawing.Size(160, 23);
            this.buttonSelectHighlightedLobbyButtons.TabIndex = 17;
            this.buttonSelectHighlightedLobbyButtons.Text = "Select Highlighted Buttons";
            this.buttonSelectHighlightedLobbyButtons.UseVisualStyleBackColor = true;
            this.buttonSelectHighlightedLobbyButtons.Click += new System.EventHandler(this.ButtonSelectHighlightedLobbyButtons_Click);
            // 
            // pictureLobbyButtonHighlightedExample
            // 
            this.pictureLobbyButtonHighlightedExample.Image = global::DamnedWorkshop.Properties.Resources.example_lobbyButtonImage;
            this.pictureLobbyButtonHighlightedExample.InitialImage = global::DamnedWorkshop.Properties.Resources.example_lobbyButtonImage;
            this.pictureLobbyButtonHighlightedExample.Location = new System.Drawing.Point(12, 338);
            this.pictureLobbyButtonHighlightedExample.Name = "pictureLobbyButtonHighlightedExample";
            this.pictureLobbyButtonHighlightedExample.Size = new System.Drawing.Size(900, 100);
            this.pictureLobbyButtonHighlightedExample.TabIndex = 18;
            this.pictureLobbyButtonHighlightedExample.TabStop = false;
            this.toolTipExamplePicture.SetToolTip(this.pictureLobbyButtonHighlightedExample, resources.GetString("pictureLobbyButtonHighlightedExample.ToolTip"));
            // 
            // pictureDamnedButtonLobbyPicture
            // 
            this.pictureDamnedButtonLobbyPicture.Image = global::DamnedWorkshop.Properties.Resources.lobbyButtonImageExample;
            this.pictureDamnedButtonLobbyPicture.InitialImage = global::DamnedWorkshop.Properties.Resources.lobbyButtonImageExample;
            this.pictureDamnedButtonLobbyPicture.Location = new System.Drawing.Point(12, 194);
            this.pictureDamnedButtonLobbyPicture.Name = "pictureDamnedButtonLobbyPicture";
            this.pictureDamnedButtonLobbyPicture.Size = new System.Drawing.Size(300, 100);
            this.pictureDamnedButtonLobbyPicture.TabIndex = 16;
            this.pictureDamnedButtonLobbyPicture.TabStop = false;
            this.toolTipLobbyPicture.SetToolTip(this.pictureDamnedButtonLobbyPicture, "Your selected lobby picture will appear here.\r\n\r\nNOTE: The size of the image must" +
        " be 300 X 100 or the game may not render it correctly.");
            // 
            // labelSelectedHighlightedButton
            // 
            this.labelSelectedHighlightedButton.AutoSize = true;
            this.labelSelectedHighlightedButton.Location = new System.Drawing.Point(178, 314);
            this.labelSelectedHighlightedButton.Name = "labelSelectedHighlightedButton";
            this.labelSelectedHighlightedButton.Size = new System.Drawing.Size(286, 13);
            this.labelSelectedHighlightedButton.TabIndex = 19;
            this.labelSelectedHighlightedButton.Text = "Choose an enabled, highlighted, and disabled lobby button:";
            // 
            // buttonSelectSceneFile
            // 
            this.buttonSelectSceneFile.Enabled = false;
            this.buttonSelectSceneFile.Location = new System.Drawing.Point(12, 53);
            this.buttonSelectSceneFile.Name = "buttonSelectSceneFile";
            this.buttonSelectSceneFile.Size = new System.Drawing.Size(159, 23);
            this.buttonSelectSceneFile.TabIndex = 20;
            this.buttonSelectSceneFile.Text = "Select Scene File";
            this.buttonSelectSceneFile.UseVisualStyleBackColor = true;
            this.buttonSelectSceneFile.Click += new System.EventHandler(this.ButtonSelectSceneFile_Click);
            // 
            // labelScene
            // 
            this.labelScene.AutoSize = true;
            this.labelScene.Location = new System.Drawing.Point(178, 58);
            this.labelScene.Name = "labelScene";
            this.labelScene.Size = new System.Drawing.Size(224, 13);
            this.labelScene.TabIndex = 21;
            this.labelScene.Text = "Choose a scene file that goes with your stage:\r\n";
            // 
            // buttonSelectSceneToRemove
            // 
            this.buttonSelectSceneToRemove.Enabled = false;
            this.buttonSelectSceneToRemove.Location = new System.Drawing.Point(12, 131);
            this.buttonSelectSceneToRemove.Name = "buttonSelectSceneToRemove";
            this.buttonSelectSceneToRemove.Size = new System.Drawing.Size(160, 23);
            this.buttonSelectSceneToRemove.TabIndex = 22;
            this.buttonSelectSceneToRemove.Text = "Select Scene To Remove";
            this.buttonSelectSceneToRemove.UseVisualStyleBackColor = true;
            this.buttonSelectSceneToRemove.Click += new System.EventHandler(this.ButtonSelectSceneToRemove_Click);
            // 
            // labelSelectSceneFileToRemove
            // 
            this.labelSelectSceneFileToRemove.AutoSize = true;
            this.labelSelectSceneFileToRemove.Location = new System.Drawing.Point(178, 136);
            this.labelSelectSceneFileToRemove.Name = "labelSelectSceneFileToRemove";
            this.labelSelectSceneFileToRemove.Size = new System.Drawing.Size(222, 13);
            this.labelSelectSceneFileToRemove.TabIndex = 23;
            this.labelSelectSceneFileToRemove.Text = "Choose a scene file to remove with the stage:\r\n";
            // 
            // DamnedMappingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 651);
            this.Controls.Add(this.labelSelectSceneFileToRemove);
            this.Controls.Add(this.buttonSelectSceneToRemove);
            this.Controls.Add(this.labelScene);
            this.Controls.Add(this.buttonSelectSceneFile);
            this.Controls.Add(this.labelSelectedHighlightedButton);
            this.Controls.Add(this.pictureLobbyButtonHighlightedExample);
            this.Controls.Add(this.buttonSelectHighlightedLobbyButtons);
            this.Controls.Add(this.buttonAddStageToList);
            this.Controls.Add(this.buttonResetPendingChanges);
            this.Controls.Add(this.labelMapToRemove);
            this.Controls.Add(this.buttonRemoveMap);
            this.Controls.Add(this.pictureDamnedButtonLobbyPicture);
            this.Controls.Add(this.labelListOfMaps);
            this.Controls.Add(this.labelLoadingScreenImage);
            this.Controls.Add(this.labelLobbyButtonPicture);
            this.Controls.Add(this.damnedStagesTextBox);
            this.Controls.Add(this.labelMapToAdd);
            this.Controls.Add(this.buttonModifyStages);
            this.Controls.Add(this.buttonSelectLobbyButtonPicture);
            this.Controls.Add(this.buttonSelectMapLoadingScreen);
            this.Controls.Add(this.buttonAddMapIntoDamned);
            this.Name = "DamnedMappingForm";
            this.Text = "Damned Workshop (Mapping Tools)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLobbyButtonHighlightedExample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDamnedButtonLobbyPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddMapIntoDamned;
        private System.Windows.Forms.Button buttonSelectMapLoadingScreen;
        private System.Windows.Forms.Button buttonSelectLobbyButtonPicture;
        private System.Windows.Forms.Button buttonModifyStages;
        private System.Windows.Forms.Label labelMapToAdd;
        private System.Windows.Forms.ToolTip toolTipSelectLoadingScreen;
        private System.Windows.Forms.ToolTip toolTipSelectLobbyButtonPicture;
        private System.Windows.Forms.ToolTip toolTipAddMapFinalButton;
        private System.Windows.Forms.ToolTip toolTipAddMapIntoDamnedButton;
        private System.Windows.Forms.RichTextBox damnedStagesTextBox;
        private System.Windows.Forms.Label labelLobbyButtonPicture;
        private System.Windows.Forms.Label labelLoadingScreenImage;
        private System.Windows.Forms.Label labelListOfMaps;
        private System.Windows.Forms.PictureBox pictureDamnedButtonLobbyPicture;
        private System.Windows.Forms.Button buttonRemoveMap;
        private System.Windows.Forms.Label labelMapToRemove;
        private System.Windows.Forms.ToolTip toolTipRemoveMapFromDamnedButton;
        private System.Windows.Forms.Button buttonResetPendingChanges;
        private System.Windows.Forms.Button buttonAddStageToList;
        private System.Windows.Forms.Button buttonSelectHighlightedLobbyButtons;
        private System.Windows.Forms.PictureBox pictureLobbyButtonHighlightedExample;
        private System.Windows.Forms.Label labelSelectedHighlightedButton;
        private System.Windows.Forms.Button buttonSelectSceneFile;
        private System.Windows.Forms.Label labelScene;
        private System.Windows.Forms.ToolTip toolTipExamplePicture;
        private System.Windows.Forms.ToolTip toolTipLobbyPicture;
        private System.Windows.Forms.Button buttonSelectSceneToRemove;
        private System.Windows.Forms.Label labelSelectSceneFileToRemove;
    }
}