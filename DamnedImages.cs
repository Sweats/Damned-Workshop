using System;
using System.IO;
using System.Xml;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Drawing;

public struct Dimensions
{
    public int x;
    public int y;
}

public class DamnedImages
{
    public string[] images
    {
        get;
        private set;
    }

    public string[] imagesFullPath
    {
        get;
        private set;
    }

    private string directory;

    public string guiDirectory
    {
        get;
        private set;
    }


    public string damnedStagesXmlFile
    {
        get;
        private set;
    }

    public string terrorZipFile
    {
        get;
        private set;
    }

    public string terrorImagesDirectory
    {
        get;
        private set;
    }

    public string xmlFile
    {
        get;
        private set;
    }


    public string lobbyImages
    {
        get;
        private set;
    }

    private DamnedMaps damnedStages;

    private DamnedObjects damnedObjects;

    public DamnedImages(string rootDirectory, DamnedMaps damnedStages, DamnedObjects damnedObjects)
    {
        directory = rootDirectory;
        this.damnedStages = damnedStages;
        this.damnedObjects = damnedObjects;
        SetGUIDirectory();
        SetImages();
        SetDamnedStagesXmlFile();
        SetDamnedTerrorZipFile();
        SetTerrorImagesDirectory();
    }


    private void SetGUIDirectory()
    {
        DirectoryInfo[] info = new DirectoryInfo(directory).GetDirectories("*", SearchOption.AllDirectories);

        for (int i = 0; i < info.Length; i++)
        {
            string directory = info[i].Name;

            if (directory == "GUI")
            {
                guiDirectory = info[i].FullName;
                break;
            }
        }

    }

    public string GetLayoutFileFromZip(string rootTempFolder)
    {
        FileInfo[] info = new DirectoryInfo(rootTempFolder).GetFiles("*.layout", SearchOption.AllDirectories);
        string layoutFileNamePath = String.Empty;

        for (int i = 0; i < info.Length; i++)
        {
            string layoutName = info[i].Name;

            if (layoutName == "StageSelection.layout")
            {
                layoutFileNamePath = info[i].FullName;
                break;
            }
        }

        return layoutFileNamePath;
    }

    private void SetTerrorImagesDirectory()
    {
        string directoryToFind = "TerrorImages";
        DirectoryInfo[] info = new DirectoryInfo(directory).GetDirectories(directoryToFind, SearchOption.AllDirectories);

        for (int i = 0; i < info.Length; i++)
        {
            string folderName = info[i].Name;

            if (folderName == directoryToFind)
            {
                terrorImagesDirectory = info[i].FullName;
                break;

            }

        }
    }

    private void SetImages()
    {
        FileInfo[] files = new DirectoryInfo(directory).GetFiles("*.png", SearchOption.AllDirectories);
        images = new string[files.Length];
        imagesFullPath = new string[files.Length];

        for (int i = 0; i < files.Length; i++)
        {
            images[i] = files[i].Name;
            imagesFullPath[i] = files[i].FullName;

        }
    }

    private void SetDamnedStagesXmlFile()
    {
        FileInfo[] info = new DirectoryInfo(directory).GetFiles("*.xml", SearchOption.AllDirectories);

        for (int i = 0; i < info.Length; i++)
        {
            string fileName = info[i].Name;

            if (fileName == "DamnedStages.xml")
            {
                damnedStagesXmlFile = info[i].FullName;
                break;
            }
        }
    }

    private void SetDamnedTerrorZipFile()
    {
        FileInfo[] info = new DirectoryInfo(directory).GetFiles("*.zip", SearchOption.AllDirectories);

        for (int i = 0; i < info.Length; i++)
        {
            string fileName = info[i].Name;

            if (fileName == "Terror.zip")
            {
                terrorZipFile = info[i].FullName;
            }
        }

    }

    public string GetImage(string name)
    {
        string imageString = String.Empty;

        for (int i = 0; i < images.Length; i++)
        {
            imageString = images[i];

            if (imageString == name)
            {
                imageString = imagesFullPath[i];
                break;
            }
        }

        return imageString;
    }

