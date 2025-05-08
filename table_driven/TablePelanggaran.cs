using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_Tahap1_KPL_kelompok3.table_driven
{
    public static class TabelPelanggaran
    {
        public static readonly Dictionary<string, JenisPelanggaran> Daftar = new Dictionary<string, JenisPelanggaran>
        {
            { "Tidak Membawa Buku", new JenisPelanggaran("Tidak Membawa Buku", LevelPelanggaran.RINGAN, 5) },
            { "Terlambat Masuk", new JenisPelanggaran("Terlambat Masuk", LevelPelanggaran.SEDANG, 10) },
            { "Merokok", new JenisPelanggaran("Merokok", LevelPelanggaran.BERAT, 20) }
        };

        // Pencarian lebih cepat dengan Dictionary
        public static int GetPoin(string nama)
        {
            if (string.IsNullOrWhiteSpace(nama))
            {
                throw new ArgumentException("Nama pelanggaran tidak boleh kosong atau null.");
            }

            if (!Daftar.ContainsKey(nama))
            {
                throw new KeyNotFoundException($"Pelanggaran '{nama}' tidak ditemukan.");
            }

            return Daftar[nama].Poin;
        }
    }
}
