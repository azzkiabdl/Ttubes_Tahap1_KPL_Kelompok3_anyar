using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_Tahap1_KPL_kelompok3.Utils
{
    internal class Formatter
    {
        public static string FormatTanggal(DateTime tanggal) => tanggal.ToString("dd MMM yyyy");
    }
}
