using System;
using System.IO;

public class DamnedSounds
{

    private string directory;
    public string soundsDirectory
    {
        get;
        private set;

    }

    public string[] sounds
    {
        get;
        private set;
    }

	public DamnedSounds(string rootDirectory)
	{
        this.directory = rootDirectory;
        soundsDirectory = FindSoundsDirectory();
        SetSounds();
	}

    private void SetSounds()
    {
        string soundsDirectory = FindSoundsDirectory();

        if (!Directory.Exists(soundsDirectory))
        {
            return;
        }

        FileInfo[] soundsList = new DirectoryInfo(soundsDirectory).GetFiles("*.ogg", SearchOption.AllDirectories);
        sounds = new string[soundsList.Length];

        for (int i = 0; i < sounds.Length; i++)
        {
            sounds[i] = soundsList[i].Name;
        }
    }


    private string FindSoundsDirectory()
    {
        string returnSoundsDirectory = "";
        DirectoryInfo[] info = new DirectoryInfo(directory).GetDirectories("*", SearchOption.AllDirectories);

        for (int i = 0; i < info.Length; i++)
        {
            string soundsDirectory = info[i].Name;

            if (soundsDirectory == "Sounds")
            {
                returnSoundsDirectory = info[i].FullName;
                break;

            }
        }

        return returnSoundsDirectory;
    }
}
