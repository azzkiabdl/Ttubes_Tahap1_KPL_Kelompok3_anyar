using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_Tahap1_KPL_kelompok3.Components
{
    public static class TableRenderer
    {
        public static void Render<T>(List<T> data, Dictionary<string, Func<T, string>> columns)
        {
            Console.WriteLine(string.Join(" | ", columns.Keys));

            foreach (var item in data)
            {
                var row = columns.Values.Select(selector => selector(item));
                Console.WriteLine(string.Join(" | ", row));
            }
        }
    }
}

