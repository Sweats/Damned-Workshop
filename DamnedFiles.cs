using System;
using System.IO;
using System.IO.Compression;
using System.Collections.Generic;
using System.Diagnostics;

// A wrapper class that makes dealing with the Damned filesystem easy. This will become very useful.
// Not everything is used as of now but when we need them, we have them! :)


public class DamnedFiles
{

    private string directory;
    public int filesChanged = 0;



    public string[] stageList
    {
        get;
        private set;
    }




    public string[] stageListPath
    {
        get;
        private set;
    }

    public string[] scenesList
    {
        get;
        private set;
    }

    public string[] scenesListPath
    {
        get;
        private set;
    }

    public string[] soundList
    {
        get;
        private set;
    }

    public string[] soundListPath
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

    public string[] damnedDirectoriesRelativePath
    {
        get;
        private set;
    }



    public string[] objectsList
    {
        get;
        private set;
    }

    public string[] objectsListPath
    {
        get;
        private set;
    }

    public DamnedFiles(string rootDirectory)
    {

        this.directory = rootDirectory;
        SetDirectories();
        SetMaps();
        SetObjects();
        SetSounds();
        SetScenes();
    }


    private void SetMaps()
    {
        string folder = GetDamnedDamnedDirectoryAbsolutePath("Stages");

        if (!Directory.Exists(folder))
        {
            return;
        }

        FileInfo[] stages = new DirectoryInfo(folder).GetFiles("*.stage", SearchOption.TopDirectoryOnly);
        stageList = new string[stages.Length];
        stageListPath = new string[stages.Length];

        for (int i = 0; i < stages.Length; i++)
        {
            stageList[i] = stages[i].Name;
            stageListPath[i] = stages[i].FullName;
        }
    }
    private void SetScenes()
    {
        string folder = GetDamnedDamnedDirectoryAbsolutePath("Stages");

        if (!Directory.Exists(folder))
        {
            return;
        }

        FileInfo[] stages = new DirectoryInfo(folder).GetFiles("*.scene", SearchOption.TopDirectoryOnly);
        scenesList = new string[stages.Length];
        scenesListPath = new string[stages.Length];

        for (int i = 0; i < stages.Length; i++)
        {
            scenesList[i] = stages[i].Name;
            scenesListPath[i] = stages[i].FullName;
        }
    }


    private void SetObjects()
    {

        string folder = GetDamnedDamnedDirectoryAbsolutePath("Objects");

        if (!Directory.Exists(folder))
        {
            return;
        }

        FileInfo[] objects = new DirectoryInfo(folder).GetFiles("*.obj", SearchOption.TopDirectoryOnly);
        objectsList = new string[objects.Length];
        objectsListPath = new string[objects.Length];

        for (int i = 0; i < objects.Length; i++)
        {
            objectsList[i] = objects[i].Name;
            objectsListPath[i] = objects[i].FullName;
        }

    }

    private void SetSounds()
    {
        string folder = GetDamnedDamnedDirectoryAbsolutePath("Sounds");

        if (!Directory.Exists(folder))
        {
            return;
        }

        FileInfo[] sounds = new DirectoryInfo(folder).GetFiles("*.ogg", SearchOption.AllDirectories);
        soundList = new string[sounds.Length];
        soundListPath = new string[sounds.Length];

        for (int i = 0; i < sounds.Length; i++)
        {
            soundList[i] = sounds[i].Name;
            soundListPath[i] = sounds[i].FullName;
        }
    }

    private void SetDirectories()
    {
        DirectoryInfo[] directories = new DirectoryInfo(directory).GetDirectories("*", SearchOption.AllDirectories);
        damnedDirectoriesPath = new string[directories.Length];
        damnedDirectories = new string[directories.Length];
        damnedDirectoriesRelativePath = new string[directories.Length];

        for (int i = 0; i < directories.Length; i++)
        {
            damnedDirectories[i] = directories[i].Name;
            damnedDirectoriesPath[i] = directories[i].FullName;
            //damnedDirectoriesRelativePath[i] = directories[i].
        }

    }


    private string GetDamnedDamnedDirectoryAbsolutePath(string folder)
    {
        string path = folder;

        for (int i = 0; i < damnedDirectories.Length; i++)
        {
            string folderName = damnedDirectories[i];

            if (folderName == folder)
            {
                path = damnedDirectoriesPath[i];
                break;
            }
        }

        return path;
    }

    public bool Check()
    {
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


