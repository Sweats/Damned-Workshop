using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

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

    public static bool CheckInnerStageFile(string stagePath, ref string failedReason)
    {
        string nameToMatch = Path.GetFileNameWithoutExtension(stagePath);
        string stageName = Path.GetFileName(stagePath);

        using (StreamReader reader = new StreamReader(stagePath))
        {
            string contents = reader.ReadToEnd();
            string stageLineToFind = String.Format("stage {0}", nameToMatch);
            string sceneLineToFind = String.Format("scene {0}", nameToMatch);

            Match match = Regex.Match(contents, stageLineToFind);

            if (!match.Success)
            {
                failedReason = String.Format("Check failed because the stage section in \"{0}\" does not match the file name.", stageName);
                return false;
            }

            match = Regex.Match(contents, sceneLineToFind);

            if (!match.Success)
            {
                failedReason = String.Format("Check failed because the scene section in \"{0}\" does not match the scene name", stageName);
                return false;
            }
        }

        return true;


    }
    private static bool CheckSceneForLights(string sceneFileContents, string scenePath, ref string failedReason)
    {
        MatchCollection collection = Regex.Matches(sceneFileContents, "light light.[0-9]+");

        if (collection.Count < 1)
        {
            string name = Path.GetFileName(scenePath);
            failedReason = String.Format("Check failed because \"{0}\" does not have any light points.", name);
            return false;
        }

        return true;
    }

    private static bool CheckSceneForSpawnPoints(string sceneFileContents, string scenePath, ref string failedReason)
    {
        MatchCollection collection = Regex.Matches(sceneFileContents, "spawn_point [0-9]+");
        string name = Path.GetFileName(scenePath);

        if (collection.Count < 1)
        {
            failedReason = String.Format("Check failed because \"{0}\" does not have any spawn points", name);
            return false;
        }

        int matchCount = collection.Count;

        if (matchCount < 7)
        {
            failedReason = String.Format("Check failed because \"{0}\" does not have enough spawn points. Found spawn point count: {1}. Required count: 7.", name, matchCount);
            return false;
        }

        return true;
    }


    private static bool CheckSceneForProperSceneName(string sceneFileContents, string scenePath, ref string failedReason)
    {
        string sceneName = Path.GetFileNameWithoutExtension(scenePath);
        string pattern = String.Format("scene {0}", sceneName);
        Match match = Regex.Match(sceneFileContents, pattern);

        if (!match.Success)
        {
            failedReason = String.Format("Check failed because the scene section in {0} does not match the actual file name.", sceneName);
            return false;
        }

        return true;
    }

    public static bool CheckInnerSceneFile(string scenePath, ref string failedReason)
    {
        using (StreamReader reader = new StreamReader(scenePath))
        {
            string contents = reader.ReadToEnd();

            if (!CheckSceneForProperSceneName(contents, scenePath, ref failedReason))
            {
                return false;
            }

            if (!CheckSceneForSpawnPoints(contents, scenePath, ref failedReason))
            {
                return false;
            }

            if (!CheckSceneForLights(contents, scenePath, ref failedReason))
            {
                return false;
            }

        }

        return true;
    }
}
