using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_Tahap1_KPL_kelompok3.Configuration
{
    public class AppConfig
    {
        public int BatasPoinPeringatan { get; set; }
        public int BatasPoinPanggilanOrangTua { get; set; }
        public int BatasPoinSkorsing { get; set; }

        public bool NotifikasiEmailAktif { get; set; }
        public bool NotifikasiWhatsappAktif { get; set; }

        public string DefaultRoleUserBaru { get; set; }

        public AppConfig() { }

        public AppConfig(int batasPoinPeringatan, int batasPoinPanggilanOrangTua, int batasPoinSkorsing, bool notifEmail, bool notifWa, string defaultRole)
        {
            BatasPoinPeringatan = batasPoinPeringatan;
            BatasPoinPanggilanOrangTua = batasPoinPanggilanOrangTua;
            BatasPoinSkorsing = batasPoinSkorsing;
            NotifikasiEmailAktif = notifEmail;
            NotifikasiWhatsappAktif = notifWa;
            DefaultRoleUserBaru = defaultRole;
        }
    }
}
