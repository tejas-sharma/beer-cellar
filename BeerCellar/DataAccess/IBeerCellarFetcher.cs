using System;
using Cellar = BeerCellar.Models.BeerCellar;
namespace BeerCellar.DataAccess
{
    public interface IBeerCellarFetcher
    {
        Cellar GetById(int id);
    }
}
