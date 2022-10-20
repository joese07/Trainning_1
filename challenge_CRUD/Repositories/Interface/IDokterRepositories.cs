using System;
using challenge_CRUD.Models;

namespace challenge_CRUD.Repositories.Interface
{
    public interface IDokterRepositories
    {
        public List<Dokter> Get();

        public List<DokterView> Show();

        public Dokter Get(int Id);

        public int Insert(Dokter dokter);

        public int Update(Dokter dokter);

        public int Delete(int Id);
    }
}

