using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmonizer
{
    public class Renamer
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

        static string SlnFileName;
        static string TargetRoot=".\\Temp\\";
        static string SourceRoot;

        static void CrateSubdirectories(SlnItem item)
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

        static void MoveFiles(DirectoryInfo sourceDirectory, DirectoryInfo targetDirectory)
        {
            foreach (var file in sourceDirectory.GetFiles())
                file.CopyTo(targetDirectory.FullName + "\\" + file.Name);
            foreach (var subdir in sourceDirectory.GetDirectories())
            {
                var dstDir = targetDirectory.CreateSubdirectory(subdir.Name);
                MoveFiles(subdir, dstDir);
            }
        }

        static void CopyProjects(SlnItem root)
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
        
        /// <summary>
        /// Переименовывает файловую структуру проекта в соответствии с логической структурой sln-файла
        /// 
        /// Предполагается, что Solution состоит из папок и проектов. Некоторые из папок/проектов верхнего уровня являются
        /// "особенными", и они никуда перемещены не будут. Все неособенные проекты должны физически находится внутри той же папки, где лежит solution
        /// </summary>
        /// <param name="solutionFileName">Полный путь до solution-файла</param>
        /// <param name="specialProjectNames">Список имен папок/проектов верхнего уровня, которые являются особенными</param>
        /// <param name="levelNames">Имена уровней (модуль, лекция, тема, часть и т.д.)</param>
        public static void Rename(string solutionFileName, string[] specialProjectNames, string[] levelNames)
        {
            Names = levelNames;
            Func<SlnItem, bool> selector = z => !specialProjectNames.Contains(z.FullName);
            SlnFileName = solutionFileName;

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
