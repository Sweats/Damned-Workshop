# Goal

The goal of the Damned Workshop is to act as the official Steam workshop for Damnned.

# What does this do?

The Damned workshop allows users to do the following:

* Easily backup your game. Required if using the public test patch.
* Upgrade to the public test patch and downgrade to the retail game with ease. This is very useful to those who want to help use test our changes.
	- Public test patch files are found and removed when downgrading so they will not mess up your copy of the retail version of the game.

* Easily install brand NEW (not overwrite) stages into the game after you select all the stage related files.
* Easily remove a stage from the game.
* Easily set up a zip archive that can be shared to other people who will use the Damned Workshop to install your stage into the game.
* Easily install other peoples stages that are in a zip archive created by Damned Workshop in just a few clicks.

* And soon...

* Browse a repository where people can automatically upload their stages to through a Discord bot that sits in the uploaded-maps channel. All of these stages will be checked by the same same code that the Workshop uses.

# Why should I use this?

Because I built it to make our lives easier. There is a 99% chance that you will screw something up if you try to add/remove a stage into/from the game or even upgrading/downgrading with the public test patch.

If you really want to, you can try doing all of this by hand and then coming back to here when you become frustrated.

# How does this add in a new stage into the game?

This tool does the following to add in a new stage into the game:

1. It checks all of your selected files for the new stage and makes sure that the various checks pass. These include:
	- .stage file having the same inner name as the .stage file itself.
	- .scene file having at least 1 light spawn point.
	- .scene file having at least 7 spawn points. 
	- .scene file scene and stage section having the same name as the .scene file itself.	
	- .scene file and .stage file having the same name.
	- Loading image being 1920x1080
	- Stage selection image being 900x100 and being a .png file. This is the one that shows when you are selecting a stage.
	- Stage selected image being 300x100 and being a .png file. This is the one that shows in the lobby after you have selected a stage.

If at any time a check fails, a message box will pop up saying the check failed and give you a reason why.

2. It navigates into your stages directory within the Damned directory and copies your selected stage/scene files into the games stages directory.

3. It navigates into your GUI directory and begins sorting the stage_* images to match the new stage index for your new stage. It has to do this or things will get messed up in the game.

4. It copies the selected loading image into the the TerrorImages directoy and renames it into a format that the game looks for. If it did not do this, then you would not be able to have a custom loading screen.

5. It modifies the DamnedStages.xml file found in games GUI directory and creates a new XML file that is sorted to match all the damnedstages_ in your GUI directory.

5. It navigates to a zip archive called Terror.zip and extracts this to the users temporary directory. It goes through this temporary directory to open up a file called StageSelection.layout and modify it to match the new stage indexes.

6. It copies the modified Terror.zip and overwrites the old one found in the GUI directory.

And that's it. Doing all of this by hand requires its own guide. I wanted to automate the process so this is part of the reason why I wrote the Damned Workshop.

# How does this remove a stage from the game?

Same as adding in a new stage except it removes the stage and scene file and their assocated loading and lobby images instead.


# How can I help?

Simply use it and give suggestions. If you see an unhandled exception anywhere, ping me in the Discord and I'll fix it. I use the Damned Workshop myself so it's definately usable.

If you are interested in contributing code, let me know in the Discord. I would love to hear what you have in mind.


# FAQ

Q. I installed a new stage into the game but I don't see any images in the stage selection screen except the new one. Why?

A. It's because the retail game loads all of stage selection images from a single file in your GUI directory called DamnedStages.png. The DamnedStages.xml file looks for this specific png file.

Because of how this tool works, it renames all the stages in the DamnedStages.xml file to DamnedStages_<stageName> (example: DamnedStages_factory) instead. The game then tries to look for the associated png files
and cannot find it which causes the game to not display the image. The reason for doing this is because it makes a lot more sense. It's also a lot easier in the long run because when people are creating new stages, they will be creating
their own images, not extending the DamnedStages.png file. The images found in the DamnedStages.png file are not even sorted correctly.

You can do one of three things to fix this:

1. Create a backup of your game inside the patcher window then... (This is the best solution)

- Download ONLY the files that start with "DamnedStages_" from here:
	
	https://github.com/Sweats/Damned/tree/master/DamnedData/GUI

- Manually copy the downloaded images from where you saved them to to the GUI directory where you backed up your game. If you get a prompt that asks you to override one or more png files, hit yes.

- Relaunch the game. You should see all the stages now.

This is the best method because if you decide to try out the public test patch, the Damned Workshop will not delete these DamnedStages_.png files when you decide to downgrade back to the retail game.

2. Opt-in into the public test patch then install your new stages. This works because the public test patch already has these images included so it works out of the box. You may not want to stay on the public test patch because you won't be able to
play with other people who are not on the public test patch.

3. Wait for the next community update. These images will be included for sure.

Q. Can I install new stages then join random public lobbies?

A. No. This is because your stage indexes will be different from everyone else and you will load into a stage that the host did not select. Everyone needs to have the exact same stages/scene files in their stages directory.

This is very easy to do if everyone has the Damned Workshop.

# Issues

If there are any bugs in the program, please let me know in the coding-changes text channel in the Damned Discord. I have tested this so it should work fine.



# Screenshots


![Main Menu](https://github.com/Sweats/Damned-Workshop/blob/master/DamnedWorkshopMainMenu.png)

![Mapping Tools Menu](https://github.com/Sweats/Damned-Workshop/blob/master/DamnedMappingTool.png)

![Patcher Menu](https://github.com/Sweats/Damned-Workshop/blob/master/DamnedWorkshopPatcherMenu.png)

