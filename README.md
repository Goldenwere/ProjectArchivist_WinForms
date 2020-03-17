# Project Archivist

## About

Project Archivist is a Windows Forms application used for creating batch script files that execute [7-Zip add commands](https://sevenzip.osdn.jp/chm/cmdline/commands/add.htm) to create archives primarily for file backup purposes.

## Origin

Archivist stemmed from a need to re-write a batch file due to a folder re-structuring but a desire to avoid making edits manually and potentially making typos that may not be discovered until after the script is first executed. Rather than determining if such a thing exists, Archivist was created for practice in writing code that would end up being used for an actual recurring purpose.

## Roadmap

Currently, Archivist essentially "works" in that it does its intended purpose - creating a batch file based on form input.

### Missing Core Features
- Remove Button: Not yet implemented
- Input Validation: Restricts input via WinForms properties, but does not yet ensure input is actually entered where required; does not check for valid paths if user edits path after searching for one

### Missing Advanced Features
- Workable Settings File: In addition to .bat file creation, create a .xml file that the program can load for easy editing of a pre-existing .bat file

### Missing UX Features
- Global Application: The apply changes button works, but does not check for empty input in the password field; will research whether it would be better to only apply changed fields, or apply all (i.e. on one hand, ensures that if only one field is changed, pass only that field through; on the other hand, it will make user have to click on the default compression method in order to apply it)
- Themes: Implement dark/light theme; research whether Windows 10 system theme is exposed to WinForms or if restricted to UWP only
- Code Documentation: Not yet available (sorry, wanted to get the core of the program running before bed)
