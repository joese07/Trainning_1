using System;
using challenge_CRUD.Models;

namespace challenge_CRUD.Repositories.Interface
{
    public interface ISpesialisRepositories
    {
        public List<Spesialis> Get();

        public Spesialis Get(int Id);

        public int Insert(Spesialis spesialis);

        public int Update(Spesialis spesialis);

        public int Delete(int Id);
    }
}

