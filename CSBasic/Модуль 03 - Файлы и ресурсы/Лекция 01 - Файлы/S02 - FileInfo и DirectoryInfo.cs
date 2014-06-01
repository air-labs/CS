using System.IO;
using System;
class L1S02
{
    public static void MainX()
    {
        var dir = new DirectoryInfo("Temp");
        var subdir = dir.CreateSubdirectory("Subdirectory");
        var dirs = dir.GetDirectories();
        foreach (var e in dirs)
            Console.WriteLine(e.FullName);
    
        var files = dir.GetFiles();
        foreach (var e in files)
            Console.WriteLine("{0,10}  {1}", e.Name, e.CreationTime);


    }
}