using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_Tahap1_KPL_kelompok3.Components
{
    public static class FormBuilder
    {
        public static void TampilkanForm<T>(Dictionary<string, Func<T, string>> fieldGenerators, T data)
        {
            foreach (var field in fieldGenerators)
            {
                string label = field.Key;
                string value = field.Value.Invoke(data);

                Console.WriteLine($"{label}: {value}");
            }
        }
    }
}

