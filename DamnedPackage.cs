using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System;
using System.Drawing;
using System.Windows.Forms;

public class DamnedPackage
{

    public string tempDirectory { get; private set; }
    private string zipArchivePath;


    public string reasonForFailedCheck { get; private set; }

    public DamnedPackage()
    {

    }

    private struct Cords
    {
        public int x;
        public int y;
    }


    public bool Check(string zipArchivePath)
    {
        this.zipArchivePath = zipArchivePath;

        if (Path.GetExtension(zipArchivePath) != ".zip")
        {
            string archiveName = Path.GetFileName(zipArchivePath);
            reasonForFailedCheck = String.Format("Check failed because \"{0}\" is not a .zip file. Please repackage your stage into a .zip file", archiveName);
            return false;
        }

        CreateTempDirectory();

        if (!CheckDirectories())
        {
            return false;
        }

        if (!CheckFiles())
        {
            return false;
        }

        return true;
    }


    private bool CheckFiles()
    {
        FileInfo[] files = new DirectoryInfo(tempDirectory).GetFiles("*", SearchOption.AllDirectories);
        bool success = true;

        for (int i = 0; i < files.Length; i++)
        {
            string fileName = files[i].Name;
            string filePath = files[i].FullName;
            string fileExtension = Path.GetExtension(fileName);

            if (fileExtension == ".jpg" || fileExtension == ".png")
            {
                if (!CheckImage(filePath))
                {
                    success = false;
                    break;
                }
            }

            else if (fileExtension == ".stage" || fileExtension == ".scene")
            {
                if (!CheckStageOrScene(filePath))
                {
                    success = false;
                    break;
                }
            }
        }

        return success;
    }

    private bool CheckDirectories()
    {
        DirectoryInfo[] info = new DirectoryInfo(tempDirectory).GetDirectories("*", SearchOption.AllDirectories);

        string[] directoriesToCheck = new string[] { "DamnedData", "GUI", "Resources", "TerrorImages", "Stages" };
        bool success = true;
        string currentDirectoryToCheckFor;

        for (int i = 1; i < info.Length; i++)
        {
            bool found = false;
            string directory = info[i].Name;

            for (int j = 0; j < directoriesToCheck.Length; j++)
            {
                if (directory == directoriesToCheck[j])
                {
                    found = true;
                    currentDirectoryToCheckFor = directoriesToCheck[j];
                    break;
                }
            }

            if (!found)
            {
                success = false;
                string directoryName = info[i].Name;
                reasonForFailedCheck = String.Format("Check failed because the required directory \"{0}\" was not found in your zip archive", directoriesToCheck);
                break;
            }
        }

        return success;
    }


    // TODO: Check the stage or scene file itself and see if the name inside the file matches the filename!
    private bool CheckStageOrScene(string stagePath)
    {
        string directoryPath = Path.GetDirectoryName(stagePath);
        string directoryName = Path.GetFileName(directoryPath);

        if (directoryName != "Stages")
        {
            string stageName = Path.GetFileName(stagePath);
            reasonForFailedCheck = String.Format("Check failed because \"{0}\" does not reside in the Stages directory", stageName);
            return false;
        }

        FileInfo[] stages = new DirectoryInfo(directoryPath).GetFiles("*", SearchOption.TopDirectoryOnly);

        if (stages.Length > 2)
        {
            reasonForFailedCheck = "Check failed because the Stages directory has more than 2 files in it. Only 1 scene and 1 file is allowed";
            return false;
        }

        bool success = true;

        for (int i = 0; i < stages.Length; i++)
        {
            string stageName = stages[i].Name;

            if (!FindCorrespondingFile(stages, stageName))
            {
                success = false;
                break;
            }
        }

        return success;
    }


    private bool FindCorrespondingFile(FileInfo[] stages,  string stageOrScene)
    {
        string extension = Path.GetExtension(stageOrScene);
        bool success = false;

        for (int i = 0; i < stages.Length; i++)
        {
            string otherExtension = Path.GetExtension(stages[i].Name);

            if (otherExtension != extension)
            {
                string name = Path.GetFileNameWithoutExtension(stageOrScene);
                string otherName = Path.GetFileNameWithoutExtension(stages[i].Name);

                if (name == otherName)
                {
                    success = true;
                    break;
                }
            }
        }

        if (!success)
        {
            string otherExtension;

            if (extension == ".stage")
            {
                otherExtension = ".scene";

            }

            else
            {
                otherExtension = ".stage";
            }

            string stageOrSceneName = Path.GetFileName(stageOrScene);
            reasonForFailedCheck = String.Format("Check failed because \"{0}\" does not have its corresponding \"{1}{2}\" file in the same directory.", stageOrSceneName, stageOrScene, otherExtension);
            return false;
        }

        return success;

    }

