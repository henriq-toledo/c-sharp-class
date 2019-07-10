- Visual Studio Code installing and configuring the C# extension
	- Installing .NET Core SDK
		- https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.300-windows-x64-installer
    - Downloading the Visual Studio Code
        - https://code.visualstudio.com/Download
    - Install the C# extension: C# for Visual Studio Code (powered by OmniSharp)
    - Install the extension: vscode-nuget-package-manager (NuGet Package Manager powered by jmrog)
    - Install the extension: C# XML Documentation Comments (powered by Keisuke Kato)
    - Install the extension: C# Code Snippets (powered by Somejack)

- Shortcuts
    - Ctrl+Shift+D: Debug
    - Ctrl+Shift+F: Code indentation
    - Ctrl+Shift+P: Open the show all commands, it is usefull to install nuget packages
    - ///: Comments
    - Keyboard shortcuts for windows
        - https://code.visualstudio.com/shortcuts/keyboard-shortcuts-windows.pdf

Steps to create the solution
- Create the folder CSharpClass
- Open the folder local
- Run the "dotnet new sln" command
    - This command creates the solution file
- Create the project folder ClassNumber01_Types
- Open the project folder
- Run the "dotnet new console" command
    - This command creates the console application
- Return to the CSharpClass folder
- Run the "dotnet sln .\CSharpClass.sln add .\ClassNumber01_Types\ClassNumber01_Types.csproj" command
    - This command attach the project to the solution