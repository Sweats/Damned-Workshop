using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Net;

// A wrapper class that makes dealing with the Damned filesystem easy. This will become very useful.
// Not everything is used as of now but when we need them, we have them! :)


public class DamnedFiles
{

    public string directory
    {
        get;
        private set;
    }

    public DamnedMaps damnedMaps
    {
        get;
        private set;
    }

    public DamnedSounds damnedSounds
    {
        get;
        private set;
    }

    public DamnedObjects damnedObjects
    {
        get;
        private set;
    }

    public DamnedImages damnedImages
    {
        get;
        private set;
    }
    

    public string[] damnedDirectories
    {
        get;
        private set;
    }

    public string[] damnedDirectoriesPath
    {
        get;
        private set;
    }

    public DamnedFiles(string rootDirectory)
    {

        this.directory = rootDirectory;
        SetDirectories();
    }


    public void Load()
    {
        damnedMaps = new DamnedMaps(directory);
        damnedObjects = new DamnedObjects(directory);
        damnedSounds = new DamnedSounds(directory);
        damnedImages = new DamnedImages(directory, damnedMaps, damnedObjects);
    }


     private void SetDirectories()
    {
        DirectoryInfo[] directories = new DirectoryInfo(directory).GetDirectories("*", SearchOption.AllDirectories);
        damnedDirectoriesPath = new string[directories.Length];
        damnedDirectories = new string[directories.Length];

        for (int i = 0; i < directories.Length; i++)
        {
            damnedDirectories[i] = directories[i].Name;
            damnedDirectoriesPath[i] = directories[i].FullName;
        }

    }

    public bool Check()
    {
        if (!CheckForDamnedExecutable())
        {
            return false;
        }

        string[] foldersToLookFor = new string[] { "DamnedData", "GUI", "Resources", "EditorImages", "TerrorImages", "Sounds", "Stages", "Redist", "Docs", "Ambience", "Traps" };
        int count = 0;
        int goal = foldersToLookFor.Length;
        bool success = false;

        for (int i = 0; i < foldersToLookFor.Length; i++)
        {
            string currentFolderLookingFor = foldersToLookFor[i];

            for (int k = 0; k < damnedDirectories.Length; k++)
            {
                string currentFolderFound = damnedDirectories[k];

                if (currentFolderLookingFor == currentFolderFound)
                {
                    count++;
                    break;
                }
            }

            if (count == goal)
            {
                success = true;
                break;
            }
        }

        return success;
    }

    public void Refresh()
    {
        SetDirectories();
        damnedMaps = new DamnedMaps(directory);
        damnedObjects = new DamnedObjects(directory);
        damnedSounds = new DamnedSounds(directory);
        damnedImages = new DamnedImages(directory, damnedMaps, damnedObjects);
    }

    private bool CheckForDamnedExecutable()
    {
        FileInfo[] files = new DirectoryInfo(directory).GetFiles("*.exe", SearchOption.TopDirectoryOnly);
        bool found = false;

        for (int i = 0; i < files.Length; i++)
        {
            if (files[i].Name == "Damned.exe")
            {
                found = true;
                break;
            }
        }

        return found;
    }


    public static void CleanUpNewFiles(DamnedFiles oldFiles, DamnedFiles newFiles)
    {
        CleanUpAddedDirectories(oldFiles, newFiles);
        CleanUpAddedFiles(oldFiles, newFiles);
    }

    private static void CleanUpAddedDirectories(DamnedFiles oldFiles, DamnedFiles newFiles)
    {
        DirectoryInfo[] oldInfo = new DirectoryInfo(oldFiles.directory).GetDirectories("*", SearchOption.AllDirectories);
        DirectoryInfo[] newInfo = new DirectoryInfo(newFiles.directory).GetDirectories("*", SearchOption.AllDirectories);
        List<string> foldersToDelete = new List<string>();
        bool foundMatchingDirectory;


        for (int i = 0; i < newInfo.Length; i++)
        {
            foundMatchingDirectory = false;

            string newCurrentDirectoryName = newInfo[i].Name;

            for (int k = 0; k < oldInfo.Length; k++)
            {
                string oldCurrentDirectoryName = oldInfo[k].Name;

                if (newCurrentDirectoryName == oldCurrentDirectoryName)
                {
                    foundMatchingDirectory = true;
                    break;
                }
            }

            if (!foundMatchingDirectory)
            {
                foldersToDelete.Add(newInfo[i].FullName);
            }
        }

        for (int i = 0; i < foldersToDelete.Count; i++)
        {
            Directory.Delete(foldersToDelete[i], true);

        }
    }
    

    private static void CleanUpAddedFiles(DamnedFiles oldFiles, DamnedFiles newFiles)
    {
        FileInfo[] oldInfo = new DirectoryInfo(oldFiles.directory).GetFiles("*", SearchOption.AllDirectories);
        FileInfo[] newInfo = new DirectoryInfo(newFiles.directory).GetFiles("*", SearchOption.AllDirectories);
        bool foundMatchingFile;
        List<string> filesToDelete = new List<string>();

        for (int i = 0; i < newInfo.Length; i++)
        {
            foundMatchingFile = false;
            string newCurrentFileName = newInfo[i].Name;

            for (int k = 0; k < oldInfo.Length; k++)
            {
                string oldCurrentFileName = oldInfo[k].Name;

                if (newCurrentFileName == oldCurrentFileName)
                {
                    foundMatchingFile = true;
                    break;
                }
            }

            if (!foundMatchingFile)
            {
                filesToDelete.Add(newInfo[i].FullName);
            }
        }

        for (int i = 0; i < filesToDelete.Count; i++)
        {
            File.Delete(filesToDelete[i]);

        }
    }


    // Creates a temp directory in the temp folder and returns a path to that temp folder
    public static string CreateTempWorkshopDirectory()
    {
        int randomNumber = new Random().Next();
        string tempFolderName = $"DamnedWorkshop_{randomNumber}";
        string tempPath = Path.GetTempPath();
        string workshopTempPath = Path.Combine(tempPath, tempFolderName);

        if (Directory.Exists(workshopTempPath))
        {
            Directory.Delete(workshopTempPath, true);
        }

        Directory.CreateDirectory(workshopTempPath);

        return workshopTempPath;
    }


    public static void DeleteWorkshopTempDirectories()
    {
        string tempPath = Path.GetTempPath();
        DirectoryInfo[] info = new DirectoryInfo(tempPath).GetDirectories("DamnedWorkshop_*");

        for (int i = 0; i < info.Length; i++)
        {
            Directory.Delete(info[i].FullName, true);
        }
    }


    public static string CreateTempFileInTempDirectory(string sourceFilePath)
    {
        string filePath = DamnedFiles.CreateTempWorkshopDirectory();
        string fileName = Path.GetFileName(sourceFilePath);
        string destFilePath = Path.Combine(filePath, fileName);
        File.Copy(sourceFilePath, destFilePath);
        return destFilePath;
    }


    public static bool DownloadFile(string link, string fileName)
    {
        try
        {
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(link, fileName);
            }

        }

        catch (WebException)
        {
            return false;
        }

        return true;
    }
    
}


