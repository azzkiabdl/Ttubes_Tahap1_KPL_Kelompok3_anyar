using System;
using System.Collections.Generic;

namespace Tubes_Tahap1_KPL_kelompok3
{
    public class Pelanggaran
    {
        public string NamaSiswa { get; set; }
        public string JenisPelanggaran { get; set; }
        public int Poin { get; set; }
        public DateTime Tanggal { get; set; }
        public string Status { get; set; } 
    }

    public class PelanggaranService
    {
        private List<Pelanggaran> daftarPelanggaran = new List<Pelanggaran>();

        public void TambahPelanggaran(string namaSiswa, string jenisPelanggaran, int poin)
        {
            Pelanggaran pelanggaranBaru = new Pelanggaran
            {
                NamaSiswa = namaSiswa,
                JenisPelanggaran = jenisPelanggaran,
                Poin = poin,
                Tanggal = DateTime.Now,
                Status = "Belum Ditindak"
            };
            daftarPelanggaran.Add(pelanggaranBaru);
        }

        public void UbahStatusPelanggaran(int index, string statusBaru)
        {
            if (index >= 0 && index < daftarPelanggaran.Count)
            {
                daftarPelanggaran[index].Status = statusBaru;
            }
        }

        public List<Pelanggaran> GetSemuaPelanggaran()
        {
            return daftarPelanggaran;
        }
    }
}
