﻿namespace MongoProject.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(string id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(string id, T entity);
        Task DeleteAsync(string id);
    }
}
