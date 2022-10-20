using System;
namespace challenge_CRUD.Models
{
    public class Dokter
    {
        public Dokter(int Id, string Nama, string Jenis_kelamin, string No_telepon, string Alamat, int Id_Spesialis)
        {
            this.Id = Id;
            this.Nama = Nama;
            this.Jenis_kelamin = Jenis_kelamin;
            this.No_telepon = No_telepon;
            this.Alamat = Alamat;
            this.Id_Spesialis = Id_Spesialis;
        }

        public int Id { get; private set; }

        public string Nama { get; private set; }

        public string Jenis_kelamin { get; private set; }

        public string No_telepon { get; private set; }

        public string Alamat { get;private set; }

        public int Id_Spesialis { get;private set; }
    }
}

