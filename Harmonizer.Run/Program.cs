using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmonizer.Run
{
    class Program
    {
        static void Main(string[] args)
        {
            Harmonizer.Renamer.Rename(
                "..\\..\\..\\CSBasic\\CS.sln",
                new string[] { "Common" },
                new string[] { "Модуль", "Лекция" });
        }
    }
}
