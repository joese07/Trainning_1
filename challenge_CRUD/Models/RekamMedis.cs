using System;
namespace challenge_CRUD.Models
{
    public class RekamMedis
    {
        public RekamMedis(int Id, string Riwayat, int Id_Dokter, int Id_Obat, string Tanggal)
        {

            this.Id = Id;
            this.Riwayat = Riwayat;
            this.Id_Dokter = Id_Dokter;
            this.Id_Obat = Id_Obat;
            this.Tanggal = Tanggal;
        }

        public int Id { get; set; }

        public string Riwayat { get; set; }

        public int Id_Dokter { get; set; }

        public int Id_Obat { get; set; }

        public string Tanggal { get; set; }


    }
}

