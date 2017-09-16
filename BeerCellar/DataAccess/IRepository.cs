using System;
namespace BeerCellar.DataAccess
{
    public interface IRepository<TItem, TId> where TItem : class
    {
        TItem Create(TItem item);
        TItem Find(TId id);
        bool Save();
    }
}
