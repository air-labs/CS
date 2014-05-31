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
                result.ProjectFile = new FileInfo(match.Groups[3].Value);
            }
            result.FullName = match.Groups[2].Value;

            regex = new Regex("[^-]* - (.*)");
            match = regex.Match(result.FullName);
            if (match.Success)
                result.ProperName = match.Groups[1].Value;

            return result;
        }
    }
}
