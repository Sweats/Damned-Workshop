using System;
using System.IO;

public class DamnedMaps
{

    private string directory;
    public string mapAndScenesDirectory
    {
        get;
        private set;
    }

    public string[] stages
    {
        get;
        private set;

    }

    public string[] scenes
    {
        get;
        private set;
    }

    public DamnedMaps(string rootDirectory)
    {
        this.directory = rootDirectory;
        mapAndScenesDirectory = FindStagesAndScenesDirectory();
        SetMaps();
        SetScenes();

    }


    private void SetMaps()
    {
        if (!Directory.Exists(mapAndScenesDirectory))
        {
            return;
        }

        FileInfo[] stagesList = new DirectoryInfo(mapAndScenesDirectory).GetFiles("*.stage", SearchOption.TopDirectoryOnly);
        stages = new string[stagesList.Length];

        for (int i = 0; i < stages.Length; i++)
        {
            stages[i] = stagesList[i].Name;
        }
    }    

    private void SetScenes()
    {
        if (!Directory.Exists(mapAndScenesDirectory))
        {
            return;
        }

        FileInfo[] scenesList = new DirectoryInfo(mapAndScenesDirectory).GetFiles("*.scene", SearchOption.TopDirectoryOnly);
        scenes = new string[scenesList.Length];

        for (int i = 0; i < stages.Length; i++)
        {
            scenes[i] = scenesList[i].Name;
        }
    }


    private string FindStagesAndScenesDirectory()
    {
        string returnMapDirectoryPath = "";

        DirectoryInfo[] info = new DirectoryInfo(directory).GetDirectories("*", SearchOption.AllDirectories);

        for (int i = 0; i < info.Length; i++)
        {
            string stagesAndScenesDirectory = info[i].Name;

            if (stagesAndScenesDirectory == "Stages")
            {
                returnMapDirectoryPath = info[i].FullName;
                break;
            }

        }

        return returnMapDirectoryPath;
    }

}
