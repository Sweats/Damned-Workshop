using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Runtime.InteropServices;

namespace DamnedWorkshop
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern bool FlashWindow(IntPtr hwnd, bool bInvert);

        private static int DOWNLOAD_TEST_PATCH_STABLE = 0;
        private static int DOWNLOAD_TEST_PATCH_TESTING = 1;
        private static int DOWNLOAD_ORIGINAL_PATCH = 2;


        private static string DOWNLOAD_TEST_PATCH_STABLE_LINK =  "https://github.com/Sweats/Damned/archive/master.zip";
        private static string DOWNLOAD_TEST_PATCH_TESTING_LINK = "https://github.com/Sweats/Damned/archive/testing.zip";
        private static string GITHUB_LINK = "TO BE DETERMINED";
        private static string DOWNLOAD_ORIGINAL_PATCH_LINK = "";

        private static string TOOLTIP_ORIGINAL_PATCH_TEXT = "Downloads and installs the latest public test patch from the testing banch from " + DOWNLOAD_ORIGINAL_PATCH_LINK + " \n\nFiles will be downloaded into a temporary directory then extracted to where you set the directory to. After that, the temporary directory will be removed.";
        private static string TOOLTIP_TEST_PATCH_STABLE_TEXT = "Downloads and installs the latest public test patch from the stable banch from " + DOWNLOAD_TEST_PATCH_STABLE_LINK + " \n\nFiles will be downloaded into a temporary directory then extracted to where you set the directory to. After that, the temporary directory will be removed.";
        private static string TOOLTIP_TEST_PATCH_TESTING_TEXT = "Downloads and installs the latest public test patch from the testing banch from " + DOWNLOAD_TEST_PATCH_TESTING_LINK + ". \n\nFiles will be downloaded into a temporary directory then extracted to where you set the directory to. After that, the temporary directory will be removed.";
        private static string TOOLTIP_SET_DAMNED_FOLDER_TEXT = "Opens up the file explorer where you can select a location where Damned is installed.";
        private static string TOOLTIP_CHECK_BUTTON_TEXT = "Checks the listed directory to see if the location that you picked is a valid Damend directory.\n\nIf the result is red, it means it failed. If the result is green, it mean it was successful";

        private string directory = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Damned";
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Figure out how to do settings so the user does not have to re do everything every time.
            this.damnedDirectoryStringLabel.Text = directory;
            
            enablePatchButtionControls();
            toolTipPublicTestPatchTesting.SetToolTip(publicTestPatchTestingButton, TOOLTIP_TEST_PATCH_TESTING_TEXT);
            toolTipLatestOfficialPatch.SetToolTip(defaultPatchButton, TOOLTIP_ORIGINAL_PATCH_TEXT);
            toolTipPublicTestPatchStable.SetToolTip(publicTestPatchStableButton, TOOLTIP_TEST_PATCH_STABLE_TEXT);
            toolTipSetDamnedFolder.SetToolTip(setDamnedFolderButton, TOOLTIP_SET_DAMNED_FOLDER_TEXT);
            toolTipCheckButton.SetToolTip(checkPathButton, TOOLTIP_CHECK_BUTTON_TEXT);
            loggingTextBox.AppendText(String.Format("Welcome\n\nBefore using this tool, please check its github at {0}\n\nDamned directory has been set to \"{1}\". If you have installed Damned in a non traditonal location, you will have to change it. For more information on what the buttons do, hover your mouse over them.\n\n", GITHUB_LINK, directory));
        }

        private void PublicTestPatchStableButton_Click(object sender, EventArgs e)
        {
            InstallPatch(DOWNLOAD_TEST_PATCH_STABLE);

        }

        private void PublicTestPatchTestingButtion_Click(object sender, EventArgs e)
        {
            InstallPatch(DOWNLOAD_TEST_PATCH_TESTING);

        }

        private void DefaultPatchButton_Click(object sender, EventArgs e)
        {
            InstallPatch(DOWNLOAD_ORIGINAL_PATCH);

        }

        private void InstallPatch(int patch)
        {
            string link = "";
            string tmpDirectory = Path.Combine(directory, "tmp");

            if (Directory.Exists(tmpDirectory))
            {
                DeleteTmpFiles(tmpDirectory);

            }

            Directory.CreateDirectory(tmpDirectory);
            Directory.SetCurrentDirectory(tmpDirectory);

            string name = "Damned";

            // DON"T FORGET TO MOVE THIS AFTER YOU ARE DONE TESTING.
            //CleanUpNewerPatchFiles();

            using (var client = new WebClient())
            {
                string zipName = "";

                try
                {
                    if (patch == DOWNLOAD_ORIGINAL_PATCH)
                    {
                        zipName = "Damned";
                        link = "TODO: Add in the stable link in here";
                        loggingTextBox.AppendText(String.Format("Downloading the Damned public test patch from {0}. Please wait...\n\n", link));
                        CleanUpNewerPatchFiles();
                        Directory.SetCurrentDirectory(tmpDirectory);
                        client.DownloadFile(link, zipName);
                    }

                    else if (patch == DOWNLOAD_TEST_PATCH_STABLE)
                    {
                        zipName = "Damned_Public_Test_Patch_Stable.zip";
                        link = DOWNLOAD_TEST_PATCH_STABLE_LINK;
                        loggingTextBox.AppendText(String.Format("Downloading the Damned public test patch from {0}. Please wait...\n\n", link));
                        client.DownloadFile(link, zipName);
                        name = "Damned-master";
                    }

                    else if (patch == DOWNLOAD_TEST_PATCH_TESTING)
                    {
                        zipName = "Damned_Public_Test_Patch_Testing.zip";
                        link = DOWNLOAD_TEST_PATCH_TESTING_LINK;
                        loggingTextBox.AppendText(String.Format("Downloading the Damned public test patch from {0}. Please wait...\n\n", link));
                        client.DownloadFile(link, zipName);
                        name = "Damned-testing";
                    }

                    loggingTextBox.AppendText("Done downloading the patch. Please wait for it to install...\n\n");

                }

                catch (WebException e)
                {
                    string errorMessage = String.Format("Faled to download the patch. Try downloading from this link manually:\n\n{0}\n\nError Code:\n\n{1}", link, e.ToString());
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loggingTextBox.AppendText(errorMessage);
                    FlashWindow(this.Handle, false);

                }

                ExtractModifiedDamnedFoldersToGameFolder(new DirectoryInfo(tmpDirectory), new DirectoryInfo(directory), zipName);
            }

            DeleteTmpFiles(tmpDirectory);
        }

        private void DeleteTmpFiles(string tmpDirectory)
        {
            DirectoryInfo[] directories = new DirectoryInfo(tmpDirectory).GetDirectories("*", SearchOption.AllDirectories);

            for (int k = 0; k < directories.Length; k++)
            {
                FileInfo[] info = new DirectoryInfo(tmpDirectory).GetFiles("*", SearchOption.AllDirectories);

                for (int i = 0; i < info.Length; i++)
                {
                    FileInfo file = info[i];
                    loggingTextBox.AppendText("Deleting " + file.Name + "\n\n");
                    file.Delete();
                }
            }

            Directory.Delete(tmpDirectory, true);

            loggingTextBox.AppendText("Deleted tmp directory in your Damned folder. Was it from a previous failed installation?\n\n");
        }

        private void ExtractModifiedDamnedFoldersToGameFolder(DirectoryInfo tmpDirectory, DirectoryInfo gameDirectory, string zipName)
        {
            try
            { 
                loggingTextBox.AppendText(String.Format("Extracting {0}...\n\n", zipName));
                ZipFile.ExtractToDirectory(zipName, tmpDirectory.FullName);
                loggingTextBox.AppendText("Done\n\n");
            }

            catch (IOException)
            {
                loggingTextBox.AppendText("Failed to install the patch from the zip archive. Is the game running?\n\n");
                return;
            }
        }

        // Used when you go from the public test patch to the latest patch from 9heads which does not have the maps in the game. This is important because if the maps are not cleaned up then
        // the ID's will get messed up and it will be a lot harder to pick a map that you actually want.
        private void CleanUpNewerPatchFiles()
        {
            loggingTextBox.AppendText("Deleting the newer maps and scenes from the public test patch...\n\n");

            string[] newMapsToDelete = new string[] { "Pog_Champ_Hotel", "Factory_WIP", "Hund_Hills_Community_Center" };
            string[] filters = new string[] { "*.stage", "*.scene" };
            string newTempPath = Path.Combine(directory, "DamnedData\\Resources\\Stages");

            for (int k = 0; k < filters.Length; k++)
            {
                string currentFilter = filters[k];
                FileInfo[] filesToDelete = new DirectoryInfo(newTempPath).GetFiles(currentFilter, SearchOption.TopDirectoryOnly);

                for (int i = 0; i < newMapsToDelete.Length; i++)
                {
                    for (int j = 0; j < filesToDelete.Length; j++)
                    {
                        string file = newMapsToDelete[i];
                        string fileToDelete = filesToDelete[j].Name;

                        if (fileToDelete.Contains(file))
                        {
                            filesToDelete[j].Delete();
                            loggingTextBox.AppendText(String.Format("Deleted \"{0}{1}\"...", newMapsToDelete[i], filters[k]));
                            break;

                        }

                    }
                }
            }
        }


        private string GetFilePathOfADamnedFolder(string folderName)
        {

            DirectoryInfo[] possiblePaths = new DirectoryInfo(directory).GetDirectories("*", SearchOption.AllDirectories);
            string result = directory;

            for (int i = 0; i < possiblePaths.Length; i++)
            {
                string directoryFullPathName = possiblePaths[i].FullName;

                if (directoryFullPathName.EndsWith(folderName))
                {
                    result = directoryFullPathName;
                    break;
                }
            }

            return result;
        }

        private string[] GetDamnedStages()
        {
            string mapDirectory = Path.Combine(directory, GetFilePathOfADamnedFolder("Stages"));
            string[] filters = new string[] { "*.stage", "*.scene" };
            List<string> resultList = new List<string>();
            
            for (int i = 0; i < filters.Length; i++)
            {
                FileInfo[] files = new DirectoryInfo(mapDirectory).GetFiles(filters[i], SearchOption.TopDirectoryOnly);

                for (int k = 0; k < files.Length; k++)
                {
                    resultList.Add(files[i].FullName);
                }
            }

            return resultList.ToArray();
        }

        private string[] GetSounds()
        {
            string soundDirectory = Path.Combine(directory, GetFilePathOfADamnedFolder("Sounds"));
            List<string> resultList = new List<string>();
            FileInfo[] sounds = new DirectoryInfo(soundDirectory).GetFiles(".ogg", SearchOption.TopDirectoryOnly);

            for (int i = 0; i < sounds.Length; i++)
            {
                resultList.Add(sounds[i].FullName);
            }

            return resultList.ToArray();
        }


        private string[] GetObjects()
        {
            string objectDirectory = Path.Combine(directory, GetFilePathOfADamnedFolder("Objects"));
            List<string> resultList = new List<string>();
            FileInfo[] objects = new DirectoryInfo(objectDirectory).GetFiles(".obj", SearchOption.TopDirectoryOnly);

            for (int i = 0; i < objects.Length; i++)
            {
                resultList.Add(objects[i].FullName);
            }

            return resultList.ToArray();
        }

        private void SetDamnedFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            if (browser.ShowDialog() == DialogResult.OK)
            {
                directory = browser.SelectedPath;
            }


            string text = String.Format("Selected \"{0}\" as the folder to install the patches\n\n", directory);
            damnedDirectoryStringLabel.ForeColor = Color.Black;
            loggingTextBox.AppendText(text);
            damnedDirectoryStringLabel.Text = directory;
        }


        private void enablePatchButtionControls()
        {
            defaultPatchButton.Enabled = true;
            publicTestPatchStableButton.Enabled = true;
            publicTestPatchTestingButton.Enabled = true;

        }

        private void disablePatchButtonControls()
        {
            defaultPatchButton.Enabled = false;
            publicTestPatchTestingButton.Enabled = false;
            publicTestPatchStableButton.Enabled = false;
        }

        private void ButtonCheckPath_Click(object sender, EventArgs e)
        {
            if (CheckIfValidDamnedRootDirectory())
            {
                enablePatchButtionControls();
                damnedDirectoryStringLabel.Text = directory;
                damnedDirectoryStringLabel.ForeColor = Color.Green;
                loggingTextBox.AppendText("Successfully checked your directory. This seems to be the correct Damned folder.\n\n");
            }

            else
            {
                disablePatchButtonControls();
                damnedDirectoryStringLabel.Text = directory;
                damnedDirectoryStringLabel.ForeColor = Color.Red;
                loggingTextBox.AppendText(String.Format("Directory \"{0}\" is not a vaild directory. Either you picked the wrong directory or you have missing game files.\n\n", directory));
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DamnedFiles damnedFiles = new DamnedFiles(directory);
            
            if (damnedFiles.Check())
            {
                MessageBox.Show("Yeet");
            }

        }
    }
}