    private bool CheckImage(string imagePath)
    {
        string directoryPath = Path.GetDirectoryName(imagePath);
        string directoryName = Path.GetFileName(directoryPath);

        if (directoryName != "GUI" && directoryName != "TerrorImages")
        {
            string imageName = Path.GetFileName(imagePath);
            reasonForFailedCheck = String.Format("Check failed because \"{0}\" does not reside in either the GUI directory or the TerrorImages directory.", imageName);
            return false;
        }

        string fileExtension = Path.GetExtension(imagePath);

        if (fileExtension == ".png")
        {
            Cords cords = GetDimensions(imagePath);

            if (cords.x != 300 && cords.y != 100 || cords.x != 900 && cords.y != 100)
            {
                string imageName = Path.GetFileName(imagePath);
                reasonForFailedCheck = String.Format("Check failed because the dimensions for the image \"{0}\" is not 300 X 100 or 900 X 100", imageName);
                return false;
            }
        }

        else if (fileExtension == ".jpg")
        {
            Cords cords = GetDimensions(imagePath);

            if (cords.x != 1920 && cords.y != 1080)
            {
                string imageName = Path.GetFileName(imagePath);
                reasonForFailedCheck = String.Format("Check failed because the dimensions for the image \"{0}\" is not 1920 X 1080", imageName);
                return false;
            }
        }

        return true;
    }


    // Loads the variables from a zip file  into the DamnedMappingForm assuming that it is packaged correctly.
    // Need to figure out how to pass in the winform controls in here.
    public void Load(DamnedWorkshop.DamnedMappingForm form)
    {
        FileInfo[] info = new DirectoryInfo(tempDirectory).GetFiles("*", SearchOption.AllDirectories);

        for (int i = 0; i < info.Length; i++ )
        {
            string fileNamePath = info[i].FullName;
            string fileExtension = Path.GetExtension(fileNamePath);
            
            if (fileExtension == ".png")
            {
                Cords cords = GetDimensions(fileNamePath);

                if (cords.x == 300 && cords.y == 100)
                {
                    form.damnedNewStage.lobbyImageButtonPath = fileNamePath;
                }

                else if (cords.x == 900 && cords.y == 100)
                {

                    form.damnedNewStage.lobbyImageButtonHighlightedPath = fileNamePath;
                }
            }

            else if (fileExtension == ".jpg")
            {
                Cords cords = GetDimensions(fileNamePath);

                if (cords.x == 1920 && cords.y == 1080)
                {
                    form.damnedNewStage.loadingImagePath = fileNamePath;
                }
            }


            else if (fileExtension == ".scene")
            {
                form.damnedNewStage.newScenePath = fileNamePath;
            }

            else if (fileExtension == ".stage")
            {
                form.damnedNewStage.newStagePath = fileNamePath;
            }
        }
    }

    private Cords GetDimensions(string fileName)
    {
        Cords cords = new Cords();

        using (var image = Image.FromFile(fileName))
        {
            cords.x = image.Width;
            cords.y = image.Height;
        }

        return cords;
    }


    private bool CheckDirectory(string path, string extension)
    {
        bool success = true;
        FileInfo[] files = new DirectoryInfo(path).GetFiles("*", SearchOption.AllDirectories);

        for (int i = 0; i < files.Length; i++)
        {
            string fileExtension = Path.GetFileName(files[i].FullName);

            if (extension != fileExtension)
            {
                success = false;
                break;
            }

        }

        return success;

    }

    private void CreateTempDirectory()
    {
        string tempPath = Path.GetTempPath();
        int randomNumber = new Random().Next();
        string tempStringNumber = String.Format("DamnedWorkshop_{0}", randomNumber);
        tempPath = Path.Combine(tempPath, tempStringNumber);

        if (Directory.Exists(tempPath))
        {
            Directory.Delete(tempPath, true);
        }

        Directory.CreateDirectory(tempPath);
        ZipFile.ExtractToDirectory(zipArchivePath, tempPath);
        tempDirectory = tempPath;
    }