    public void UpdateXmlFiles(string layoutFile, DamnedRemoveStage[] stagesToRemove, DamnedNewStage[] newMaps)
    {
        SortImages(stagesToRemove, newMaps);
        UpdateDamnedStagesXmlFile(newMaps);
        UpdateStagesLayoutFile(layoutFile);
    }

    private void RenameImagesAfterRemovingStage(FileInfo[] info, int oldStageIndex, int newStageIndex)
    {
        info = new DirectoryInfo(terrorImagesDirectory).GetFiles("stage_*.png", SearchOption.TopDirectoryOnly);

        for (int i = 0; i < info.Length; i++)
        {
            string imageName = info[i].Name;
            int imageIndex = int.Parse(Regex.Match(imageName, @"[0-9]+").Value);

            if (newStageIndex == imageIndex)
            {
                string oldImageFullPath = info[i].FullName;
                string newImageName = String.Format("stage_{0}.png", oldStageIndex);
                string newImageNamePath = Path.Combine(terrorImagesDirectory, newImageName);
                Microsoft.VisualBasic.FileSystem.Rename(oldImageFullPath, newImageNamePath);
                RenameImagesAfterRemovingStage(info, oldStageIndex += 1, newStageIndex += 1);
                break;

            }
        }
    }

    private void RenameImagesForAddingStage(FileInfo[] info, int indexToRenameFrom, int indexToRenameTo, bool exit = false)
    {
        if (exit)
        {
            return;
        }

        for (int i = 0; i < info.Length; i++)
        {
            string imageName = info[i].Name;
            int imageIndex = int.Parse(Regex.Match(imageName, @"[0-9]+").Value);

            if (imageIndex == indexToRenameFrom)
            {
                string oldImageNamePath = info[i].FullName;
                string newImageName = String.Format("stage_{0}.png", indexToRenameFrom + 1);
                string newImageNamePath = Path.Combine(terrorImagesDirectory, newImageName);
                Microsoft.VisualBasic.FileSystem.Rename(oldImageNamePath, newImageNamePath);

                if (indexToRenameTo == indexToRenameFrom)
                {
                    exit = true;
                }

                RenameImagesForAddingStage(info, indexToRenameFrom -= 1, indexToRenameTo, exit);
                break;

            }
        }
    }


