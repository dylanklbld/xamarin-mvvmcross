namespace HelloWord.Core.Repository.Common
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class BasicDataRepository : IBaseRepository<string>
    {
        public Task<IEnumerable<string>> GetAllData()
        {
            throw new NotImplementedException();
        }

        public Task<string> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Add(string entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(string entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(string entity)
        {
            throw new NotImplementedException();
        }

        public Task Save()
        {
            throw new NotImplementedException();
        }
    }
}