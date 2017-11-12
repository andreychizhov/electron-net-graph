# electron-net-graph

A graph visualizer built on top of [Electron.NET](https://github.com/ElectronNET/Electron.NET) project with awesome [vis.js](http://visjs.org/) library.

You'll need to ensure you have the [.NET Core 2.0 SDK](https://www.microsoft.com/net/core) installed before launching this app.

For launching an app please do the following:

* First restore nuget packages with `nuget restore` command.
* Execute `dotnet electronize start` command from dotnet CLI.

Also for building a graph you'll need a input data. Inpit is a simple text file with set of Nodes and its dependencies. For example:

```
DependentNode1 <-- DependenceNode1
DependentNode1 <-- DependenceNode2
DependentNode2 <-- DependenceNode3
...
```