    private void SortImages(DamnedRemoveStage[] stagesToRemove, DamnedNewStage[] newMaps)
    {

        FileInfo[] info = new DirectoryInfo(terrorImagesDirectory).GetFiles("stage_*.png", SearchOption.TopDirectoryOnly);
        List<string> oldStagesSorted = new List<string>(damnedStages.stages);
        oldStagesSorted.Sort();

        for (int i = 0; i < stagesToRemove.Length; i++)
        {
            damnedStages.RemoveStage(stagesToRemove[i].stagePath);
            damnedStages.RemoveScene(stagesToRemove[i].scenePath);
            damnedStages.RefreshStages();

            string mapToRemove = stagesToRemove[i].stagePath;
            int oldImageIndex = oldStagesSorted.BinarySearch(mapToRemove);
            string imageNameToDelete = String.Format("stage_{0}.png", oldImageIndex);
            string loadingImageToDelete = String.Format("loading_{0}.jpg", Path.GetFileNameWithoutExtension(stagesToRemove[i].stagePath));

            DeleteLobbyButtonImage(info, imageNameToDelete);
            DeleteLoadingScreenImage(loadingImageToDelete);
            RenameImagesAfterRemovingStage(info, oldImageIndex, oldImageIndex + 1);

            oldStagesSorted.RemoveAt(oldImageIndex);
        }


        info = new DirectoryInfo(terrorImagesDirectory).GetFiles("stage_*.png", SearchOption.TopDirectoryOnly);
        oldStagesSorted.Sort();

        for (int i = 0; i < newMaps.Length; i++)
        {
            string newStageName = Path.GetFileName(newMaps[i].newStagePath);
            string newStageNamePath = Path.Combine(damnedStages.stagesAndScenesDirectory, newStageName);
            string newSceneName = Path.GetFileName(newMaps[i].newScenePath);
            string newSceneNamePath = Path.Combine(damnedStages.stagesAndScenesDirectory, newSceneName);
            oldStagesSorted.Add(newStageNamePath);
            File.Copy(newMaps[i].newStagePath, newStageNamePath);
            File.Copy(newMaps[i].newScenePath, newSceneNamePath);
            damnedStages.RefreshStages();
            oldStagesSorted.Sort();

            int newImageIndex = oldStagesSorted.BinarySearch(newStageNamePath);

            if (newImageIndex > 0)
            {
                string imageNameToReplace = String.Format("stage_{0}.png", newImageIndex);
                string newImagePath = Path.Combine(terrorImagesDirectory, imageNameToReplace);
                int highestNumber = FindHighestNumber(info);
                RenameImagesForAddingStage(info, highestNumber, newImageIndex);
                File.Copy(newMaps[i].lobbyImageButtonPath, newImagePath);

                string newLoadingImageName = newStageName.Remove(newStageName.IndexOf(".", 6));
                newLoadingImageName = String.Format("loading_{0}.jpg", newLoadingImageName);
                string newLoadingImageNamePath = Path.Combine(terrorImagesDirectory, newLoadingImageName);
                File.Copy(newMaps[i].loadingImagePath, newLoadingImageNamePath);

                string newLobbyHighlightedButton = newStageName.ToLower().Replace("_", String.Empty);
                newLobbyHighlightedButton = newLobbyHighlightedButton.Remove(newLobbyHighlightedButton.IndexOf("."), 6);
                newLobbyHighlightedButton = String.Format("DamnedStages_{0}.png", newLobbyHighlightedButton);
                string newLobbyHighlightedButtonPath = Path.Combine(guiDirectory, newLobbyHighlightedButton);
                File.Copy(newMaps[i].lobbyImageButtonHighlightedPath, newLobbyHighlightedButtonPath);

                if (newMaps[i].hasObjects)
                {
                    damnedObjects.CopyObjects(newMaps[i].newObjectsPath.ToArray(), damnedObjects.objectsDirectory);
                }
            }

        }

        damnedStages.RefreshStages();

    }

    private int FindHighestNumber(FileInfo[] info)
    {
        int highestNumber = -1;

        for (int i = 0; i < info.Length; i++)
        {
            string imageName = info[i].Name;
            int imageIndex = int.Parse(Regex.Match(imageName, @"[0-9]+").Value);

            if (imageIndex > highestNumber)
            {
                highestNumber = imageIndex;
                continue;
            }
        }

        return highestNumber;
    }


    private void DeleteLobbyButtonImage(FileInfo[] info, string imageName)
    {
        for (int i = 0; i < info.Length; i++)
        {
            if (imageName == info[i].Name)
            {
                if (File.Exists(info[i].FullName))
                {
                    File.Delete(info[i].FullName);
                    break;
                }
            }
        }
    }


    private void DeleteLoadingScreenImage(string loadingimageName)
    {
        FileInfo[] info = new DirectoryInfo(terrorImagesDirectory).GetFiles("*.jpg", SearchOption.TopDirectoryOnly);

        for (int i = 0; i < info.Length; i++)
        {
            string name = info[i].Name;

            if (name == loadingimageName)
            {
                File.Delete(info[i].FullName);
                break;
            }
        }
    }

