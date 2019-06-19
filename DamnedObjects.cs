using System;
using System.IO;

public class DamnedObjects
{
    private string directory;
    public string objectsDirectory
    {
        get;
        private set;
    }

    public string[] objects
    {
        get;
        private set;
    }

	public DamnedObjects(string rootDirectory)
	{
        this.directory = rootDirectory;
        objectsDirectory = FindObjectDirectory();
        SetObjects();

	}

    private void SetObjects()
    {
        string folder = FindObjectDirectory();

        if (!Directory.Exists(folder))
        {
            return;
        }

        FileInfo[] objectsList = new DirectoryInfo(folder).GetFiles("*.obj", SearchOption.TopDirectoryOnly);
        objects = new string[objectsList.Length];

        for (int i = 0; i < objects.Length; i++)
        {
            objects[i] = objectsList[i].Name;
        }

    }

    private string FindObjectDirectory()
    {
        string returnDirectoryPath = "";
        DirectoryInfo[] info = new DirectoryInfo(directory).GetDirectories("*", SearchOption.AllDirectories);

        for (int i = 0; i < info.Length; i++)
        {
            string objectDirectory = info[i].Name;

            if (objectDirectory == "Objects")
            {
                returnDirectoryPath = info[i].FullName;
                break;
                
            }
        }

        return returnDirectoryPath;

    }

}
