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
            this.buttonSelectPackage = new System.Windows.Forms.Button();
            this.labelOr = new System.Windows.Forms.Label();
            this.buttonPackageStage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSelectObjectsForStage = new System.Windows.Forms.Button();
            this.checkBoxCustomObjects = new System.Windows.Forms.CheckBox();
            this.labelObjectsCount = new System.Windows.Forms.Label();
            this.toolTipResetPendingChanges = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipModfyStages = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPackageNewStage = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAddNewStageToList = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSelectCustomObjectsForStage = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipCustomObjectsCheckbox = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSelectHighlightedButtons = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSelectSceneToRemove = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSelectSceneFileToAdd = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLobbyButtonHighlightedExample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDamnedButtonLobbyPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddMapIntoDamned
            // 
            this.buttonAddMapIntoDamned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonAddMapIntoDamned.FlatAppearance.BorderSize = 0;
            this.buttonAddMapIntoDamned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMapIntoDamned.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMapIntoDamned.ForeColor = System.Drawing.Color.White;
            this.buttonAddMapIntoDamned.Location = new System.Drawing.Point(12, 12);
            this.buttonAddMapIntoDamned.Name = "buttonAddMapIntoDamned";
            this.buttonAddMapIntoDamned.Size = new System.Drawing.Size(159, 23);
            this.buttonAddMapIntoDamned.TabIndex = 0;
            this.buttonAddMapIntoDamned.Text = "Select Stage to Add..";
            this.toolTipAddMapIntoDamnedButton.SetToolTip(this.buttonAddMapIntoDamned, "Opens up the file explorer for you to select a stage fille that will be added int" +
        "o the game when you modify stages later.");
            this.buttonAddMapIntoDamned.UseVisualStyleBackColor = false;
            this.buttonAddMapIntoDamned.Click += new System.EventHandler(this.ButtonAddMapIntoDamned_Click);
            // 
            // buttonSelectMapLoadingScreen
            // 
            this.buttonSelectMapLoadingScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonSelectMapLoadingScreen.Enabled = false;
            this.buttonSelectMapLoadingScreen.FlatAppearance.BorderSize = 0;
            this.buttonSelectMapLoadingScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectMapLoadingScreen.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectMapLoadingScreen.ForeColor = System.Drawing.Color.White;
            this.buttonSelectMapLoadingScreen.Location = new System.Drawing.Point(12, 460);
            this.buttonSelectMapLoadingScreen.Name = "buttonSelectMapLoadingScreen";
            this.buttonSelectMapLoadingScreen.Size = new System.Drawing.Size(146, 23);
            this.buttonSelectMapLoadingScreen.TabIndex = 1;
            this.buttonSelectMapLoadingScreen.Text = "Select Loading Screen...";
            this.toolTipSelectLoadingScreen.SetToolTip(this.buttonSelectMapLoadingScreen, "Opens up the file explorer for you to select a .png file\r\n\r\nThe dimensions of the" +
        " image must be 1920x1080 for the game to read it properly.");
            this.buttonSelectMapLoadingScreen.UseVisualStyleBackColor = false;
            this.buttonSelectMapLoadingScreen.Click += new System.EventHandler(this.ButtonSelectMapLoadingScreen_Click);
            // 
            // buttonSelectLobbyButtonPicture
            // 
            this.buttonSelectLobbyButtonPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonSelectLobbyButtonPicture.Enabled = false;
            this.buttonSelectLobbyButtonPicture.FlatAppearance.BorderSize = 0;
            this.buttonSelectLobbyButtonPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectLobbyButtonPicture.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectLobbyButtonPicture.ForeColor = System.Drawing.Color.White;
            this.buttonSelectLobbyButtonPicture.Location = new System.Drawing.Point(12, 160);
            this.buttonSelectLobbyButtonPicture.Name = "buttonSelectLobbyButtonPicture";
            this.buttonSelectLobbyButtonPicture.Size = new System.Drawing.Size(159, 28);
            this.buttonSelectLobbyButtonPicture.TabIndex = 2;
            this.buttonSelectLobbyButtonPicture.Text = "Select Lobby Button Picture...";
            this.toolTipSelectLobbyButtonPicture.SetToolTip(this.buttonSelectLobbyButtonPicture, "Opens up the file explorer for you to select a .png file\r\n\r\nThe dimensions of the" +
        " image must be 300x100 for the game to read it properly.\r\n");
            this.buttonSelectLobbyButtonPicture.UseVisualStyleBackColor = false;
            this.buttonSelectLobbyButtonPicture.Click += new System.EventHandler(this.ButtonSelectLobbyButtonPicture_Click);
            // 
            // buttonModifyStages
            // 
            this.buttonModifyStages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonModifyStages.Enabled = false;
            this.buttonModifyStages.FlatAppearance.BorderSize = 0;
            this.buttonModifyStages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifyStages.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifyStages.ForeColor = System.Drawing.Color.White;
            this.buttonModifyStages.Location = new System.Drawing.Point(12, 628);
            this.buttonModifyStages.Name = "buttonModifyStages";
            this.buttonModifyStages.Size = new System.Drawing.Size(89, 23);
            this.buttonModifyStages.TabIndex = 3;
            this.buttonModifyStages.Text = "Modify Stages";
            this.toolTipModfyStages.SetToolTip(this.buttonModifyStages, "Adds and/or removes stages from the game.\r\n\r\nStages that appear on the right in o" +
        "range will be added into the game,\r\n\r\nStages that appear on the right in red wil" +
        "l be removed from the game.");
            this.buttonModifyStages.UseVisualStyleBackColor = false;
            this.buttonModifyStages.Click += new System.EventHandler(this.ButtonModifyStages_Click);
            // 
            // labelMapToAdd
            // 
            this.labelMapToAdd.AutoSize = true;
            this.labelMapToAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.labelMapToAdd.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMapToAdd.ForeColor = System.Drawing.Color.White;
            this.labelMapToAdd.Location = new System.Drawing.Point(334, 16);
            this.labelMapToAdd.Name = "labelMapToAdd";
            this.labelMapToAdd.Size = new System.Drawing.Size(123, 14);
            this.labelMapToAdd.TabIndex = 5;
            this.labelMapToAdd.Text = "Choose a map to add:";
            // 
            // toolTipAddMapIntoDamnedButton
            // 
            this.toolTipAddMapIntoDamnedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            // 
            // toolTipSelectLoadingScreen
            // 
            this.toolTipSelectLoadingScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            // 
            // toolTipSelectLobbyButtonPicture
            // 
            this.toolTipSelectLobbyButtonPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            // 
            // toolTipAddMapFinalButton
            // 
            this.toolTipAddMapFinalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            // 
            // damnedStagesTextBox
            // 
            this.damnedStagesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.damnedStagesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.damnedStagesTextBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.damnedStagesTextBox.DetectUrls = false;
            this.damnedStagesTextBox.Font = new System.Drawing.Font("Romance Fatal Serif Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damnedStagesTextBox.ForeColor = System.Drawing.Color.White;
            this.damnedStagesTextBox.Location = new System.Drawing.Point(940, 53);
            this.damnedStagesTextBox.Name = "damnedStagesTextBox";
            this.damnedStagesTextBox.ReadOnly = true;
            this.damnedStagesTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.damnedStagesTextBox.Size = new System.Drawing.Size(255, 586);
            this.damnedStagesTextBox.TabIndex = 6;
            this.damnedStagesTextBox.Text = "";
            // 
            // labelLobbyButtonPicture
            // 
            this.labelLobbyButtonPicture.AutoSize = true;
            this.labelLobbyButtonPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.labelLobbyButtonPicture.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLobbyButtonPicture.ForeColor = System.Drawing.Color.White;
            this.labelLobbyButtonPicture.Location = new System.Drawing.Point(168, 163);
            this.labelLobbyButtonPicture.Name = "labelLobbyButtonPicture";
            this.labelLobbyButtonPicture.Size = new System.Drawing.Size(166, 14);
            this.labelLobbyButtonPicture.TabIndex = 7;
            this.labelLobbyButtonPicture.Text = "Choose a lobby button picture:";
            // 
            // labelLoadingScreenImage
            // 
            this.labelLoadingScreenImage.AutoSize = true;
            this.labelLoadingScreenImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.labelLoadingScreenImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLoadingScreenImage.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoadingScreenImage.ForeColor = System.Drawing.Color.White;
            this.labelLoadingScreenImage.Location = new System.Drawing.Point(164, 464);
            this.labelLoadingScreenImage.Name = "labelLoadingScreenImage";
            this.labelLoadingScreenImage.Size = new System.Drawing.Size(179, 14);
            this.labelLoadingScreenImage.TabIndex = 9;
            this.labelLoadingScreenImage.Text = "Choose a loading screen picture:";
            // 
            // labelListOfMaps
            // 
            this.labelListOfMaps.AutoSize = true;
            this.labelListOfMaps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.labelListOfMaps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelListOfMaps.Font = new System.Drawing.Font("Romance Fatal Serif Std", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListOfMaps.ForeColor = System.Drawing.Color.White;
            this.labelListOfMaps.Location = new System.Drawing.Point(937, 17);
            this.labelListOfMaps.Name = "labelListOfMaps";
            this.labelListOfMaps.Size = new System.Drawing.Size(153, 18);
            this.labelListOfMaps.TabIndex = 10;
            this.labelListOfMaps.Text = "List of installed stages:\r\n";
            // 
            // buttonRemoveMap
            // 
            this.buttonRemoveMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonRemoveMap.FlatAppearance.BorderSize = 0;
            this.buttonRemoveMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveMap.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveMap.ForeColor = System.Drawing.Color.White;
            this.buttonRemoveMap.Location = new System.Drawing.Point(12, 95);
            this.buttonRemoveMap.Name = "buttonRemoveMap";
            this.buttonRemoveMap.Size = new System.Drawing.Size(159, 23);
            this.buttonRemoveMap.TabIndex = 12;
            this.buttonRemoveMap.Text = "Select Stage to Remove...";
            this.toolTipRemoveMapFromDamnedButton.SetToolTip(this.buttonRemoveMap, "Opens up the file explorer for you to select a stage file that will be removed fr" +
        "om the game when you modify stages later.");
            this.buttonRemoveMap.UseVisualStyleBackColor = false;
            this.buttonRemoveMap.Click += new System.EventHandler(this.ButtonRemoveMap_Click);
            // 
            // labelMapToRemove
            // 
            this.labelMapToRemove.AutoSize = true;
            this.labelMapToRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.labelMapToRemove.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMapToRemove.ForeColor = System.Drawing.Color.White;
            this.labelMapToRemove.Location = new System.Drawing.Point(168, 95);
            this.labelMapToRemove.Name = "labelMapToRemove";
            this.labelMapToRemove.Size = new System.Drawing.Size(143, 14);
            this.labelMapToRemove.TabIndex = 13;
            this.labelMapToRemove.Text = "Choose a map to remove:";
            // 
            // toolTipRemoveMapFromDamnedButton
            // 
            this.toolTipRemoveMapFromDamnedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            // 
            // buttonResetPendingChanges
            // 
            this.buttonResetPendingChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonResetPendingChanges.FlatAppearance.BorderSize = 0;
            this.buttonResetPendingChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResetPendingChanges.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetPendingChanges.ForeColor = System.Drawing.Color.White;
            this.buttonResetPendingChanges.Location = new System.Drawing.Point(12, 667);
            this.buttonResetPendingChanges.Name = "buttonResetPendingChanges";
            this.buttonResetPendingChanges.Size = new System.Drawing.Size(146, 23);
            this.buttonResetPendingChanges.TabIndex = 14;
            this.buttonResetPendingChanges.Text = "Reset Pending Changes";
            this.toolTipResetPendingChanges.SetToolTip(this.buttonResetPendingChanges, "Resets all of your changes and starts the process over again.");
            this.buttonResetPendingChanges.UseVisualStyleBackColor = false;
            this.buttonResetPendingChanges.Click += new System.EventHandler(this.ButtonResetPendingChanges_Click);
            // 
            // buttonAddStageToList
            // 
            this.buttonAddStageToList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonAddStageToList.Enabled = false;
            this.buttonAddStageToList.FlatAppearance.BorderSize = 0;
            this.buttonAddStageToList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStageToList.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStageToList.ForeColor = System.Drawing.Color.White;
            this.buttonAddStageToList.Location = new System.Drawing.Point(12, 582);
            this.buttonAddStageToList.Name = "buttonAddStageToList";
            this.buttonAddStageToList.Size = new System.Drawing.Size(138, 23);
            this.buttonAddStageToList.TabIndex = 15;
            this.buttonAddStageToList.Text = "Add New Stage To List";
            this.toolTipAddNewStageToList.SetToolTip(this.buttonAddStageToList, "Adds your current selected stage to the list on the right in orange.\r\n\r\nThe stage" +
        " will actually be added into the game when you hit the \"Modify Stages\" button.");
            this.buttonAddStageToList.UseVisualStyleBackColor = false;
            this.buttonAddStageToList.Click += new System.EventHandler(this.ButtonAddStageToList_Click);
            // 
            // buttonSelectHighlightedLobbyButtons
            // 
            this.buttonSelectHighlightedLobbyButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonSelectHighlightedLobbyButtons.Enabled = false;
            this.buttonSelectHighlightedLobbyButtons.FlatAppearance.BorderSize = 0;
            this.buttonSelectHighlightedLobbyButtons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectHighlightedLobbyButtons.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectHighlightedLobbyButtons.ForeColor = System.Drawing.Color.White;
            this.buttonSelectHighlightedLobbyButtons.Location = new System.Drawing.Point(12, 309);
            this.buttonSelectHighlightedLobbyButtons.Name = "buttonSelectHighlightedLobbyButtons";
            this.buttonSelectHighlightedLobbyButtons.Size = new System.Drawing.Size(160, 23);
            this.buttonSelectHighlightedLobbyButtons.TabIndex = 17;
            this.buttonSelectHighlightedLobbyButtons.Text = "Select Highlighted Buttons";
            this.toolTipSelectHighlightedButtons.SetToolTip(this.buttonSelectHighlightedLobbyButtons, "Opens up the file explorer for you to select an image that shows in the stage sel" +
        "ection screen.\r\n\r\nThe image must be 900 X 100 for the game to render it properly" +
        ".");
            this.buttonSelectHighlightedLobbyButtons.UseVisualStyleBackColor = false;
            this.buttonSelectHighlightedLobbyButtons.Click += new System.EventHandler(this.ButtonSelectHighlightedLobbyButtons_Click);
            // 
            // pictureLobbyButtonHighlightedExample
            // 
            this.pictureLobbyButtonHighlightedExample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
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
            this.pictureDamnedButtonLobbyPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
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
            this.labelSelectedHighlightedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.labelSelectedHighlightedButton.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectedHighlightedButton.ForeColor = System.Drawing.Color.White;
            this.labelSelectedHighlightedButton.Location = new System.Drawing.Point(168, 313);
            this.labelSelectedHighlightedButton.Name = "labelSelectedHighlightedButton";
            this.labelSelectedHighlightedButton.Size = new System.Drawing.Size(311, 14);
            this.labelSelectedHighlightedButton.TabIndex = 19;
            this.labelSelectedHighlightedButton.Text = "Choose an enabled, highlighted, and disabled lobby button:";
            // 
            // buttonSelectSceneFile
            // 
            this.buttonSelectSceneFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonSelectSceneFile.Enabled = false;
            this.buttonSelectSceneFile.FlatAppearance.BorderSize = 0;
            this.buttonSelectSceneFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectSceneFile.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectSceneFile.ForeColor = System.Drawing.Color.White;
            this.buttonSelectSceneFile.Location = new System.Drawing.Point(12, 53);
            this.buttonSelectSceneFile.Name = "buttonSelectSceneFile";
            this.buttonSelectSceneFile.Size = new System.Drawing.Size(159, 23);
            this.buttonSelectSceneFile.TabIndex = 20;
            this.buttonSelectSceneFile.Text = "Select Scene File";
            this.toolTipSelectSceneFileToAdd.SetToolTip(this.buttonSelectSceneFile, resources.GetString("buttonSelectSceneFile.ToolTip"));
            this.buttonSelectSceneFile.UseVisualStyleBackColor = false;
            this.buttonSelectSceneFile.Click += new System.EventHandler(this.ButtonSelectSceneFile_Click);
            // 
            // labelScene
            // 
            this.labelScene.AutoSize = true;
            this.labelScene.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.labelScene.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScene.ForeColor = System.Drawing.Color.White;
            this.labelScene.Location = new System.Drawing.Point(168, 53);
            this.labelScene.Name = "labelScene";
            this.labelScene.Size = new System.Drawing.Size(246, 14);
            this.labelScene.TabIndex = 21;
            this.labelScene.Text = "Choose a scene file that goes with your stage:\r\n";
            // 
            // toolTipLobbyPicture
            // 
            this.toolTipLobbyPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            // 
            // toolTipExamplePicture
            // 
            this.toolTipExamplePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            // 
            // buttonSelectSceneToRemove
            // 
            this.buttonSelectSceneToRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.buttonSelectSceneToRemove.Enabled = false;
            this.buttonSelectSceneToRemove.FlatAppearance.BorderSize = 0;
            this.buttonSelectSceneToRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectSceneToRemove.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectSceneToRemove.ForeColor = System.Drawing.Color.White;
            this.buttonSelectSceneToRemove.Location = new System.Drawing.Point(12, 131);
            this.buttonSelectSceneToRemove.Name = "buttonSelectSceneToRemove";
            this.buttonSelectSceneToRemove.Size = new System.Drawing.Size(160, 23);
            this.buttonSelectSceneToRemove.TabIndex = 22;
            this.buttonSelectSceneToRemove.Text = "Select Scene To Remove";
            this.toolTipSelectSceneToRemove.SetToolTip(this.buttonSelectSceneToRemove, resources.GetString("buttonSelectSceneToRemove.ToolTip"));
            this.buttonSelectSceneToRemove.UseVisualStyleBackColor = false;
            this.buttonSelectSceneToRemove.Click += new System.EventHandler(this.ButtonSelectSceneToRemove_Click);
            // 
            // labelSelectSceneFileToRemove
            // 
            this.labelSelectSceneFileToRemove.AutoSize = true;
            this.labelSelectSceneFileToRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.labelSelectSceneFileToRemove.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectSceneFileToRemove.ForeColor = System.Drawing.Color.White;
            this.labelSelectSceneFileToRemove.Location = new System.Drawing.Point(168, 131);
            this.labelSelectSceneFileToRemove.Name = "labelSelectSceneFileToRemove";
            this.labelSelectSceneFileToRemove.Size = new System.Drawing.Size(246, 14);
            this.labelSelectSceneFileToRemove.TabIndex = 23;
            this.labelSelectSceneFileToRemove.Text = "Choose a scene file to remove with the stage:\r\n";
            // 
            // buttonSelectPackage
            // 
            this.buttonSelectPackage.FlatAppearance.BorderSize = 0;
            this.buttonSelectPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectPackage.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectPackage.ForeColor = System.Drawing.Color.White;
            this.buttonSelectPackage.Location = new System.Drawing.Point(202, 12);
            this.buttonSelectPackage.Name = "buttonSelectPackage";
            this.buttonSelectPackage.Size = new System.Drawing.Size(132, 23);
            this.buttonSelectPackage.TabIndex = 24;
            this.buttonSelectPackage.Text = "Load From Package...\r\n";
            this.buttonSelectPackage.UseVisualStyleBackColor = true;
            this.buttonSelectPackage.Click += new System.EventHandler(this.ButtonSelectPackage_Click);
            // 
            // labelOr
            // 
            this.labelOr.AutoSize = true;
            this.labelOr.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(38)))));
            this.labelOr.Location = new System.Drawing.Point(173, 16);
            this.labelOr.Name = "labelOr";
            this.labelOr.Size = new System.Drawing.Size(23, 14);
            this.labelOr.TabIndex = 25;
            this.labelOr.Text = "OR";
            // 
            // buttonPackageStage
            // 
            this.buttonPackageStage.Enabled = false;
            this.buttonPackageStage.FlatAppearance.BorderSize = 0;
            this.buttonPackageStage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPackageStage.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPackageStage.ForeColor = System.Drawing.Color.White;
            this.buttonPackageStage.Location = new System.Drawing.Point(136, 628);
            this.buttonPackageStage.Name = "buttonPackageStage";
            this.buttonPackageStage.Size = new System.Drawing.Size(142, 23);
            this.buttonPackageStage.TabIndex = 26;
            this.buttonPackageStage.Text = "Package New Stage(s)...\r\n";
            this.toolTipPackageNewStage.SetToolTip(this.buttonPackageStage, "Opens up the folder explorer and asks you where you want to save your new Damned " +
        "package.\r\n\r\nIf you ever want to share your stage with someone, you should do thi" +
        "s.");
            this.buttonPackageStage.UseVisualStyleBackColor = true;
            this.buttonPackageStage.Click += new System.EventHandler(this.ButtonPackageStage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(107, 632);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 14);
            this.label1.TabIndex = 27;
            this.label1.Text = "OR";
            // 
            // buttonSelectObjectsForStage
            // 
            this.buttonSelectObjectsForStage.Enabled = false;
            this.buttonSelectObjectsForStage.FlatAppearance.BorderSize = 0;
            this.buttonSelectObjectsForStage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectObjectsForStage.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectObjectsForStage.ForeColor = System.Drawing.Color.White;
            this.buttonSelectObjectsForStage.Location = new System.Drawing.Point(12, 540);
            this.buttonSelectObjectsForStage.Name = "buttonSelectObjectsForStage";
            this.buttonSelectObjectsForStage.Size = new System.Drawing.Size(193, 23);
            this.buttonSelectObjectsForStage.TabIndex = 28;
            this.buttonSelectObjectsForStage.Text = "Select Custom Objects For Stage...\r\n";
            this.buttonSelectObjectsForStage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTipSelectCustomObjectsForStage.SetToolTip(this.buttonSelectObjectsForStage, resources.GetString("buttonSelectObjectsForStage.ToolTip"));
            this.buttonSelectObjectsForStage.UseVisualStyleBackColor = true;
            this.buttonSelectObjectsForStage.Click += new System.EventHandler(this.ButtonSelectObjectsForStage_Click);
            // 
            // checkBoxCustomObjects
            // 
            this.checkBoxCustomObjects.AutoSize = true;
            this.checkBoxCustomObjects.Enabled = false;
            this.checkBoxCustomObjects.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCustomObjects.ForeColor = System.Drawing.Color.White;
            this.checkBoxCustomObjects.Location = new System.Drawing.Point(23, 503);
            this.checkBoxCustomObjects.Name = "checkBoxCustomObjects";
            this.checkBoxCustomObjects.Size = new System.Drawing.Size(113, 18);
            this.checkBoxCustomObjects.TabIndex = 29;
            this.checkBoxCustomObjects.Text = "Custom Objects?";
            this.toolTipCustomObjectsCheckbox.SetToolTip(this.checkBoxCustomObjects, "Check this if you have custom objects that go with your stage.\r\n\r\nIf your stage h" +
        "as custom objects, you MUST check this and add custom objects to go with the sta" +
        "ge.");
            this.checkBoxCustomObjects.UseVisualStyleBackColor = true;
            this.checkBoxCustomObjects.CheckedChanged += new System.EventHandler(this.CheckBoxCustomObjects_CheckedChanged);
            // 
            // labelObjectsCount
            // 
            this.labelObjectsCount.AutoSize = true;
            this.labelObjectsCount.Font = new System.Drawing.Font("Romance Fatal Serif Std", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObjectsCount.ForeColor = System.Drawing.Color.White;
            this.labelObjectsCount.Location = new System.Drawing.Point(211, 544);
            this.labelObjectsCount.Name = "labelObjectsCount";
            this.labelObjectsCount.Size = new System.Drawing.Size(232, 14);
            this.labelObjectsCount.TabIndex = 30;
            this.labelObjectsCount.Text = "Number of new objects will be shown here.";
            // 
            // DamnedMappingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1196, 730);
            this.Controls.Add(this.labelObjectsCount);
            this.Controls.Add(this.checkBoxCustomObjects);
            this.Controls.Add(this.buttonSelectObjectsForStage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPackageStage);
            this.Controls.Add(this.labelOr);
            this.Controls.Add(this.buttonSelectPackage);
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
            this.Load += new System.EventHandler(this.DamnedMappingForm_Load);
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
        private System.Windows.Forms.Button buttonSelectPackage;
        private System.Windows.Forms.Label labelOr;
        private System.Windows.Forms.Button buttonPackageStage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelectObjectsForStage;
        private System.Windows.Forms.CheckBox checkBoxCustomObjects;
        private System.Windows.Forms.Label labelObjectsCount;
        private System.Windows.Forms.ToolTip toolTipModfyStages;
        private System.Windows.Forms.ToolTip toolTipResetPendingChanges;
        private System.Windows.Forms.ToolTip toolTipAddNewStageToList;
        private System.Windows.Forms.ToolTip toolTipSelectHighlightedButtons;
        private System.Windows.Forms.ToolTip toolTipSelectSceneFileToAdd;
        private System.Windows.Forms.ToolTip toolTipSelectSceneToRemove;
        private System.Windows.Forms.ToolTip toolTipPackageNewStage;
        private System.Windows.Forms.ToolTip toolTipSelectCustomObjectsForStage;
        private System.Windows.Forms.ToolTip toolTipCustomObjectsCheckbox;
    }
}