    // Called when you package the stage after adding in new maps, scenes, and loading screens 
    public void Package(DamnedNewStage[] newStages)
    {
        //string[] possibleFileExtensions = new string[] { ".obj", ".scene", ".stage", ".png", ".jpg" };

        int randomNumber = new Random().Next();
        string tempDirectory = Path.GetTempPath();
        string directoryName = String.Format("DamnedWorkshop_{0}", randomNumber);
        tempDirectory = Path.Combine(tempDirectory, directoryName);

        if (Directory.Exists(tempDirectory))
        {
            Directory.Delete(tempDirectory, true);
        }

        CreateDirectories(tempDirectory);
        DirectoryInfo[] info = new DirectoryInfo(tempDirectory).GetDirectories("*", SearchOption.AllDirectories);

        for (int i = 0; i < newStages.Length; i++)
        {
            Package(newStages[i], info);
        }

        //ZipFile.CreateFromDirectory(tempDirectory);
        Directory.Delete(tempDirectory, true);
    }

    // Too much work to write this. Probably a better way to do this.
    private void Package(DamnedNewStage newStage, DirectoryInfo[] info)
    {
        string newStageNamePath = newStage.newStagePath;
        string newStageName = Path.GetFileName(newStageNamePath);
        string newSceneNamePath = newStage.newScenePath;
        string newSceneName = Path.GetFileName(newStage.newScenePath);
        string newLoadingImageNamePath = newStage.loadingImagePath;
        string newLoadingImageName = Path.GetFileName(newLoadingImageNamePath);
        string newLobbyButtonImagePath = newStage.lobbyImageButtonPath;
        string newLobbyButtnImageName = Path.GetFileName(newStage.lobbyImageButtonPath);
        string newLobbyButtonImageHighlightedPath = newStage.lobbyImageButtonHighlightedPath;
        string newLobbyButtonImageHighlightedName = Path.GetFileName(newStage.lobbyImageButtonHighlightedPath);

        string stageAndScenePath = GetPath(info, "Stages");
        string guiPath = GetPath(info, "GUI");
        string terrorImagesPath = GetPath(info, "TerrorImages");

        string newPath = Path.Combine(stageAndScenePath, newStageName);
        File.Copy(newStageNamePath, newPath);
        newPath = Path.Combine(stageAndScenePath, newSceneName);
        File.Copy(newSceneNamePath, newPath);
        newPath = Path.Combine(terrorImagesPath, newLoadingImageName);
        File.Copy(newLoadingImageNamePath, newPath);
        newPath = Path.Combine(guiPath, newLobbyButtnImageName);
        File.Copy(newLobbyButtonImagePath, newPath);
        newPath = Path.Combine(guiPath, newLobbyButtonImageHighlightedName);
        File.Copy(newLobbyButtonImageHighlightedPath, newPath);
    }

    private string GetPath(DirectoryInfo[] info, string folderToFind)
    {
        string returnString = String.Empty;

        for (int i = 0; i < info.Length; i++)
        {
            string folder = info[i].Name;

            if (folder == folderToFind)
            {
                returnString = info[i].FullName;
                break;
            }
        }

        return returnString;
    }

     private void CreateDirectories(string tempDirectory)
    {
        string directoryToMake = Path.Combine(tempDirectory, "DamnedData", "Resources", "Stages");

        if (Directory.Exists(directoryToMake))
        {
            return;
        }

        Directory.CreateDirectory(directoryToMake);

        directoryToMake = Path.Combine(tempDirectory, "DamnedData", "Resources", "Objects");
        Directory.CreateDirectory(directoryToMake);

        if (Directory.Exists(directoryToMake))
        {
            return;
        }

        Directory.CreateDirectory(directoryToMake);


        directoryToMake = Path.Combine(tempDirectory, "DamnedData", "GUI");
        Directory.CreateDirectory(directoryToMake);

        if (Directory.Exists(directoryToMake))
        {
            return;
        }

        Directory.CreateDirectory(directoryToMake);


        directoryToMake = Path.Combine(tempDirectory, "DamnedData", "GUI", "TerrorImages");

        if (Directory.Exists(directoryToMake))
        {
            return;
        }

        Directory.CreateDirectory(directoryToMake);
    }
}


   