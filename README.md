# FixPackageManagerSeeAllVersions
Allows viewing the button `See All Versions` in the Package Manager, which was hidden after Unity 2021 by design.

This is needed because updating packages sometimes introduces new bugs, requiring to go back to a previous version. Without this button, such task must be done manually by editing the `Packages/manifest.json` file.

# How to use
Drag and drop the folder `FixPackageManagerSeeAllVersions` anywhere in the Assets folder of your Unity project.

Open the package manager, click on the cog button next to the search toolbar, click `Advanced Project Settings` and toggle on `See All Versions`

![Image showing the feature](img.png)


It makes use of https://github.com/pardeike/Harmony to patch Unity.

Note: If you are already using Harmony for something else, make sure only one copy of the 0harmony.dll exists. Just remove all but one of them and that should be enough.
