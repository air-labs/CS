using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S08
{
    public class Program
    {
        public static void Main()
        {
            var list = new List<Func<int, int>>();
            for (int i = 0; i < 10; i++)
                list.Add(z => z + i);

            foreach (var e in list)
                Console.WriteLine(e(0));

        }

    }
}