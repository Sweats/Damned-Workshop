using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;

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
        damnedMaps = new DamnedMaps(rootDirectory);
        damnedObjects = new DamnedObjects(rootDirectory);
        damnedSounds = new DamnedSounds(rootDirectory);
        damnedImages = new DamnedImages(rootDirectory, damnedMaps);
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
    
}


