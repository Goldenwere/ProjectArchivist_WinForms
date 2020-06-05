# Project Archivist

## About

Project Archivist is a Windows Forms application used for creating batch script files that execute [7-Zip add commands](https://sevenzip.osdn.jp/chm/cmdline/commands/add.htm) to create archives primarily for file backup purposes.

## Origin

Archivist stemmed from a need to re-write a batch file due to a folder re-structuring but a desire to avoid making edits manually and potentially making typos that may not be discovered until after the script is first executed. Rather than determining if such a thing exists, Archivist was created for practice in writing code that would end up being used for an actual recurring purpose. Archivist was also an attempt to create a fully functional, purposeful program in under 24 hours. This attempt was successful: development started 2020/03/16 7:30pm EST, and the first viable commit, [1523dbd](../../commit/1523dbdedc91d1c9fe10347486e9b8f4f57d22a4), was made 2020/03/17 6:19pm EST*. 
\*Actual time spent:  
7:30p-1:00a (5.5hr)  
1:05p-1:35p (0.5hr)  
2:00p-4:00p (2hr)  
4:30p-5:30p (1hr)  
5:45p-6:19p (~0.5hr)  
Total: ~9.5hrs  

## Roadmap

Currently, Archivist essentially "works" in that it does its intended purpose - creating a batch file based on form input. It also handles numerous error situations. Archivist using Windows Forms is no longer actively worked on. Instead, see [the Electron version of the program](https://github.com/Goldenwere/ProjectArchivist_Electron) for a more updated application.

### Originally Intended Features
These were some ideas had during development that are instead now intended for the Electron version of the program:  
- Workable Settings File: In addition to .bat file creation, create a .xml file that the program can load for easy editing of a pre-existing .bat file
- Themes: Implement dark/light theme; research whether Windows 10 system theme is exposed to WinForms or if restricted to UWP only
