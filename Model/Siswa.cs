using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_Tahap1_KPL_kelompok3.Model
{
    public class Siswa
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Kelas { get; set; }
        public int TotalPoin { get; set; }
        public List<Pelanggaran> RiwayatPelanggaran { get; set; } = new();
    }
}
