# electron-net-graph

A graph visualizer built on top of [Electron.NET](https://github.com/ElectronNET/Electron.NET) project with awesome [vis.js](http://visjs.org/) library.

For launching an app please do the following:

* First restore nuget packages with `nuget restore` command.
* Execute `dotnet electronize start` command from dotnet CLI.

Also for building a graph you'll need a input data. Inpit is a simple text file with set of fields and its dependencies. For example:

Field1 <-- DependentField1
Field1 <-- DependentField2
Field2 <-- DependentField3
...