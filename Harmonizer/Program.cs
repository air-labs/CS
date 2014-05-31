using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmonizer
{
    class Program
    {

        static string[] Names = new string[] { "Модуль", "Лекция" };

        static void Assign(SlnItem item)
        {
           

            for (int i = 0; i < item.Items.Count; i++)
            {
                var e = item.Items[i];
                
                e.Depth = item.Depth + 1;

                if (e.HasProperName)
                    e.TargetName = string.Format("{0} {1:D2} - {2}", Names[item.Depth], i+1, e.ProperName);
                else
                    e.TargetName = e.FullName;

                e.TargetPath = item.TargetPath + "\\" + e.TargetName;

                if (e.IsProject)
                    e.TargetProjectFileName = e.TargetPath + "\\" + e.TargetName + ".csproj";

                Assign(e);
            }
        }

        static void Print(SlnItem item, Func<SlnItem, object> what)
        {
            foreach (var e in item.Traversal)
            {
                for (int i = 0; i < e.Depth; i++)
                    Console.Write("   ");
                Console.WriteLine(what(e));
            }
        }

        static string SlnFileName = "..\\..\\..\\CSBasic\\CS.sln";
        static string RootFolder=".\\Temp";
        static string SlnFolder;

        public static void CrateSubdirectories(SlnItem item)
        {
            try
            {
                Directory.Delete(RootFolder, true);
            }
            catch { }
            
            Directory.CreateDirectory(RootFolder);
            foreach (var e in item.Traversal)
                Directory.CreateDirectory(RootFolder + e.TargetPath);
        }

        public static void MoveFiles(DirectoryInfo sourceDirectory, DirectoryInfo targetDirectory)
        {
            foreach (var file in sourceDirectory.GetFiles())
                file.CopyTo(targetDirectory.FullName + "\\" + file.Name);
            foreach (var subdir in sourceDirectory.GetDirectories())
            {
                var dstDir = targetDirectory.CreateSubdirectory(subdir.Name);
                MoveFiles(subdir, dstDir);
            }
        }

        public static void CopyProjects(SlnItem root)
        {
            foreach (var e in root.Traversal)
            {
                if (!e.IsProject) continue;
                MoveFiles(
                    new DirectoryInfo(SlnFolder+e.InitialProjectFolder),
                    new DirectoryInfo(RootFolder + e.TargetPath));
            }
        }
        

        public static void Main()
        {
            var file = new FileInfo(SlnFileName);
            SlnFolder = file.Directory.FullName+"\\";
            var items = SlnFileReader.ReadProjects(file.FullName);

            var root = new SlnItem { Depth = 0, TargetPath="" };
            root.Items.AddRange(items.Where(z=>z.FullName!="Common"));
            
            Assign(root);
            CrateSubdirectories(root);
            CopyProjects(root);

            SlnFileReader.WriteSlnFile(SlnFolder + file.Name, root);
        }
    }
}
