using System;
namespace BeerCellar.Models
{
    public interface IRepository<TItem, TId> where TItem : class
    {
        TItem Create(TItem item);
        TItem Find(TId id);
        bool Save();
    }
}
