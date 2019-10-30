# C# Class

## Table of contents
1. [Visual Studio Code installing and configuring the C# extension](#visualStudioCodeInstall)
2. [Steps to create the solution](#steps)
3. [C# Topics](#topics)
4. [Git Commands](#gitCommands)
5. [vi Text Editor Commands](#viCommands)

## Visual Studio Code installing and configuring the C# extension <a name="visualStudioCodeInstall"/>

- Installing .NET Core SDK
	- https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.300-windows-x64-installer
- Downloading the Visual Studio Code
    - https://code.visualstudio.com/Download
- Install the C# extension: C# for Visual Studio Code (powered by OmniSharp)
- Install the extension: vscode-nuget-package-manager (NuGet Package Manager powered by jmrog)
- Install the extension: C# XML Documentation Comments (powered by Keisuke Kato)
- Install the extension: C# Extensions (powered by jchannon)
- Install the Git: https://git-scm.com/download/win

- Shortcuts
    - Ctrl+Shift+D: Debug
    - Ctrl+Shift+F: Code indentation
    - Ctrl+Shift+P: Open the show all commands, it is usefull to install nuget packages
    - ///: Comments
    - Keyboard shortcuts for windows
        - https://code.visualstudio.com/shortcuts/keyboard-shortcuts-windows.pdf

## Steps to create the solution <a name="steps"/>

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
- Adding a project reference
	- https://docs.microsoft.com/pt-br/dotnet/core/tools/dotnet-add-reference
	- Examples: 
		- <code>C:\Repositories\GitHub\c-sharp-class\src\CSharpClass\ClassNumber06_OOP> dotnet add reference ..\ClassNumber05_OOP\ClassNumber05_OOP.csproj</code>

		or

		- <code>C:\Repositories\GitHub\c-sharp-class\src\CSharpClass> dotnet add .\ClassNumber06_OOP\ClassNumber06_OOP.csproj  reference .\ClassNumber05_OOP\ClassNumber05_OOP.csproj</code>
	
## C# Topics <a name ="topics"/>

- Compiled and interpreted languages and Dynamic Link Libraries
- Console application
	- Program class, Main method and args
		- Namespace, class and method scope
		- using namespaces
		- using #region and #endregion
	- Console.ReadLine
	- Console.WriteLine
- Types
	- int or Int32
	- string or String
	- long or Int64
	- boolean
	- decimal or Decimal
	- double or Double
	- byte
	- char or Char
	- Guid
	- Casting 
		- Explicit and implicit
	- Converters
		- Parse methods
		- Converter class
	- Arrays
- String
	- string format
	- StringBuilder
- Keywords
	- checked (curiosity)
	- var
	- const
	- readonly
- Managing Program Flow 
	- If, else if and else
	- Ternary operator
	- Switch 
	- Loops
		- for
		- while
		- do while
		- foreach
		- keywords
			- break
			- continue
			- goto
- Object Oriented Programming
	- Constructor
	- Properties
	- Destructor
	- Inheritance
	- Overload
	- Override and virtual 
	- Modifiers
		- public
		- private
		- protected 		
		- abstract		
		- internal
		- static
		- partial
- Ref and out parameters (next)
- Interfaces
	- IComparable and IComparer
	- IEquatable
		- GetHashCode method
		- Equals method
	- IEqualityComparer
	- IDisposable
		- using keyword
		- Garbage Collector
- Enums
- Collections
	- List
	- Dictionary
	- ArrayList
	- HashSet
	- HashTable
	- Stack
	- Queue
	- SortedList
- Linq 
	- join
	- order by ascending and descending
	- group by
	- let keyword
	- Anonymous
	- Parallel Linq
		- ForAll method
	- Linq to Xml
- Lambda
	- GroupBy
	- Sum
	- Average
	- Max and Min
	- Join
	- Where
	- Skip
	- Take
	- Intersect
	- Except
	- DefaultIfEmpty
		- FirstOrDefault
		- SingleOrDefault
	- ForEach method
	- OrderBy And OrderByDescending
- IO
	- StreamReader
	- StreamWriter
	- StringReader
	- StringWriter
	- Path
	- File
	- DirectoryInfo
	- FileInfo
- Exceptions
	- try
	- catch
	- finally
- Serialization and Deserialization
	- XML
	- JSON
- Extension methods
- Delegates and events	
	- Actions 
	- Functions
- Multithreading
	- Task
	- Async methods
- Generics
- Reflection
- ORM
	- EntityFramework
		- Code First
		- Migration
		- Attributes
- AppSettings.json	
- Tests
	- Arrange Act Assert
	- Unit Test
		- Assert class
	- Test Automation
		- Selenium Web Driver (Web)
		
## Git Commands <a name="gitCommands"/>

- git init
- git config --list
- git config user.name "My User Name"
- git config user.email myemail@mail.com
- git status
- git add \<file or folder>
- git add .
- git rm --cache \<file>
- git log
- git log --oneline
- git commit -m "Your commit message"

## vi Text Editor Commands <a name="viCommands"/>

- <code>i</code> - insert the text
- <code>esc</code> - to exit from the text 
- <code>wq</code> - to write the file and exit from the vi