# Generate Visual Studio C++ Filters Extention

## About

Fork of https://github.com/BobbyAnguelov/GenerateFiltersExtension and updated for Visual Studio 2022:
- Adds support for vcxitems (shared items project)



Fork of https://github.com/Dllieu/VisualStudioCppExtensions and updated for Visual Studio 2019:
- **Generate C++ Project's Filters**
 - Simple Extension which provide the ability to generate C++ project filters to replicate the folder hierarchy of the underlying sources
 - It was originally made to browse easily C++ code hosted on a Linux machine while benefiting of the Visual Studio's features (e.g. GUI, Go to Definition / Declaration, Compile / Debug through SSH, ...)

<p align="center">
  <img src="usage_project_no_filter.png" alt="Project without filter"/>
  <img src="usage_project_generate_filter_result.png" alt="Project with filter replicating the folder hierarchy"/>
</p>

## Installation
- Download the ```*.vsix``` package from the **[latest release](https://github.com/marko98y432ghiwf98y93w4f098/generate-cpp-filters-----visual-studio-2022/releases/latest)**
- Double click on the downloaded package and follow the instructions

## Example Usage
Open an existing C++ solution

In the example below, I drag and dropped a folder into an empty C++ Project, all the files are imported but the whole project is *flat* as visual studio does not replicate the folder hierarchy of the files for C++ projects

<p align="center">
  <img src="usage_project_no_filter.png" alt="Project without filter"/>
</p>

Right click on the project for which you want to generate the filters per folder, a menu ```Generate C++ Project Filters``` will appear (*only appearing when right-clicking on a C++ project*)

<p align="center">
  <img src="usage_project_right_click.png" alt="Right click on the project"/>
</p>

Click on ```Generate C++ Project Filters```, a confirmation will be required to generate the filters

<p align="center">
  <img src="usage_project_generate_filter_confirmation.png" alt="Notification for confirmation"/>
</p>

Once the filters are generated, the extension will automatically reload the current project if needed. Accept the changes made by the extension by clicking yes

<p align="center">
  <img src="usage_project_generate_filter_save_change.png" alt="Save change made by Generate Filter"/>
</p>

As a result, your C++ project will have filters that replicate your C++ sources folder hierarchy

<p align="center">
  <img src="usage_project_generate_filter_result.png" alt="Result"/>
</p>

## Dependencies for developers
If you are interested in enhancing this extension, you must install Visual Studio 2022 SDK

### Debug
You have to change the debug settings for the VSIXProject to be able to debug it (```Properties -> Debug```)
- Start external program : ```C:\Program Files\Microsoft Visual Studio\2022\Preview\Common7\IDE\devenv.exe```
- Command line arguments: ```/rootsuffix EXP```
