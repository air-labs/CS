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
        
        public FileInfo ProjectFile;
        public bool IsProject { get { return ProjectFile!=null; } }

        public string ProperName;
        public bool HasProperName { get { return ProperName != null; } }

        public List<SlnItem> Items = new List<SlnItem>();


    }
}
