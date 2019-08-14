using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Collections.Generic;

public class DamnedPackage
{

    public string tempDirectory { get; private set; }
    private string zipArchivePath;


    public string reasonForFailedCheck { get; private set; }
    public int objectsCount { get; private set; }

    public bool hasObjects { get; set; }
    private bool packaging;

    public string scenePath { get; set; }
    public string stagePath { get; set; }
    public string loadingImagePath { get; set; }
    public string lobbyButtonImagePath { get; set; }
    public string lobbyButtonImageHighlightedPath { get; set; }

    public List<string> objectsPath;

    public DamnedPackage()
    {
        packaging = false;
        objectsPath = new List<string>();
    }

    public bool Check(string zipArchivePath)
    {
        this.zipArchivePath = zipArchivePath;
        hasObjects = false;

        if (Path.GetExtension(zipArchivePath) != ".zip")
        {
            string archiveName = Path.GetFileName(zipArchivePath);
            reasonForFailedCheck = String.Format("Check failed because \"{0}\" is not a .zip file. Please repackage your stage into a .zip file", archiveName);
            return false;
        }

        ExtractToTempDirectory();

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

            else if (fileExtension == ".object")
            {
                if (!CheckObject(filePath))
                {
                    success = false;
                    break;
                }
            }

            else 
            {
                success = false;
                reasonForFailedCheck = String.Format("Check failed because \"{0}\" is not a .jpg, .png, .stage, .scene, or .object format.", fileName);
                break;
            }
        }