    private void UpdateStagesLayoutFile(string layoutFile)
    {
        List<string> mapsSorted = new List<string>(damnedStages.stages);
        mapsSorted.Sort();
        XmlDocument doc = new XmlDocument();
        XmlElement rootElement = doc.CreateElement("MyGUI");
        rootElement.SetAttribute("type", "Layout");
        rootElement.SetAttribute("version", "3.2.0");

        XmlElement secondElement = doc.CreateElement("Widget");
        secondElement.SetAttribute("type", "Widget");
        secondElement.SetAttribute("skin", "open_panel");
        secondElement.SetAttribute("position", "338 129 690 510");
        secondElement.SetAttribute("align", "Center");
        secondElement.SetAttribute("layer", "Popup");
        rootElement.AppendChild(secondElement);

        XmlElement thirdElement = doc.CreateElement("Widget");

        thirdElement.SetAttribute("type", "TabControl");
        thirdElement.SetAttribute("skin", "TabControl");
        thirdElement.SetAttribute("position", "10 40 670 400");
        secondElement.AppendChild(thirdElement);

        int pageStart = 1;
        int pageEnd = 6;
        int pageCount = 6;


        int counter = 0;
        int yCount = 20;

        for (int i = 0; i < mapsSorted.Count; i++)
        {
            string map = Path.GetFileNameWithoutExtension(mapsSorted[i]).ToLower().Replace("_", String.Empty);

            if (pageCount % 6 == 0)
            {
                XmlElement lobbyElement = doc.CreateElement("Widget");

                lobbyElement.SetAttribute("type", "TabItem");
                lobbyElement.SetAttribute("skin", String.Empty);
                lobbyElement.SetAttribute("position", "2 24 664 372");
                thirdElement.AppendChild(lobbyElement);

                XmlElement propertyElement = doc.CreateElement("Property");

                propertyElement.SetAttribute("key", "Caption");
                propertyElement.SetAttribute("value", String.Format("{0}-{1}", pageStart, pageEnd));
                lobbyElement.AppendChild(propertyElement);
                doc.AppendChild(rootElement);

                pageStart += 6;
                pageEnd += 6;

            }

            XmlElement widgetElement = doc.CreateElement("Widget");

            widgetElement.SetAttribute("type", "Button");
            widgetElement.SetAttribute("skin", map);
            widgetElement.SetAttribute("name", String.Format("Stage{0}Checkbox", i));

            if (i == 0 || i % 2 == 0)
            {
                int xPos = 20;
                int yPos = yCount;
                string positionString = String.Format("{0} {1} 300 100", xPos, yPos);
                widgetElement.SetAttribute("position", positionString);
            }

            else if (i % 2 != 0)
            {
                int xPos = 340;
                int yPos = yCount;
                string positionString = String.Format("{0} {1} 300 100", xPos, yPos);
                widgetElement.SetAttribute("position", positionString);
            }

            counter++;

            if (counter >= 2)
            {
                counter = 0;
                yCount += 115;
            }

            if (yCount > 250)
            {
                yCount = 20;
            }

            pageCount++;
            XmlNodeList tempList = doc.SelectNodes("MyGUI/Widget/Widget/Widget[@type='TabItem']");
            XmlNode nodeToAppendTo = tempList[tempList.Count - 1];
            nodeToAppendTo.AppendChild(widgetElement);


        }

        XmlElement fourthElement = doc.CreateElement("Widget");
        fourthElement.SetAttribute("type", "TextBox");
        fourthElement.SetAttribute("skin", "TextBox");
        fourthElement.SetAttribute("position", "85 10 515 25");
        fourthElement.SetAttribute("name", "TitleTextbox");

        XmlElement firstSubPropertyElement = doc.CreateElement("Property");
        firstSubPropertyElement.SetAttribute("key", "TextAlign");
        firstSubPropertyElement.SetAttribute("value", "Center");
        fourthElement.AppendChild(firstSubPropertyElement);

        XmlElement secondSubPropertyElement = doc.CreateElement("Property");
        secondSubPropertyElement.SetAttribute("key", "TextShadow");
        secondSubPropertyElement.SetAttribute("value", "true");
        fourthElement.AppendChild(secondSubPropertyElement);

        secondElement.AppendChild(fourthElement);

        XmlElement fifthElement = doc.CreateElement("Widget");
        fifthElement.SetAttribute("type", "Button");
        fifthElement.SetAttribute("skin", "ButtonImage");
        fifthElement.SetAttribute("position", "240 450 220 45");
        fifthElement.SetAttribute("name", "OKButton");


        XmlElement thirdSubPropertyElement = doc.CreateElement("Property");
        thirdSubPropertyElement.SetAttribute("key", "Caption");
        thirdSubPropertyElement.SetAttribute("value", "OK");
        fifthElement.AppendChild(thirdSubPropertyElement);

        XmlElement fourthSubPropertyElement = doc.CreateElement("Property");
        fourthSubPropertyElement.SetAttribute("key", "TextShadow");
        fourthSubPropertyElement.SetAttribute("value", "true");
        fifthElement.AppendChild(fourthSubPropertyElement);

        XmlElement fifthSubPropertyElement = doc.CreateElement("Property");
        fifthSubPropertyElement.SetAttribute("key", "FontName");
        fifthSubPropertyElement.SetAttribute("value", "RomFatalBold");
        fifthElement.AppendChild(fifthSubPropertyElement);

        secondElement.AppendChild(fifthElement);

        XmlElement sixthElement = doc.CreateElement("CodeGeneratorSettings");
        rootElement.AppendChild(sixthElement);
        doc.AppendChild(rootElement);

        doc.Save(layoutFile);
    }

