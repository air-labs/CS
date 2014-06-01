using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Harmonizer
{
    public class SlnFileReader
    {
        public static SlnItem ParseProjectInfo(string str)
        {
            var regex = new Regex(@"Project\(""\{([^\}]*)\}""\) = ""([^""]*)"", ""([^""]*)"", ""\{([^\}]*)\}""");
            var match = regex.Match(str);
            var result = new SlnItem();
            result.Guid = match.Groups[4].Value;
            if (match.Groups[3].Value.EndsWith(".csproj"))
            {
                result.InitialProjectFilePath = match.Groups[3].Value;
                result.InitialProjectFolder = result.InitialProjectFilePath.Substring(0, result.InitialProjectFilePath.LastIndexOf("\\"));
                result.InitialProjectFileName = result.InitialProjectFilePath.Substring(result.InitialProjectFolder.Length+1, result.InitialProjectFilePath.Length - result.InitialProjectFolder.Length-1);
            }
            result.FullName = match.Groups[2].Value;
            result.ProjectTypeGuid = match.Groups[1].Value;
            regex = new Regex("[^-]* - (.*)");
            match = regex.Match(result.FullName);
            if (match.Success)
                result.ProperName = match.Groups[1].Value;

            return result;
        }

       public static  Tuple<string, string> ParseConnection(string str)
        {
            var regex = new Regex(@"\{([^\}]*)\} = \{([^\}]*)\}");
            var match = regex.Match(str);
            if (!match.Success) return null;
            return Tuple.Create(match.Groups[1].Value, match.Groups[2].Value);

        }


       public static void WriteSlnFile(string filename, List<SlnItem> root)
       {
           using (var writer = new StreamWriter(filename,false,Encoding.UTF8))
           {
               writer.WriteLine(@"               
Microsoft Visual Studio Solution File, Format Version 12.00
# Visual Studio 2012");



               foreach (var e in root.Traversal())
               {
                   writer.WriteLine(@"Project(""{{{0}}}"") = ""{1}"", ""{2}"", ""{{{3}}}""
EndProject",
           e.ProjectTypeGuid,
           e.TargetName,
           e.TargetProjectFilePath ?? e.TargetName,
           e.Guid);
               }

               writer.WriteLine(@"
Global
	GlobalSection(SolutionConfigurationPlatforms) = preSolution
		Debug|Any CPU = Debug|Any CPU
		Debug|Mixed Platforms = Debug|Mixed Platforms
		Debug|x86 = Debug|x86
		Release|Any CPU = Release|Any CPU
		Release|Mixed Platforms = Release|Mixed Platforms
		Release|x86 = Release|x86
	EndGlobalSection
    GlobalSection(SolutionProperties) = preSolution
		HideSolutionNode = FALSE
	EndGlobalSection");

               writer.WriteLine(@"
    GlobalSection(NestedProjects) = preSolution");

               foreach (var e in root.Traversal())
                   foreach (var m in e.Items)
                       writer.WriteLine("\t\t\t{{{0}}} = {{{1}}}", m.Guid, e.Guid);

               writer.WriteLine(@"EndGlobalSection
EndGlobal");



           }

       }

        public static List<SlnItem> ReadProjects(string fileName)
        {
            var allProjects=new List<SlnItem>();
            var connections = new List<Tuple<string, string>>();
            bool inNestedSection=false;
            foreach (var e in File.ReadLines(fileName))
            {
                if (e.StartsWith("Project"))
                {
                    allProjects.Add(ParseProjectInfo(e));
                    continue;
                }
                if (e.Contains("GlobalSection(NestedProjects)"))
                {
                    inNestedSection = true;
                    continue;
                }
                if (inNestedSection)
                {
                    if (e.Contains("EndGlobalSection"))
                    {
                        inNestedSection = false;
                        continue;
                    }
                    var c = ParseConnection(e);
                    if (c != null) connections.Add(c);
                    continue;
                }

            }

            var rootProjects = allProjects.ToList();
            foreach (var e in connections)
            {
                var child=allProjects.FirstOrDefault(z=>z.Guid==e.Item1);
                allProjects.First(z => z.Guid == e.Item2).Items.Add(child);
                rootProjects.Remove(child);
            }
            return rootProjects;
        }
    }
}
