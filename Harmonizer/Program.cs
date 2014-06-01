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

        class SlnItemComparer : Comparer<SlnItem>
        {

            public override int Compare(SlnItem x, SlnItem y)
            {
                return x.FullName.CompareTo(y.FullName);
            }
        }

        static void Assign(SlnItem item)
        {
            item.Items.Sort(new SlnItemComparer());
            for (int i = 0; i < item.Items.Count; i++)
            {
                var e = item.Items[i];
                
                e.Depth = item.Depth + 1;

                if (e.HasProperName)
                    e.TargetName = string.Format("{0} {1:D2} - {2}", Names[item.Depth], i+1, e.ProperName);
                else
                    e.TargetName = e.FullName;

                e.TargetFolder = item.TargetFolder + e.TargetName +"\\";

                if (e.IsProject)
                    e.TargetProjectFilePath = e.TargetFolder + e.TargetName + ".csproj";

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
        static string TargetRoot=".\\Temp\\";
        static string SourceRoot;

        public static void CrateSubdirectories(SlnItem item)
        {
            try
            {
                Directory.Delete(TargetRoot, true);
            }
            catch { }
            
            Directory.CreateDirectory(TargetRoot);
            foreach (var e in item.Traversal)
                Directory.CreateDirectory(TargetRoot + e.TargetFolder);
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
                    new DirectoryInfo(SourceRoot+e.InitialProjectFolder),
                    new DirectoryInfo(TargetRoot + e.TargetFolder));
                if (e.HasProperName)
                    File.Move(TargetRoot + e.TargetFolder + e.InitialProjectFileName, TargetRoot + e.TargetProjectFilePath);
            }
        }

        static void DeleteOldSubdirectories(SlnItem root)
        {
            foreach (var e in root.Traversal)
            {
                if (!e.IsProject) continue;
                Directory.Delete(Path.Combine(SourceRoot,e.InitialProjectFolder),true);
            }
        }

        static void AssignUntouched(IEnumerable<SlnItem> items)
        {
            foreach (var e in items.Traversal())
            {
                e.TargetName = e.FullName;
                e.TargetProjectFilePath = e.InitialProjectFilePath;
            }

        }
        

        public static void Main()
        {
            Func<SlnItem, bool> selector = z => z.FullName != "Common";


            var file = new FileInfo(SlnFileName);
            SourceRoot = file.Directory.FullName+"\\";
            var items = SlnFileReader.ReadProjects(file.FullName);

            var root = new SlnItem { Depth = 0, TargetFolder="" };
            root.Items.AddRange(items.Where(selector));
            
            Assign(root);
            CrateSubdirectories(root);
            CopyProjects(root);

            AssignUntouched(items.Where(z => !selector(z)));

            SlnFileReader.WriteSlnFile(Path.Combine(TargetRoot, file.Name), items);

           DeleteOldSubdirectories(root);
            file.Delete();
            MoveFiles(new DirectoryInfo(TargetRoot), new DirectoryInfo(SourceRoot));

            
        }
    }
}
