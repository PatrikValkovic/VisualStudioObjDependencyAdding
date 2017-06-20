= Dependency adder for Visual C++

Add all .obj files as reference into another C++ project.

== Problem

When you want to use Unit tests for C++ project, you can reference only libraries.

Compiler needs to reference all files from tested project, but unit test project cannot reference executable file directly.
Instead that, we need to set reference to all generated object files.

This app automatically update project file (which is actually xml file) to contain additional reference.

== Usage

First at all, you need to set Source variable in `ObjFileAdding/MainMethod.cs` to set project, that should reference .obj files.

After that, you need compile the program and set is as Post-Build Event of referenced project
(Project properties - Configuration properties - Build events - Post-Build event).

Originally used with Visual Studio 2013. Program may need update if structure of project would change.

Another information are in [StackOverflow thread](https://stackoverflow.com/questions/26470392/include-obj-file-to-project-in-visual-studio-by-pragma-in-c).