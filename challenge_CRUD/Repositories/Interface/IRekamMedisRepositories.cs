using System;
using challenge_CRUD.Models;

namespace challenge_CRUD.Repositories.Interface
{
    public interface IRekamMedisRepositories
    {
        public List<RekamMedis> Get();

        public RekamMedis Get(int Id);

        public int Insert(RekamMedis rekamMedis);

        public int Update(RekamMedis rekamMedis);

        public int Delete(int Id);
    }
}

