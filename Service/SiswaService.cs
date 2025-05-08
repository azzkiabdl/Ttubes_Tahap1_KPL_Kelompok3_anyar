using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tubes_Tahap1_KPL_kelompok3.Model;

namespace Tubes_Tahap1_KPL_kelompok3.Service
{
    public class SiswaService
    {
        private List<Siswa> _daftarSiswa = new();

        public void TambahSiswa(Siswa siswa) => _daftarSiswa.Add(siswa);

        public Siswa? CariSiswa(int id) => _daftarSiswa.FirstOrDefault(s => s.Id == id);

        public List<Siswa> GetSemua()
        {
            return _daftarSiswa;
        }

    }
}