    private void UpdateDamnedStagesXmlFile(DamnedNewStage[] newMaps)
    {
        XmlDocument doc = new XmlDocument();

        XmlElement myGuiElement = doc.CreateElement("MyGUI");
        myGuiElement.SetAttribute("type", "Resource");
        myGuiElement.SetAttribute("version", "1.1");

        doc.AppendChild(myGuiElement);

        List<string> mapsSorted = new List<string>(damnedStages.stages);
        mapsSorted.Sort();

        for (int i = 0; i < damnedStages.stages.Length; i++)
        {
            string stageNamePath = Path.GetFileName(damnedStages.stages[i]);
            string stage = stageNamePath.ToLower().Replace("_", String.Empty);
            stage = stage.Remove(stage.IndexOf("."), 6);

            XmlElement resourceElement = doc.CreateElement("Resource");
            resourceElement.SetAttribute("type", "ResourceSkin");
            resourceElement.SetAttribute("name", stage);
            resourceElement.SetAttribute("size", "300 100");
            string textureName = String.Format("DamnedStages_{0}.png", stage);
            resourceElement.SetAttribute("texture", textureName);

            myGuiElement.AppendChild(resourceElement);

            XmlElement basisSkinElement = doc.CreateElement("BasisSkin");
            basisSkinElement.SetAttribute("type", "SubSkin");
            basisSkinElement.SetAttribute("offset", "0 0 300 100");
            basisSkinElement.SetAttribute("align", "Stretch");

            resourceElement.AppendChild(basisSkinElement);

            string[] namesToCreate = new string[] { "disabled", "normal", "highlighted", "pushed", "disabled_checked", "normal_checked", "highlighted_checked", "pushed_checked" };

            for (int j = 0; j < namesToCreate.Length; j++)
            {
                XmlElement stateElement = doc.CreateElement("State");

                stateElement.SetAttribute("name", namesToCreate[j]);

                string stateName = namesToCreate[j];

                if (stateName == "disabled" || stateName == "normal")
                {
                    stateElement.SetAttribute("offset", "600 0 300 100");

                }

                else if (stateName == "highlighted" || stateName == "highlighted_checked")
                {
                    stateElement.SetAttribute("offset", "300 0 300 100");
                }

                else
                {
                    stateElement.SetAttribute("offset", "0 0 300 100");
                }

                basisSkinElement.AppendChild(stateElement);
            }
        }

        doc.Save(damnedStagesXmlFile);
    }

    public static Dimensions GetDimensions(string imagePath)
    {
        Dimensions dimensions = new Dimensions();

        using (var image = Image.FromFile(imagePath))
        {
            dimensions.x = image.Width;
            dimensions.y = image.Height;
        }

        return dimensions;
    }
}
