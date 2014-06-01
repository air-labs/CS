using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmonizer
{
    public class SlnData
    {
        public FileInfo SourceSlnFile;
        public FileInfo TargetSlnFile;

        public SlnItem RegularItems = new SlnItem();

        public SlnItem AuxiliaryItems = new SlnItem();
        
    }
}
