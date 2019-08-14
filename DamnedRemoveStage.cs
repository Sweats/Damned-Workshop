using System;

// A simple class that is only supposed to be used in a List<T>
public class DamnedRemoveStage
{
    public string stagePath { get; set; }
    public string scenePath { get; set; }
    public DamnedRemoveStage()
    {
        this.stagePath = String.Empty;
        this.scenePath = String.Empty;

    }

    public DamnedRemoveStage(DamnedRemoveStage copy)
    {
        this.stagePath = copy.stagePath;
        this.scenePath = copy.scenePath;

    }

    public void Clear()
    {
        this.stagePath = String.Empty;
        this.scenePath = String.Empty;
    }
}
