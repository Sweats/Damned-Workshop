using System.IO;
using System.Collections.Generic;

public class DamnedMaps
{

    private string directory;
    public string stagesAndScenesDirectory
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
        SetStagesAndScenesDirectory();
        SetStages();
        SetScenes();
    }


    private void SetStages()
    {
        if (!Directory.Exists(stagesAndScenesDirectory))
        {
            return;
        }

        FileInfo[] stagesList = new DirectoryInfo(stagesAndScenesDirectory).GetFiles("*.stage", SearchOption.TopDirectoryOnly);
        List<string> stages = new List<string>();

        for (int i = 0; i < stagesList.Length; i++)
        {
            if (stagesList[i].Name == "menu_background.stage")
            {
                continue;
            }

            stages.Add(stagesList[i].FullName);
        }

        this.stages = stages.ToArray();
    }

    public void RefreshStages()
    {
        SetStages();
    }

    private void SetScenes()
    {
        if (!Directory.Exists(stagesAndScenesDirectory))
        {
            return;
        }

        FileInfo[] scenesList = new DirectoryInfo(stagesAndScenesDirectory).GetFiles("*.scene", SearchOption.TopDirectoryOnly);
        List<string> scenes = new List<string>();

        for (int i = 0; i < scenesList.Length; i++)
        {
            if (scenesList[i].Name == "menu_background.scene")
            {
                continue;
            }

            scenes.Add(scenesList[i].FullName);
        }

        this.scenes = scenes.ToArray();
    }

    public void RemoveStage(string stageName)
    {
        string stageToFind = Path.GetFileName(stageName);

        for (int i = 0; i < stages.Length; i++)
        {
            string stageToRemove = Path.GetFileName(stages[i]);

            if (stageToRemove == stageToFind)
            {
                File.Delete(stages[i]);
                break;
            }
        }
    }


    public void RemoveScene(string sceneName)
    {
        string sceneToFind = Path.GetFileName(sceneName);

        for (int i = 0; i < scenes.Length; i++)
        {
            string sceneToRemove = Path.GetFileName(scenes[i]);

            if (sceneToRemove == sceneToFind)
            {
                File.Delete(scenes[i]);
                break;
            }
        }

    }

    public bool StageExists(string stageName)
    {
        bool found = false;

        for (int i = 0; i < stages.Length; i++)
        {
            string stageToFind = Path.GetFileName(stages[i]);

            if (stageName == stageToFind)
            {
                found = true;
                break;
            }
        }

        return found;
    }


    public void AddStages(string[] stages)
    {
        for (int i = 0; i < stages.Length; i++)
        {
            File.Copy(stages[i], Path.Combine(stagesAndScenesDirectory, Path.GetFileName(stages[i])));
        }
    }

    private void SetStagesAndScenesDirectory()
    {
        DirectoryInfo[] info = new DirectoryInfo(directory).GetDirectories("*", SearchOption.AllDirectories);

        for (int i = 0; i < info.Length; i++)
        {
            string stagesAndScenesDirectory = info[i].Name;

            if (stagesAndScenesDirectory == "Stages")
            {
                this.stagesAndScenesDirectory = info[i].FullName;
                break;
            }

        }
    }
}
