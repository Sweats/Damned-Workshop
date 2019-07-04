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

namespace DamnedWorkshop
{
    public partial class DamnedMainForm : Form
    {

        private DamnedFiles damnedFiles;
        private string directory = @"C:\Program Files (x86)\Steam\steamapps\common\Damned";

        public DamnedMainForm()
        {
            InitializeComponent();
            labelDamnedDirectoryPath.Text = directory;
            LoadSettings();
        }

        private void ButtonPatcherForm_Click(object sender, EventArgs e)
        {
            DamnedPatcherForm form = new DamnedPatcherForm(damnedFiles);
            form.Show();
        }

        private void ButtonMappingForm_Click(object sender, EventArgs e)
        {
            DamnedMappingForm form = new DamnedMappingForm(damnedFiles.damnedMaps, damnedFiles.damnedImages);
            form.Show();

        }

        private void ButtonSelectDamnedDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                directory = dialog.SelectedPath;
            }

            else
            {
                return;
            }

            labelDamnedDirectoryPath.Text = directory;
            labelDamnedDirectoryPath.ForeColor = Color.White;
            DisableControls();
        }



        private void EnableControls()
        {
            buttonMappingForm.Enabled = true;
            buttonPatcherForm.Enabled = true;
        }

        private void DisableControls()
        {
            buttonMappingForm.Enabled = false;
            buttonPatcherForm.Enabled = false;
        }

        private void ButtonCheckPath_Click(object sender, EventArgs e)
        {
            if (directory == String.Empty)
            {
                MessageBox.Show("You did not select a directory", "No directory selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                damnedFiles = new DamnedFiles(directory);

            }

            catch (IOException)
            {
                MessageBox.Show("This directory does not exist. Either the default location for Damned does not exist on your system, or the directory that you selected was moved or deleted by something else. Please select a new directory where Damned is installed.", "Directory Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                labelDamnedDirectoryPath.Text = "Your Damned directory path will appear here.";
                directory = String.Empty;
                return;
            }

            if (damnedFiles.Check())
            {
                labelDamnedDirectoryPath.ForeColor = Color.FromArgb(255, 168, 38);
                EnableControls();
                Properties.Settings.Default.damnedGamePath = directory;
                Properties.Settings.Default.Save();
            }

            else
            {
                labelDamnedDirectoryPath.ForeColor = Color.Red;
                DisableControls();
            }
        }

        private void LoadSettings()
        {
            string setting = Properties.Settings.Default.damnedGamePath;
            labelDamnedDirectoryPath.Text = directory;

            if (setting != String.Empty)
            {
                labelDamnedDirectoryPath.Text = setting;
                directory = setting;

                try
                {
                    damnedFiles = new DamnedFiles(directory);

                }

                catch (IOException)
                {
                    ResetSettings();
                    string message = String.Format("The directory \"{0}\" seems to no longer exist. Your settings have been reset.", setting);
                    MessageBox.Show(message, "Directory No Longer Exists", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    labelDamnedDirectoryPath.Text = "Your Damned directory path will appear here.";
                    directory = String.Empty;
                    return;
                }

                if (damnedFiles.Check())
                {
                    labelDamnedDirectoryPath.ForeColor = Color.FromArgb(255, 168, 38);
                    EnableControls();
                }
            }
        }

        private void ResetSettings()
        {
            Properties.Settings.Default.damnedGamePath = String.Empty;
            Properties.Settings.Default.damnedBackupFolderPath = String.Empty;
            Properties.Settings.Default.damnedPublicTestPatchStablePath = String.Empty;
            Properties.Settings.Default.damnedPublicTestPatchTestingPath = String.Empty;
            Properties.Settings.Default.Save();
        }

        private void SetButtons()
        {
            buttonCheckPath.MouseEnter += OnMouseEnterButton;
            buttonCheckPath.MouseLeave += OnMouseLeaveButton;
            buttonMappingForm.MouseEnter += OnMouseEnterButton;
            buttonMappingForm.MouseLeave += OnMouseLeaveButton;
            buttonPatcherForm.MouseEnter += OnMouseEnterButton;
            buttonPatcherForm.MouseLeave += OnMouseLeaveButton;
            buttonSelectDamnedDirectory.MouseEnter += OnMouseEnterButton;
            buttonSelectDamnedDirectory.MouseLeave += OnMouseLeaveButton;

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

        private void DamnedMainForm_Load(object sender, EventArgs e)
        {
            SetButtons();

        }
    }
 }
