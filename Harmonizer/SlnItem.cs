using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmonizer
{
    public class SlnItem
    {
        public string Guid;
        public string FullName;
        public string ProjectTypeGuid;
        
        public string InitialProjectFilePath;
        public bool IsProject { get { return InitialProjectFilePath!=null; } }
        public string InitialProjectFolder;
        public string InitialProjectFileName;

        public string ProperName;
        public bool HasProperName { get { return ProperName != null; } }

        public string TargetName;
        public string TargetPath;
        public string TargetProjectFileName;
        public int Depth;

        public List<SlnItem> Items = new List<SlnItem>();

        public IEnumerable<SlnItem> Traversal
        {
            get
            {
                yield return this;
                foreach (var e in Items)
                    foreach (var c in e.Traversal)
                        yield return c;
            }
        }
    }
}
