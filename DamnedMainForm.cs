using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            labelDamnedDirectoryPath.ForeColor = Color.Black;
            DisableControls();
            Properties.Settings.Default.damnedGamePath = directory;
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
            damnedFiles = new DamnedFiles(directory);

            if (damnedFiles.Check())
            {
                labelDamnedDirectoryPath.ForeColor = Color.FromArgb(255, 168, 38);
                EnableControls();
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

            if (setting != String.Empty)
            {
                labelDamnedDirectoryPath.Text = setting;
                directory = setting;
                damnedFiles = new DamnedFiles(directory);

                if (damnedFiles.Check())
                {
                    labelDamnedDirectoryPath.ForeColor = Color.FromArgb(255, 168, 38);
                    EnableControls();
                }
            }
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
            var button =  (Button)sender;
            button.ForeColor = Color.White;
        }

        private void DamnedMainForm_Load(object sender, EventArgs e)
        {
            SetButtons();

        }
    }
}
