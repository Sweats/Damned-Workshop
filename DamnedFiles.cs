using System;
using System.IO;


// A wrapper class that makes dealing with the Damned filesystem easy. This will become very useful.

public class DamnedFiles
{


    private string directory;

    public string[] stagesList
    {
        get;
        private set;
    }




    public string[] stagesListPath
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
        // TODO: Do a if check in here for valid folders before setting the rest of the stuff?
        SetMaps();
        SetObjects();
        SetSounds();
        SetScenes();
    }


    private void SetMaps()
    {
        string folder = GetDamnedDamnedDirectoryAbsolutePath("Stages");
        FileInfo[] stages = new DirectoryInfo(directory).GetFiles("*.stage", SearchOption.TopDirectoryOnly);
        stagesList = new string[stages.Length];
        stagesListPath = new string[stages.Length];

        for (int i = 0; i < stages.Length; i++)
        {
            stagesList[i] = stages[i].Name;
            stagesListPath[i] = stages[i].FullName;
        }
    }

    private void SetScenes()
    {
        string folder = GetDamnedDamnedDirectoryAbsolutePath("Stages");
        FileInfo[] stages = new DirectoryInfo(directory).GetFiles("*.scene", SearchOption.TopDirectoryOnly);
        scenesList = new string[stages.Length];
        scenesListPath = new string[stages.Length];

        for (int i = 0; i < stages.Length; i++)
        {
            scenesList[i] = stages[i].Name;
            scenesListPath[i] = stages[i].FullName;
        }
    }


    private void SetObjects(bool fullPath = false)
    {
        string folder = GetDamnedDamnedDirectoryAbsolutePath("Objects");
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

        for (int i = 0; i < directories.Length; i++)
        {
            damnedDirectories[i] = directories[i].Name;
            damnedDirectoriesPath[i] = directories[i].FullName;
        }

    }


    private string GetDamnedDamnedDirectoryAbsolutePath(string folder)
    {
        string path = folder;

        for (int i = 0; i < damnedDirectoriesPath.Length; i++)
        {
            path = damnedDirectoriesPath[i];

            if (folder == path)
            {
                break;
            }
        }

        return path;
    }



    // Only use for the game directory itself and not the temp directory.
    public bool Check()
    {
        string[] foldersToLookFor = new string[] { "DamnedData", "GUI", "Resources", "EditorImages", "TerrorImages", "Objects", "Sounds", "Stages", "Redist", "Docs", "Ambience", "Traps" };
        int count = 0;
        int goal = foldersToLookFor.Length;
        bool success = false;

        for (int i = 0; i < foldersToLookFor.Length; i++)
        {
            string currentFolderLookingFor = foldersToLookFor[i];

            for (int k = 0; k < damnedDirectories.Length; i++)
            {
                string currentFolderFound = damnedDirectories[i];

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

    public void Extract(DamnedFiles dest)
    {

    }


    // First step is to clean all the new files that do not exist in the base game.
    // Second step is to loop through the original files and compute the hash and see if they are different. If so, then warn the user that they may need to download the old files
    // from the stable repository from GitHub.
    public static void CleanPublicTestPatchFiles(DamnedFiles original, DamnedFiles modified)
    {

        CleanPublicTestPatchStages(original, modified);
        CleanPublicTestPatchScenes(original, modified);
        CleanPublicTestPatchSounds(original, modified);
        CleanPublicTestPatchObjects(original, modified);
        ScanForModifiedFiles(original, modified);


    }

    private static void CleanPublicTestPatchStages(DamnedFiles original, DamnedFiles modified)
    {
        string[] originalStagesList = original.stagesList;
        string[] modifiedStagesList = modified.stagesList;

        for (int i = 0; i < originalStagesList.Length; i++)
        {
            string originalStage = originalStagesList[i];

            for (int k = 0; k < modifiedStagesList.Length; k++)
            {
                string newStage = modifiedStagesList[k];

                if (originalStage == newStage)
                {
                    File.Delete(original.stagesListPath[i]);
                    break;
                }
            }
        }

    }

    private static void CleanPublicTestPatchScenes(DamnedFiles original, DamnedFiles modified)
    {
        string[] originalScenesList = original.scenesList;
        string[] modifiedScenesList = modified.scenesList;

        for (int i = 0; i < originalScenesList.Length; i++)
        {
            string originalScene = originalScenesList[i];

            for (int k = 0; k < modifiedScenesList.Length; k++)
            {
                string newScene = modifiedScenesList[k];

                if (originalScene == newScene)
                {
                    File.Delete(original.scenesListPath[i]);
                    break;
                }
            }
        }
    }


    private static void CleanPublicTestPatchSounds(DamnedFiles original, DamnedFiles modified)
    {
        string[] originalSoundList = original.soundList;
        string[] modifiedSoundList = modified.soundList;

        for (int i = 0; i < originalSoundList.Length; i++)
        {
            string originalSound = originalSoundList[i];

            for (int k = 0; k < modifiedSoundList.Length; k++)
            {
                string newSound = modifiedSoundList[i];

                if (originalSound == newSound)
                {
                    File.Delete(original.soundListPath[i]);
                    break;
                }
            }
        }
    }


    private static void CleanPublicTestPatchObjects(DamnedFiles original, DamnedFiles modified)
    {
        string[] originalObjectsList = original.objectsList;
        string[] modifiedObjectsList = modified.objectsList;

        for (int i = 0; i < originalObjectsList.Length; i++)
        {
            string originalObject = originalObjectsList[i];

            for (int k = 0; k < modifiedObjectsList.Length; k++)
            {
                string newObject = modifiedObjectsList[k];

                if (originalObject == newObject)
                {
                    File.Delete(original.objectsListPath[i]);
                    break;
                }
            }
        }
    }


    private static void ScanForModifiedFiles(DamnedFiles original, DamnedFiles modifiedFiles)
    {

    }
}


