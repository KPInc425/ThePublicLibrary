<h1>Nuget Package (and /bin /obj folder) Hard Drive Cleanup</h1>
<sub>
If you look up one day and find you have dozens, perhaps hundreds of various projects laying around your hard drive, this can help clean up "temporary" files and free up space. 
</sub>

<h3>How to most easily get the latest executables</h3>  
* <a href="https://github.com/10GeekJames/NugetPackageHardDriveCleanup/tree/main/Runnables/NodePackageHarddriveCleanup.zip">MigrationsReInit.zip</a>
*<small>The first time you run the common "Windows protected your PC", don't run screen will appear, click "More Info" and you can select to run.</small>

<h3>How to use</h3>

- <a href="https://www.youtube.com/watch?v=lINBfjUHTrM" target="_blank">Quick Video Tour (3-min)</a>

The .exe will look up one folder and begin to scan from there down.
During the scan the system will show you all of the folders it finds and the size those folders take up on disk.
Once completed the system will prompt you to provide a very specific 'Y' answer to go ahead and delete all of the folders it has found/listed.
```
Input:
 None: The .exe will climb up 1 folder from where it is to begin its scans for /obj/debug /obj/release and clientapp/node_modules folders
 
Output:
 You will see the scan results on screen and have an opportunity to cancel before any actual deleting occurs
 All the mentioned folders, their respective sub-folders and content will be deleted from the drive
```