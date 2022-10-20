using System;
namespace challenge_CRUD.Models
{
    public class Pasien
    {
        public Pasien(int Id, string Nama, string Jenis_kelamin, string No_telepon, string Alamat, string Id_rekam_medis)
        {
            this.Id = Id;
            this.Nama = Nama;
            this.Jenis_kelamin = Jenis_kelamin;
            this.No_telepon = No_telepon;
            this.Alamat = Alamat;
            this.Id_rekam_medis = Id_rekam_medis;
        }

        public int Id { get; private set; }

        public string Nama { get; private set; }

        public string Jenis_kelamin { get;private set; }

        public string No_telepon { get; private set; }

        public string Alamat { get; private set; }

        public string Id_rekam_medis { get; private set; }
    }
}

