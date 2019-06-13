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

        private string directory = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Damned";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Figure out how to do settings so the user does not have to re do everything every time.
            this.damnedDirectoryStringLabel.Text = directory;
            disablePatchButtonControls();
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

        private void PublicTestPatchStableButton_MouseHover(object sender, EventArgs e)
        {
            string text = String.Format("Downloads and installs the latest public test patch from the stable branch from {0}\n\nFiles will be downloaded into a temporary directory then extracted to where you set the directory to. After that, the temporary directory will be removed.", DOWNLOAD_TEST_PATCH_STABLE_LINK);
            toolTipPublicTestPatchTesting.Show(text, publicTestPatchStableButton);
        }

        private void PublicTestPatchTestingButton_MouseHover(object sender, EventArgs e)
        {
            string text = String.Format("Downloads and installs the latest public test patch from the testing banch from {0}\n\nFiles will be downloaded into a temporary directory then extracted to where you set the directory to. After that, the temporary directory will be removed.", DOWNLOAD_TEST_PATCH_TESTING_LINK);
            toolTipPublicTestPatchTesting.Show(text, publicTestPatchTestingButton);
        }


        private void InstallPatch(int patch)
        {
            string link = "";

            try
            { 
                Directory.SetCurrentDirectory(directory);

            }

            catch (DirectoryNotFoundException)
            {
                loggingTextBox.AppendText("The location that you have selected does not seem to exist. Please pick another.\n\n");
                FlashWindow(this.Handle, false);
                return;
            }

            Directory.CreateDirectory("tmp");
            Directory.SetCurrentDirectory("tmp");
            string name = "Damned";

            using (var client = new WebClient())
            {
                try
                {
                    string zipName = "";

                    if (patch == DOWNLOAD_ORIGINAL_PATCH)
                    {
                        zipName = "Damned";
                        link = "TODO: Add in the stable link in here";
                        loggingTextBox.AppendText(String.Format("Downloading the Damned public test patch from {0}. Please wait...\n\n", link));
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

                    try
                    {
                        loggingTextBox.AppendText(String.Format("Extracting {0}...\n\n", zipName));
                        ZipFile.ExtractToDirectory(zipName, ".");
                        loggingTextBox.AppendText("Done\n\n");
                       

                    }

                    catch(IOException)
                    {
                        loggingTextBox.AppendText("Failed to install the patch from the zip archive. Is the game running?\n\n");
                    }
                    
                }

                catch (WebException e)
                {
                    string errorMessage = String.Format("Faled to download the patch. Try downloading from this link manually:\n\n{0}\n\nError Code:\n\n{1}", link, e.ToString());
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loggingTextBox.AppendText(errorMessage);
                    FlashWindow(this.Handle, false);

                }
                
            }
        }

        private void CleanUpTmpFiles()
        {
            loggingTextBox.AppendText("Cleaning up files left over from the public test patch...\n\n");

            string [] newMapsToDelete = new string[] { "Pog_Champ_Hotel", "Factory_WIP", "Hund_Hills_Community_Center" };
            string newTempPath = Path.Combine(directory, "DamnedData\\Resources\\Stages");
            Directory.SetCurrentDirectory(newTempPath);
            FileInfo[] filesToDelete = new DirectoryInfo(newTempPath).GetFiles();

            for (int i = 0; i < newMapsToDelete.Length; i++)
            {
                for (int j = 0; j < filesToDelete.Length; j++)
                {
                    string folder = newMapsToDelete[i];
                    string folderToDelete = filesToDelete[j].Name;

                    if (folder == folderToDelete)
                    {
                        filesToDelete[j].Delete();
                        loggingTextBox.AppendText(String.Format("Deleted \"{0}\"...", newMapsToDelete[i]));
                        break;

                    }

                }
            }
        }

        private bool CheckIfValidDamnedRootDirectory()
        {
            string rootPath = directory;
            string mapsDirectory = "DamnedData\\Resources\\Stages";
            string soundsDirectory = "DamnedData\\Resources\\Sounds";
            string objectsDirectory = "DamnedData\\Resources\\Objects";
            string editorImagesDirectory = "DamnedData\\GUI\\EditorImages";
            string terrorimagesDirectory = "Damned\\GUI\\TerrorImages";

            // Easiest way I can think of doing this at the moment. Too lazy to bother with a more efficient method.

            string[] pathsToCheck = new string[] {Path.Combine(rootPath, mapsDirectory), Path.Combine(rootPath, soundsDirectory), Path.Combine(rootPath, objectsDirectory),
                                                    Path.Combine(rootPath, editorImagesDirectory), Path.Combine(rootPath, terrorimagesDirectory) };


            loggingTextBox.AppendText("Scanning directories to see if this is the folder where Damned is installed...\n\n");

            for (int i = 0; i < pathsToCheck.Length; i++)
            {
                loggingTextBox.AppendText(String.Format("Checking to see if {0} exists...\n\n", pathsToCheck[i]));

                if (!Directory.Exists(pathsToCheck[i]))
                {
                    loggingTextBox.AppendText("\nFAILED. Did you select the right folder?\n\n");
                    return false;
                }

                else
                {
                    loggingTextBox.AppendText("GOOD. Continuing...\n\n");
                }
            }

            return true;
        }

        private void ToolTip1_Popup(object sender, PopupEventArgs e)
        {

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
    }
}
