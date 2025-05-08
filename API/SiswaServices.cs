using System;
using System.Collections.Generic;

namespace Tubes_Tahap1_KPL_kelompok3
{
    public class Siswa
    {
        public string Nama { get; set; }
        public string Kelas { get; set; }
        public string NomorInduk { get; set; }
    }

    public class SiswaService
    {
        private List<Siswa> daftarSiswa = new List<Siswa>();

        public void TambahSiswa(string nama, string kelas, string nomorInduk)
        {
            Siswa siswaBaru = new Siswa
            {
                Nama = nama,
                Kelas = kelas,
                NomorInduk = nomorInduk
            };
            daftarSiswa.Add(siswaBaru);
        }

        public List<Siswa> GetSemuaSiswa()
        {
            return daftarSiswa;
        }

        public Siswa CariSiswa(string nomorInduk)
        {
            return daftarSiswa.Find(s => s.NomorInduk == nomorInduk);
        }
    }
}