        return success;
    }

    private bool CheckDirectories()
    {
        DirectoryInfo[] info = new DirectoryInfo(tempDirectory).GetDirectories("*", SearchOption.AllDirectories);

        string[] directoriesToCheck = new string[] { "DamnedData", "GUI", "Resources", "TerrorImages", "Stages" };

        bool success = true;

        for (int i = 1; i < info.Length; i++)
        {
            bool found = false;
            string directory = info[i].Name;
            
            if (directory == "Objects")
            {
                hasObjects = true;
                continue;
            }

            for (int j = 0; j < directoriesToCheck.Length; j++)
            {
                if (directory == directoriesToCheck[j])
                {
                    found = true;
                }
            }

            if (!found)
            {
                success = false;
                reasonForFailedCheck = String.Format("Check failed because the directory \"{0}\" is not supposed to be in your zip archive", directory);
            }
        }

        return success;
    }

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

        if (success)
        {
            string extension = Path.GetExtension(stagePath);
            string reason = String.Empty;

            if (extension == ".stage")
            {
                success = DamnedMaps.CheckInnerStageFile(stagePath, ref reason);
            }

            else if (extension == ".scene")
            {
                success = DamnedMaps.CheckInnerSceneFile(stagePath, ref reason);
            }

            if (!success)
            {
                this.reasonForFailedCheck = reason;
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
            Dimensions dimensions = DamnedImages.GetDimensions(imagePath);

            if (dimensions.x != 300 && dimensions.y != 100 || dimensions.x != 900 && dimensions.y != 100)
            {
                string imageName = Path.GetFileName(imagePath);
                reasonForFailedCheck = String.Format("Check failed because the dimensions for the image \"{0}\" is not 300 X 100 or 900 X 100", imageName);
                return false;
            }
        }

        else if (fileExtension == ".jpg")
        {
            Dimensions dimensions = DamnedImages.GetDimensions(imagePath);

            if (dimensions.x != 1920 && dimensions.y != 1080)
            {
                string imageName = Path.GetFileName(imagePath);
                reasonForFailedCheck = String.Format("Check failed because the dimensions for the image \"{0}\" is not 1920 X 1080", imageName);
                return false;
            }
        }

        return true;
    }


    private bool CheckObject(string objectPath)
    {
        string directoryNamePath = Path.GetDirectoryName(objectPath);
        string directoryName = Path.GetFileName(directoryNamePath);

        if (directoryName != "Objects")
        {
            string objectName = Path.GetFileName(objectPath);
            reasonForFailedCheck = String.Format("Check failed because object \"{0}\" does not reside in the Objects directory.", objectName);
            return false;
        }

        return true;
    }


    // Loads the variables from a zip file  into the DamnedMappingForm assuming that it is packaged correctly.
    public void Load()
    {
        FileInfo[] info = new DirectoryInfo(tempDirectory).GetFiles("*", SearchOption.AllDirectories);
        objectsCount = 0;

        for (int i = 0; i < info.Length; i++ )
        {
            string fileNamePath = info[i].FullName;
            string fileExtension = Path.GetExtension(fileNamePath);
            
            if (fileExtension == ".png")
            {
                Dimensions dimensions = DamnedImages.GetDimensions(fileNamePath);

                if (dimensions.x == 300 && dimensions.y == 100)
                {
                    lobbyButtonImagePath = fileNamePath;
                }

                else if (dimensions.x == 900 && dimensions.y == 100)
                {

                    lobbyButtonImageHighlightedPath = fileNamePath;
                }
            }

            else if (fileExtension == ".jpg")
            {
                Dimensions dimensions = DamnedImages.GetDimensions(fileNamePath);

                if (dimensions.x == 1920 && dimensions.y == 1080)
                {
                    loadingImagePath = fileNamePath;
                }
            }


            else if (fileExtension == ".scene")
            {
                scenePath = fileNamePath;
            }

            else if (fileExtension == ".stage")
            {
                stagePath = fileNamePath;
            }


            else if (fileExtension == ".object")
            {
                objectsPath.Add(fileNamePath);
                objectsCount++;
            }
        }
    }

    private void ExtractToTempDirectory()
    {
        string directoryPath = Path.GetDirectoryName(zipArchivePath);

        if (!packaging)
        {
            ZipFile.ExtractToDirectory(zipArchivePath, directoryPath);
            tempDirectory = directoryPath;
            File.Delete(zipArchivePath);
        }
        

    }

    public void Package(DamnedNewStage[] newStages, string destination)
    {
        this.packaging = true;

        for (int i = 0; i < newStages.Length; i++)
        {
            Package(newStages[i], destination);
        }
    }

    // Too much work to write this. Probably a better way to do this.
    private void Package(DamnedNewStage newStage, string destination)
    {
        tempDirectory = DamnedFiles.CreateTempWorkshopDirectory();
        CreateDirectories();
        DirectoryInfo[] info = new DirectoryInfo(tempDirectory).GetDirectories("*", SearchOption.AllDirectories);

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

        string newZipArchiveName = Path.GetFileNameWithoutExtension(newStageName).Replace("_", " ");
        newZipArchiveName = String.Format("{0}.zip", newZipArchiveName);

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
        destination = Path.Combine(destination, newZipArchiveName);

        if (newStage.hasObjects)
        {
            CreateObjectsDirectory();
            DamnedObjects damnedObjects = new DamnedObjects(tempDirectory);
            damnedObjects.CopyObjects(newStage.newObjectsPath.ToArray(), damnedObjects.objectsDirectory);
        }

        if (File.Exists(destination))
        {
            string message = String.Format("Package \"{0}\" already exists at this location. Do you wish to overwrite it?", newZipArchiveName);
            DialogResult result = MessageBox.Show(message, "Package already exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                File.Delete(destination);
            }

            else
            {
                Directory.Delete(tempDirectory, true);
                return;
            }
        }

        ZipFile.CreateFromDirectory(tempDirectory, destination);
        Directory.Delete(tempDirectory, true);
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

    private void CreateDirectories()
    {
        string directoryToMake = Path.Combine(tempDirectory, "DamnedData", "Resources", "Stages");

        if (!Directory.Exists(directoryToMake))
        {
            Directory.CreateDirectory(directoryToMake);
        }

        directoryToMake = Path.Combine(tempDirectory, "DamnedData", "GUI");

        if (!Directory.Exists(directoryToMake))
        {
            Directory.CreateDirectory(directoryToMake);
        }

        directoryToMake = Path.Combine(tempDirectory, "DamnedData", "GUI", "TerrorImages");

        if (!Directory.Exists(directoryToMake))
        {
            Directory.CreateDirectory(directoryToMake);
        }
    }


    private void CreateObjectsDirectory()
    {
        string directoryToMake = Path.Combine(tempDirectory, "DamnedData", "Resources", "Objects");

        if (!Directory.Exists(directoryToMake))
        {
            Directory.CreateDirectory(directoryToMake);
        }
    }
}


   