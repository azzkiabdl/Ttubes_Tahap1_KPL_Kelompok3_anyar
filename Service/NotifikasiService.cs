using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tubes_Tahap1_KPL_kelompok3.Model;

namespace Tubes_Tahap1_KPL_kelompok3.Service
{
    public class NotifikasiService
    {
        public void KirimNotifikasi(string pesan, Pengguna penerima)
        {
            Console.WriteLine($"[NOTIFIKASI] Kepada {penerima.Username}: {pesan}");
            // Implementasi sebenarnya: Email, FCM, WhatsApp API
        }
    }

}
