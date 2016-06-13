using System.Collections.Generic;
using Tridion.Snitch.Application.library;

namespace Tridion.Snitch.Application.Data_access.Repository
{
    public interface IRepository <TEntity, in TKey> where TEntity : class
    {
        ICollection<TEntity> All();
        TEntity Find(string userId);
        void Add(TEntity entity);
        void Delete(string userId);
    }
}