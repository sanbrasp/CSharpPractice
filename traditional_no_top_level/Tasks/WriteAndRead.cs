using System;
using System.IO;
using traditional_no_top_level.Menu;

namespace traditional_no_top_level.Tasks;

/// <summary>
/// Class for practice task in file handling:
/// Creating file, writing content to it, reading said content
/// and displaying the content in the console.
/// </summary>
public class WriteAndRead : ITask
{
    public string Subject => "File Handling";
    public string Title => "Create, Write and Read";
    public string Description => "Create file, Write to it, Read contents.";
    public int Number => 1;
    
    /// <summary>
    /// Creates a file in root of project, writes to file, read is
    /// and outputs file contents in console.
    /// </summary>
    public void Run()
    {
        string writeText = "Hello World!"; // create text string
        File.WriteAllText("filename.txt", writeText); // Create a file and write to it

        string readText = File.ReadAllText("filename.txt"); // Read the file contents
        Console.WriteLine(readText); // Output the read content
    }
}