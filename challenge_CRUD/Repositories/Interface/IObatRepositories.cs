using System;
using challenge_CRUD.Models;

namespace challenge_CRUD.Repositories.Interface
{
    public interface IObatRepositories
    {

        public List<Obat> Get();

        public Obat Get(int Id);

        public int Insert(Obat obat);

        public int Update(Obat obat);

        public int Delete(int Id);
    }
}

