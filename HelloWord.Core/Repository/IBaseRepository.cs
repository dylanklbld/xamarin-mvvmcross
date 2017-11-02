namespace HelloWord.Core.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IBaseRepository<T>
    {
        Task<IEnumerable<T>> GetAllData();

        Task<T> GetById(Guid id);

        Task Add(T entity);

        Task Update(T entity);

        Task Delete(T entity);

        Task Save();
    }
}