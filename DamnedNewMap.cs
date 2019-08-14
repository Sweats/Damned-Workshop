using System;
using System.Collections.Generic;

public class DamnedNewStage
{
    public string loadingImagePath { get; set; }
    public string lobbyImageButtonPath { get; set; }
    public string lobbyImageButtonHighlightedPath { get; set; }
    public string newStagePath { get; set; }
    public string newScenePath { get; set; }

    public List<string> newObjectsPath { get; set; }

    public bool hasObjects { get; set; }
    public int count { get; set; }

    public DamnedNewStage()
    {
        this.lobbyImageButtonPath = String.Empty;
        this.loadingImagePath = String.Empty;
        this.newStagePath = String.Empty;
        this.lobbyImageButtonHighlightedPath = String.Empty;
        this.newScenePath = String.Empty;
        this.newObjectsPath = new List<string>();
        this.hasObjects = false;
    }

    public DamnedNewStage(DamnedNewStage copy)
    {
        this.loadingImagePath = copy.loadingImagePath;
        this.lobbyImageButtonPath = copy.lobbyImageButtonPath;
        this.newStagePath = copy.newStagePath;
        this.lobbyImageButtonHighlightedPath = copy.lobbyImageButtonHighlightedPath;
        this.newScenePath = copy.newScenePath;
        this.newObjectsPath = new List<string>(copy.newObjectsPath);
        this.hasObjects = copy.hasObjects;
    }

    public void Clear()
    {
        lobbyImageButtonPath = String.Empty;
        loadingImagePath = String.Empty;
        newStagePath = String.Empty;
        lobbyImageButtonHighlightedPath = String.Empty;
        newScenePath = String.Empty;
        newObjectsPath.Clear();
        hasObjects = false;
        count = 0;

    }
}

