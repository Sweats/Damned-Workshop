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

        if (objectsDirectory == String.Empty)
        {
            CreateObjectsDirectory();
        }

        SetObjects();
	}


    private void CreateObjectsDirectory()
    {
        objectsDirectory = Path.Combine(directory, "DamnedData", "Resources", "Objects");
        Directory.CreateDirectory(objectsDirectory);
    }

    private void SetObjects()
    {
        if (!Directory.Exists(objectsDirectory))
        {
            return;
        }

        FileInfo[] objectsList = new DirectoryInfo(objectsDirectory).GetFiles("*.object", SearchOption.TopDirectoryOnly);
        objects = new string[objectsList.Length];

        for (int i = 0; i < objects.Length; i++)
        {
            objects[i] = objectsList[i].Name;
        }

    }

    private string FindObjectDirectory()
    {
        string returnDirectoryPath = String.Empty;
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

    public void CopyObjects(string[] sourceObjectsPath, string dest)
    {
        for (int i = 0; i < sourceObjectsPath.Length; i++)
        {
            CopyObject(sourceObjectsPath[i], dest);
        }

    }

    public void CopyObject(string sourcePath, string dest)
    {
        string objectName = Path.GetFileName(sourcePath);
        string newPath = Path.Combine(dest, objectName);
        File.Copy(sourcePath, newPath);
    }
}
