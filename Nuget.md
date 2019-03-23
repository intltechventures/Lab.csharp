
Nuget Resources
====

### Dotnet CLI
* ```dotnet add package <package_name>```
* https://docs.microsoft.com/en-us/nuget/quickstart/install-and-use-a-package-using-the-dotnet-cli
  * "Packages are installed into a .NET Core project using the dotnet add package command"
  * "The .NET Core SDK...provides the dotnet command-line tool"

### Resources
* https://www.nuget.org/
  * https://www.nuget.org/downloads
    * "NuGet Package Manager 4.x (PM UI and PM Console) are included with Visual Studio 2017 (all 15.x versions). Latest NuGet releases are delivered as part of Visual Studio updates."
    * "Note: ```nuget.exe``` itself is not included with any version of Visual Studio."
  * https://blog.nuget.org/


### Documentation
* https://docs.microsoft.com/en-us/nuget/
  * https://docs.microsoft.com/en-us/nuget/what-is-nuget
    * "For .NET (including .NET Core), the Microsoft-supported mechanism for sharing code is NuGet, which defines how packages for .NET are created, hosted, and consumed, and provides the tools for each of those roles."
    * "A NuGet package is a single ZIP file with the .nupkg extension that contains compiled code (DLLs), other files related to that code, and a descriptive manifest that includes information like the package's version number."

* https://docs.microsoft.com/en-us/nuget/quickstart/
  * https://docs.microsoft.com/en-us/nuget/consume-packages/configuring-nuget-behavior
    * "NuGet's behavior is driven by the accumulated settings in one or more NuGet.Config (XML) files that can exist at project-, user-, and computer-wide levels. A global NuGetDefaults.Config file also specifically configures package sources. Settings apply to all commands issued in the CLI, the Package Manager Console, and the Package Manager UI."
    * "Settings are managed using the NuGet CLI config command:"
      * "By default, changes are made to the user-level config file."
      * "To change settings in a different file, use the -configFile switch. In this case files can use any filename."
      * "Keys are always case sensitive."
      * "Elevation is required to change settings in the computer-level settings file."
  * https://docs.microsoft.com/en-us/nuget/consume-packages/overview-and-workflow
  * https://docs.microsoft.com/en-us/nuget/consume-packages/ways-to-install-a-package
  * https://docs.microsoft.com/en-us/nuget/quickstart/install-and-use-a-package-in-visual-studio
  * https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package-using-the-dotnet-cli

* Install command (NuGet CLI)
  * https://docs.microsoft.com/en-us/nuget/tools/cli-ref-install

* Installing NuGet client tools
  * https://docs.microsoft.com/en-us/nuget/install-nuget-client-tools
    * "To work with NuGet, as a package consumer or creator, you can use command-line interface (CLI) tools as well as NuGet features in Visual Studio."

