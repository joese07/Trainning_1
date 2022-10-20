using System;
namespace challenge_CRUD.Models
{
    public class Spesialis
    {
        public Spesialis(int Id, string Nama, string Catatan)
        {
            this.Id = Id;
            this.Nama = Nama;
            this.Catatan = Catatan;
        }

        public int Id { get; private set; }

        public string Nama { get; private set; }

        public string Catatan { get; private set; }
     }
}

