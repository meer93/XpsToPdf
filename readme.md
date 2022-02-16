# XPS to PDF - .NET 6 (Windows/WPF) Console App

## Dependencies
- NuGet - [kenjiuno.PdfSharp.Xps](https://github.com/HiraokaHyperTools/PDFsharp)

## Pre-requisites
- Windows Machine
- Install [.NET 6](https://dotnet.microsoft.com/en-us/download)

## Steps
1. Place the xps file in the same folder as the console app, named as 'xpsFile' or specify the path of the xps file in `Program.cs` line number 1 (without file extension).
2. In the terminal/cmd: Build the console app - `dotnet build`
3. Run the console app - `dotnet run`
4. PDF file will be generated in the folder where the xps file is passed in step 1, with same file name.
