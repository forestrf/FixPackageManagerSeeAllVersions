# FixPackageManagerSeeAllVersions
Allows viewing the button `See All Versions` in the Package Manager, which was hidden after Unity 2021 by design.

This is needed because updating packages sometimes introduces new bugs, requiring to go back to a previous version. Without this button, such task must be done manually by editing the `Packages/manifest.json` file.

Just drag and drop the folder `FixPackageManagerSeeAllVersions` anywhere in the Assets folder of your Unity project.

It makes use of https://github.com/pardeike/Harmony to patch Unity.

Note: If you are already using harmoney for something else, make sure only one copy of the 0harmony.dll exists. Just remove all but one of them and that should be enough.

![Image showing the feature](img.png)
