using System;
namespace challenge_CRUD.Models
{
    public class Obat
    {
        public Obat(int Id, string Nama, string Catatan, string Expired)
        {
            this.Id = Id;
            this.Nama = Nama;
            this.Catatan = Catatan;
            this.Expired = Expired;
        }

        public int Id { get; private set; }

        public string Nama { get; private set; }

        public string Catatan { get; private set; }

        public string Expired { get; private set; }
    }
}

