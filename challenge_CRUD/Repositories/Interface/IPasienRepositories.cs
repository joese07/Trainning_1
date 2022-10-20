using System;
using challenge_CRUD.Models;

namespace challenge_CRUD.Repositories.Interface
{
    public interface IPasienRepositories
    {
        public List<Pasien> Get();

        public Pasien Get(int Id);

        public int Insert(Pasien pasien);

        public int Update(Pasien pasien);

        public int Delete(int Id);
    }
}

