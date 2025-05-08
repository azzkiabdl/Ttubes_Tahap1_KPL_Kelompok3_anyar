using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoinSiswa.Library.Model
{
    public class Pelanggaran
    {
        public int Id { get; set; }
        public int SiswaId { get; set; }
        public string Jenis { get; set; }
        public int Poin { get; set; }
        public DateTime Tanggal { get; set; }
        public StatusPelanggaran Status { get; set; }
    }
}
