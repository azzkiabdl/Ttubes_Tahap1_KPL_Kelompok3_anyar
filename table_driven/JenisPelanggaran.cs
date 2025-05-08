using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_Tahap1_KPL_kelompok3.table_driven
{
    public class JenisPelanggaran
    {
        public string Nama { get; set; }
        public LevelPelanggaran Level { get; set; }
        public int Poin { get; set; }

        public JenisPelanggaran(string nama, LevelPelanggaran level, int poin)
        {
            Nama = nama;
            Level = level;
            Poin = poin;
        }
    }
}
