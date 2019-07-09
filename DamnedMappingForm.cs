using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace DamnedWorkshop
{

    public partial class DamnedMappingForm : Form
    {
        public List<DamnedNewStage> damnedNewStagesList { get; set; }
        public DamnedNewStage damnedNewStage { get; set; }
        public DamnedRemoveStage damnedRemoveStage { get; set; }
        public List<DamnedRemoveStage> damnedRemoveStagesList { get; set; }

        private bool changesMade;

        private string tempDirectory;
        private List<string> packagesTempDirectoryList;
        private DamnedMaps damnedMaps;
        private DamnedImages damnedImages;
        private DamnedMainForm mainForm;

        public DamnedMappingForm(DamnedMaps damnedMaps, DamnedImages damnedImages, DamnedMainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.mainForm.Hide();
            this.damnedMaps = damnedMaps;
            this.damnedImages = damnedImages;
            this.tempDirectory = String.Empty;
            packagesTempDirectoryList = new List<string>();
            damnedRemoveStage = new DamnedRemoveStage();
            damnedNewStage = new DamnedNewStage();
            damnedNewStagesList = new List<DamnedNewStage>();
            damnedRemoveStagesList = new List<DamnedRemoveStage>();
            RefreshDamnedStagesList();

        }

        private void ButtonAddMapIntoDamned_Click(object sender, EventArgs e)
        {
            SelectStage(false);
        }
        private void ButtonRemoveMap_Click(object sender, EventArgs e)
        {
            SelectStage(true);

        }


        private void ButtonSelectMapLoadingScreen_Click(object sender, EventArgs e)
        {
            string loadingImage = String.Empty;

            FileDialog dialog = new OpenFileDialog
            {
                Filter = "JPG Files (*.jpg)|*.jpg"
            };

            DialogResult result = dialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            loadingImage = dialog.FileName;

            if (Path.GetExtension(loadingImage) != ".jpg")
            {
                MessageBox.Show("You did not pick a jpg file. Please select one that is a .jpg file", "Please select a different file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Dimensions dimensions = DamnedImages.GetDimensions(loadingImage);

            if (dimensions.x != 1920 || dimensions.y != 1080)
            {
                string imageName = Path.GetFileName(loadingImage);
                MessageBox.Show(String.Format("The image \"{0}\" does not have the correct dimensions. It must be 1920 x 1080. Please select a different one.", imageName), "Incorrect image dimension", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (damnedNewStage.loadingImagePath == String.Empty)
            {
                damnedNewStage.count++;
            }

            damnedNewStage.loadingImagePath = loadingImage;
            buttonAddStageToList.Enabled = true;
            checkBoxCustomObjects.Enabled = true;

            if (checkBoxCustomObjects.Checked)
            {
                buttonAddStageToList.Enabled = false;
                buttonSelectObjectsForStage.Enabled = true;
            }

            labelLoadingScreenImage.Text = Path.GetFileName(damnedNewStage.loadingImagePath);
            labelLoadingScreenImage.ForeColor = Color.FromArgb(255, 168, 38);

        }


        private void ButtonSelectLobbyButtonPicture_Click(object sender, EventArgs e)
        {
            string buttonImage = String.Empty;

            FileDialog dialog = new OpenFileDialog
            {
                Filter = ("PNG Files (*.png)|*.png")
            };

            DialogResult result = dialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            buttonImage = dialog.FileName;

            if (Path.GetExtension(buttonImage) != ".png")
            {
                MessageBox.Show("You did not pick a png file. Please select one that is a .png file", "Please select a different file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Dimensions dimensions = DamnedImages.GetDimensions(buttonImage);

            if (dimensions.x != 300 || dimensions.y != 100)
            {
                string imageName = Path.GetFileName(buttonImage);
                MessageBox.Show(String.Format("The image \"{0}\" does not have the correct dimensions. It must be 300 x 100. Please select a different one", imageName), "Incorrect image dimensions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (damnedNewStage.lobbyImageButtonPath == String.Empty)
            {
                damnedNewStage.count++;
            }

            damnedNewStage.lobbyImageButtonPath = buttonImage;
            labelLobbyButtonPicture.Text = Path.GetFileName(damnedNewStage.lobbyImageButtonPath);
            labelLobbyButtonPicture.ForeColor = Color.FromArgb(255, 168, 38);
            buttonSelectHighlightedLobbyButtons.Enabled = true;
            pictureDamnedButtonLobbyPicture.ImageLocation = buttonImage;
        }

        private void RefreshDamnedStagesList(bool afterRemoving = false)
        {
            damnedStagesTextBox.Clear();
            List<string> sortedStages = new List<string>(damnedMaps.stages);
            List<string> newSortedStages = new List<string>(damnedNewStagesList.Count);
            List<string> stagesToBeRemoved = new List<string>(damnedRemoveStagesList.Count);

            for (int i = 0; i < sortedStages.Count; i++)
            {
                string stage = Path.GetFileNameWithoutExtension(sortedStages[i]);
                string modifiedStageName = stage.Replace("_", " ");
                sortedStages[i] = modifiedStageName;
            }

            for (int i = 0; i < damnedNewStagesList.Count; i++)
            {
                string stage = Path.GetFileNameWithoutExtension(damnedNewStagesList[i].newStagePath);
                string modifiedStageName = stage.Replace("_", " ");
                sortedStages.Add(modifiedStageName);
                newSortedStages.Add(modifiedStageName);
            }

            for (int i = 0; i < damnedRemoveStagesList.Count; i++)
            {
                string stage = Path.GetFileNameWithoutExtension(damnedRemoveStagesList[i].stagePath);
                string modifiedStageName = stage.Replace("_", " ");
                stagesToBeRemoved.Add(modifiedStageName);
            }

            sortedStages.Sort();

            for (int i = 0; i < sortedStages.Count; i++)
            {
                damnedStagesTextBox.AppendText(String.Format("{0}\n", sortedStages[i]));
            }

            MarkStages(newSortedStages, Color.FromArgb(255, 168, 38));

            if (!afterRemoving)
            {
                MarkStages(stagesToBeRemoved, Color.Red);
            }
        }

        private void MarkStages(List<string> stagesToBeMarked, Color color)
        {
            for (int i = 0; i < stagesToBeMarked.Count; i++)
            {
                MarkStage(stagesToBeMarked[i], color);
            }
        }

        private void MarkStage(string stage, Color color)
        {
            int index = damnedStagesTextBox.Find(stage);
            damnedStagesTextBox.Select(index, stage.Length);
            damnedStagesTextBox.SelectionColor = color;
        }



        private void SelectStage(bool remove)
        {
            FileDialog dialog = new OpenFileDialog();

            if (remove)
            {
                dialog.InitialDirectory = damnedMaps.stagesAndScenesDirectory;
            }

            dialog.Filter = "Stage Files (*.stage)|*.stage";
            DialogResult result = dialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            string stagePath = dialog.FileName;
            string stage = Path.GetFileName(stagePath);

            if (Path.GetExtension(stage) != ".stage")
            {
                MessageBox.Show("You did not pick a stage file. Please select one that is a .stage file", "Please select a different file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (stage.Contains("menu_background"))
            {
                MessageBox.Show("Either you picked the stage that is for the main menu or you decided to name your stage along the lines of \"menu_background\". Either pick a different one or rename your stage.", "Pick a different stage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (remove)
            {
                if (Path.GetFileName(Path.GetDirectoryName(stagePath)) != "Stages")
                {
                    MessageBox.Show("It seems that the stage that you have selected does not reside inside the Damned directory. Please select a different stage", "Please select a different file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                damnedRemoveStage.stagePath = stagePath;
                string newLabelText = Path.GetFileNameWithoutExtension(stage).Replace("_", " ");
                labelMapToRemove.Text = newLabelText;
                labelMapToRemove.ForeColor = Color.FromArgb(255, 168, 38);
                buttonSelectSceneToRemove.Enabled = true;
                changesMade = true;

            }

            else
            {
                if (damnedMaps.StageExists(stage))
                {
                    MessageBox.Show("This stage is already installed in the game. Please pick another.", "Stage Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string reason = String.Empty;

                if (!DamnedMaps.CheckInnerStageFile(stagePath, ref reason))
                {
                    MessageBox.Show(String.Format("{0} Please select a different stage file.", reason), "Failed to check the stage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }

                if (damnedNewStage.newStagePath == String.Empty)
                {
                    damnedNewStage.count++;
                }

                damnedNewStage.newStagePath = stagePath;
                string newLabelText = stage.Replace("_", " ").Remove(stage.IndexOf("."), 6);
                labelMapToAdd.Text = newLabelText;
                labelMapToAdd.ForeColor = Color.FromArgb(255, 168, 38);
                buttonSelectSceneFile.Enabled = true;
                changesMade = true;

            }
        }

        private void SelectScene(bool remove)
        {
            FileDialog dialog = new OpenFileDialog
            {
                Filter = "Scene Files(*.scene)|*.scene"
            };

            if (remove)
            {
                dialog.InitialDirectory = damnedMaps.stagesAndScenesDirectory;

            }

            DialogResult result = dialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            string scenePath = dialog.FileName;
            string sceneName = Path.GetFileName(scenePath);

            if (Path.GetExtension(scenePath) != ".scene")
            {
                MessageBox.Show("You did not pick a .scene file. Please select one that is a .scene file", "Please select a different file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (sceneName.Contains("menu_background"))
            {
                MessageBox.Show("Either you picked the scene that is for the main menu or you decided to name your scene along the lines of \"menu_background\". Either pick a different one or rename your scene.", "Pick a different scene", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (remove)
            {
                sceneName = sceneName.Replace("_", " ").Remove(sceneName.IndexOf("."), 6);

                if (sceneName != labelMapToRemove.Text)
                {
                    MessageBox.Show("It looks like you seleted a scene file that does not go with the stage file you selected already. Please pick the right one", "Wrong Scene File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                damnedRemoveStage.scenePath = scenePath;
                damnedRemoveStagesList.Add(new DamnedRemoveStage(damnedRemoveStage));
                buttonSelectSceneToRemove.Enabled = false;
                labelSelectSceneFileToRemove.Text = "Choose another scene file to remove with a stage:";
                labelMapToRemove.Text = "Choose another stage file to remove from the game.";
                labelMapToRemove.ForeColor = Color.White;
                buttonModifyStages.Enabled = true;
                changesMade = true;
                string stageToMark = Path.GetFileNameWithoutExtension(damnedRemoveStage.stagePath).Replace("_", " ");
                MarkStage(stageToMark, Color.Red);
            }

            else
            {
                string reason = String.Empty;

                if (!DamnedMaps.CheckInnerSceneFile(scenePath, ref reason))
                {
                    MessageBox.Show(String.Format("{0} Please select a different scene file.", reason), "Failed to check the scene file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }

                if (damnedNewStage.newScenePath == String.Empty)
                {
                    damnedNewStage.count++;
                }

                damnedNewStage.newScenePath = scenePath;
                labelScene.Text = sceneName;
                labelScene.ForeColor = Color.FromArgb(255, 168, 38);
                changesMade = true;
                buttonSelectLobbyButtonPicture.Enabled = true;
            }
        }

        private void ModifyStages()
        {
            Cursor.Current = Cursors.WaitCursor;
            string terrorImagesZipFile = damnedImages.terrorZipFile;
            string tempDirectory = Path.GetTempPath();
            int randomNumber = new Random().Next();
            string tempDirectoryName = String.Format("DamnedWorkshop_{0}", randomNumber);
            tempDirectory = Path.Combine(tempDirectory, tempDirectoryName);

            if (Directory.Exists(tempDirectory))
            {
                Directory.Delete(tempDirectory, true);
            }

            Directory.CreateDirectory(tempDirectory);
            ZipFile.ExtractToDirectory(terrorImagesZipFile, tempDirectory);
            string layoutFilePath = damnedImages.GetLayoutFileFromZip(tempDirectory);

            if (!File.Exists(layoutFilePath))
            {
                MessageBox.Show("Failed to extract the zip file into the users temporary directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cursor.Current = Cursors.Default;
                return;

            }

            damnedImages.UpdateXmlFiles(layoutFilePath, damnedRemoveStagesList.ToArray(), damnedNewStagesList.ToArray());

            string destination = Path.Combine(damnedImages.guiDirectory, "Terror.zip");
            File.Delete(destination);
            ZipFile.CreateFromDirectory(tempDirectory, destination);
            Directory.Delete(tempDirectory, true);
            Reset();
            Cursor.Current = Cursors.Default;
            MessageBox.Show("Successfully modified the stages in the game.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ButtonResetPendingChanges_Click(object sender, EventArgs e)
        {
            if (changesMade)
            {
                Reset();
            }
        }

        private void Reset()
        {
            damnedNewStagesList.Clear();
            damnedRemoveStagesList.Clear();
            damnedStagesTextBox.Clear();
            damnedNewStage.Clear();
            damnedRemoveStage.Clear();
            labelMapToRemove.Text = "Choose a stage to remove:";
            labelMapToRemove.ForeColor = Color.White;
            labelMapToAdd.Text = "Choose a new stage to add:";
            labelMapToAdd.ForeColor = Color.White;
            labelLoadingScreenImage.Text = "Choose a loading screen picture:";
            labelLoadingScreenImage.ForeColor = Color.White;
            labelLobbyButtonPicture.Text = "Choose a lobby button picture:";
            labelLobbyButtonPicture.ForeColor = Color.White;
            labelSelectedHighlightedButton.ForeColor = Color.White;
            labelSelectedHighlightedButton.Text = "Choose an enabled, highlighted, and disabled lobby button picture:";
            RefreshDamnedStagesList();
            buttonSelectLobbyButtonPicture.Enabled = false;
            buttonSelectMapLoadingScreen.Enabled = false;
            buttonAddStageToList.Enabled = false;
            buttonModifyStages.Enabled = false;
            buttonSelectHighlightedLobbyButtons.Enabled = false;
            buttonSelectSceneFile.Enabled = false;
            buttonPackageStage.Enabled = false;
            //checkBoxCustomObjects.Checked = false;
            checkBoxCustomObjects.Enabled = false;
            buttonSelectObjectsForStage.Enabled = false;
            pictureDamnedButtonLobbyPicture.Image = Properties.Resources.lobbyButtonImageExample;
            pictureLobbyButtonHighlightedExample.Image = Properties.Resources.example_lobbyButtonImage;
            labelScene.Text = "Choose a scene file that goes with your stage";
            labelScene.ForeColor = Color.White;
            labelSelectSceneFileToRemove.Text = "Choose a scene file to remove with the stage:";
            labelSelectSceneFileToRemove.ForeColor = Color.White;
            labelObjectsCount.Text = "Number of new objects will be shown here.";
            labelObjectsCount.ForeColor = Color.White;
            tempDirectory = String.Empty;

            if (packagesTempDirectoryList.Count > 0)
            {
                DeleteTempFolders();
            }

            changesMade = false;
        }

        private void ButtonModifyStages_Click(object sender, EventArgs e)
        {
            if (damnedNewStage.count > 0)
            {
                if (damnedNewStage.count != 5)
                {
                    MessageBox.Show("You did not select a loading screen image or a lobby button image for your new stages(s). Finish selecting those first before adding them into the game.", "Finish Selecting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            ModifyStages();
            DeleteTempFolders();
        }

        private void ButtonAddStageToList_Click(object sender, EventArgs e)
        {
            damnedNewStagesList.Add(new DamnedNewStage(damnedNewStage));
            RefreshDamnedStagesList();
            damnedNewStage.Clear();
            buttonSelectLobbyButtonPicture.Enabled = false;
            buttonSelectMapLoadingScreen.Enabled = false;
            buttonSelectHighlightedLobbyButtons.Enabled = false;
            buttonModifyStages.Enabled = true;
            buttonPackageStage.Enabled = true;
            buttonSelectObjectsForStage.Enabled = false;
            checkBoxCustomObjects.Enabled = false;
            checkBoxCustomObjects.Checked = false;
            buttonAddStageToList.Enabled = false;
            pictureDamnedButtonLobbyPicture.Image = Properties.Resources.lobbyButtonImageExample;
            pictureLobbyButtonHighlightedExample.Image = Properties.Resources.example_lobbyButtonImage;
            labelMapToAdd.Text = "Choose another stages to add:";
            labelMapToAdd.ForeColor = Color.White;
            labelLoadingScreenImage.Text = "Choose another loading screen picture:";
            labelLoadingScreenImage.ForeColor = Color.White;
            labelLobbyButtonPicture.Text = "Choose another lobby button picture:";
            labelLobbyButtonPicture.ForeColor = Color.White;
            labelSelectedHighlightedButton.Text = "Choose another enabled, highlighted, and disabled lobby button picture:";
            labelSelectedHighlightedButton.ForeColor = Color.White;
            labelScene.Text = "Choose another scene file that goes with your stages:";
            labelScene.ForeColor = Color.White;
            labelObjectsCount.Text = "Number of new objects will be shown here.";
            labelObjectsCount.ForeColor = Color.White;
        }

        private void ButtonSelectHighlightedLobbyButtons_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog();
            dialog.Filter = "PNG Files (*.png)|*.png";

            DialogResult result = dialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }


            Dimensions dimensions = DamnedImages.GetDimensions(dialog.FileName);

            if (dimensions.x != 900 || dimensions.y != 100)
            {
                string imageName = Path.GetFileName(dialog.FileName);
                MessageBox.Show(String.Format("The image \"{0}\" does not have the correct dimensions. Please select another image.", imageName), "Incorrect image dimensions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (damnedNewStage.lobbyImageButtonHighlightedPath == String.Empty)
            {
                damnedNewStage.count++;
            }

            damnedNewStage.lobbyImageButtonHighlightedPath = dialog.FileName;
            pictureLobbyButtonHighlightedExample.ImageLocation = dialog.FileName;
            labelSelectedHighlightedButton.Text = Path.GetFileName(dialog.FileName);
            labelSelectedHighlightedButton.ForeColor = Color.FromArgb(255, 168, 38);
            buttonSelectMapLoadingScreen.Enabled = true;
        }

        private void ButtonSelectSceneFile_Click(object sender, EventArgs e)
        {
            SelectScene(false);

        }

        private void ButtonSelectSceneToRemove_Click(object sender, EventArgs e)
        {
            SelectScene(true);
        }

        private void SetButtons()
        {
            buttonSelectHighlightedLobbyButtons.MouseEnter += OnMouseEnterButton;
            buttonSelectHighlightedLobbyButtons.MouseLeave += OnMouseLeaveButton;
            buttonSelectLobbyButtonPicture.MouseEnter += OnMouseEnterButton;
            buttonSelectLobbyButtonPicture.MouseLeave += OnMouseLeaveButton;
            buttonSelectMapLoadingScreen.MouseEnter += OnMouseEnterButton;
            buttonSelectMapLoadingScreen.MouseLeave += OnMouseLeaveButton;
            buttonSelectSceneFile.MouseEnter += OnMouseEnterButton;
            buttonSelectSceneFile.MouseLeave += OnMouseLeaveButton;
            buttonSelectSceneToRemove.MouseEnter += OnMouseEnterButton;
            buttonSelectSceneToRemove.MouseLeave += OnMouseLeaveButton;
            buttonModifyStages.MouseEnter += OnMouseEnterButton;
            buttonModifyStages.MouseLeave += OnMouseLeaveButton;
            buttonAddMapIntoDamned.MouseEnter += OnMouseEnterButton;
            buttonAddMapIntoDamned.MouseLeave += OnMouseLeaveButton;
            buttonAddStageToList.MouseEnter += OnMouseEnterButton;
            buttonAddStageToList.MouseLeave += OnMouseLeaveButton;
            buttonRemoveMap.MouseEnter += OnMouseEnterButton;
            buttonRemoveMap.MouseLeave += OnMouseLeaveButton;
            buttonResetPendingChanges.MouseEnter += OnMouseEnterButton;
            buttonResetPendingChanges.MouseLeave += OnMouseLeaveButton;
            buttonSelectPackage.MouseEnter += OnMouseEnterButton;
            buttonSelectPackage.MouseLeave += OnMouseLeaveButton;
            buttonPackageStage.MouseEnter += OnMouseEnterButton;
            buttonPackageStage.MouseLeave += OnMouseLeaveButton;
            buttonSelectObjectsForStage.MouseEnter += OnMouseEnterButton;
            buttonSelectObjectsForStage.MouseLeave += OnMouseLeaveButton;
        }

        private void OnMouseEnterButton(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.ForeColor = Color.FromArgb(255, 168, 38);
        }

        private void OnMouseLeaveButton(object sender, EventArgs e)
        {
            var button = (Button)sender;
            button.ForeColor = Color.White;
        }

        private void DamnedMappingForm_Load(object sender, EventArgs e)
        {
            SetButtons();
        }

        private void ButtonSelectPackage_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog()
            {
                Filter = "Zip File (*.zip)|*.zip"
            };


            DialogResult result = dialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            Reset();

            string zipArchivePath = dialog.FileName;

            DamnedPackage package = new DamnedPackage();

            if (!package.Check(zipArchivePath))
            {
                Directory.Delete(package.tempDirectory, true);
                MessageBox.Show(package.reasonForFailedCheck, "Failed Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            package.Load(this);

            if (damnedMaps.StageExists(Path.GetFileName(damnedNewStage.newStagePath)))
            {
                string stageName = Path.GetFileNameWithoutExtension(damnedNewStage.newStagePath).Replace("_", " ");
                Directory.Delete(package.tempDirectory, true);
                Reset();
                MessageBox.Show(String.Format("This stage \"{0}\" is already installed in the game. Please select another stage", stageName), "Stage already installed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (package.objectsCount > 0)
            {
                labelObjectsCount.Text = String.Format("{0} new objects will be added.", package.objectsCount);
                labelObjectsCount.ForeColor = Color.FromArgb(255, 168, 38);
                checkBoxCustomObjects.Checked = true;
                checkBoxCustomObjects.Enabled = true;
                buttonSelectObjectsForStage.Enabled = true;
            }

            labelLoadingScreenImage.Text = Path.GetFileName(damnedNewStage.loadingImagePath);
            labelLoadingScreenImage.ForeColor = Color.FromArgb(255, 168, 38);
            labelLobbyButtonPicture.Text = Path.GetFileName(damnedNewStage.lobbyImageButtonPath);
            labelLobbyButtonPicture.ForeColor = Color.FromArgb(255, 168, 38);
            labelSelectedHighlightedButton.Text = Path.GetFileName(damnedNewStage.lobbyImageButtonHighlightedPath);
            labelSelectedHighlightedButton.ForeColor = Color.FromArgb(255, 168, 38);
            labelScene.Text = Path.GetFileName(damnedNewStage.newScenePath);
            labelScene.ForeColor = Color.FromArgb(255, 168, 38);
            labelMapToAdd.Text = Path.GetFileNameWithoutExtension(damnedNewStage.newStagePath).Replace("_", " ");
            labelMapToAdd.ForeColor = Color.FromArgb(255, 168, 38);
            pictureDamnedButtonLobbyPicture.ImageLocation = damnedNewStage.lobbyImageButtonPath;
            pictureLobbyButtonHighlightedExample.ImageLocation = damnedNewStage.lobbyImageButtonHighlightedPath;

            damnedNewStage.count = 5;
            changesMade = true;
            buttonSelectHighlightedLobbyButtons.Enabled = true;
            buttonSelectLobbyButtonPicture.Enabled = true;
            buttonSelectMapLoadingScreen.Enabled = true;
            buttonSelectSceneFile.Enabled = true;
            buttonAddStageToList.Enabled = true;
            packagesTempDirectoryList.Add(package.tempDirectory);
        }

        private void ButtonPackageStage_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog()
            {
                Description = "Select a folder where you want to save your new Damned package(s)."
            };

            if (browser.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            string folderPath = browser.SelectedPath;
            DamnedPackage package = new DamnedPackage();
            package.Package(damnedNewStagesList.ToArray(), folderPath);

        }

        private void CheckBoxCustomObjects_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCustomObjects.Checked)
            {
                buttonAddStageToList.Enabled = false;
                buttonSelectObjectsForStage.Enabled = true;
            }

            else if (!checkBoxCustomObjects.Checked)
            {
                buttonAddStageToList.Enabled = true;
                damnedNewStage.newObjectsPath.Clear();
                labelObjectsCount.Text = "Number of new objects will be shown here.";
                labelObjectsCount.ForeColor = Color.White;
                buttonSelectObjectsForStage.Enabled = false;
            }
        }

        private void ButtonSelectObjectsForStage_Click(object sender, EventArgs e)
        {
            FileDialog dialog = new OpenFileDialog()
            {
                Filter = "Object Files(*.object)|*.object",
                Multiselect = true

            };


            DialogResult result = dialog.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            string[] selectedObjects = dialog.FileNames;

            if (selectedObjects.Length <= 0)
            {
                return;
            }

            labelObjectsCount.Text = String.Format("{0} new objects will be added.", selectedObjects.Length);
            labelObjectsCount.ForeColor = Color.FromArgb(255, 168, 38);

            foreach (string i in selectedObjects)
            {
                damnedNewStage.newObjectsPath.Add(i);
            }

            damnedNewStage.hasObjects = true;
            buttonAddStageToList.Enabled = true;
        }

        private void DamnedMappingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (changesMade)
            {
                DialogResult result = MessageBox.Show("You have unsaved changes. Do you wish to close this window?", "Unsaved changes", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result != DialogResult.Yes)
                {
                    return;
                }

                if (packagesTempDirectoryList.Count > 0)
                {
                    DeleteTempFolders();
                }
            }

            mainForm.Enabled = true;
            mainForm.Show();
        }

        private void DeleteTempFolders()
        {
            for (int i = 0; i < packagesTempDirectoryList.Count; i++)
            {
                if (Directory.Exists(packagesTempDirectoryList[i]))
                {
                    Directory.Delete(packagesTempDirectoryList[i], true);
                }
            }

        }
    }
}
               

