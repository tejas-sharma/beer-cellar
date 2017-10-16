using System;
using System.Collections.Generic;
using Cellar = BeerCellar.Models.BeerCellar;
namespace BeerCellar.DataAccess
{
    public interface IBeerCellarDbAccess
    {
        Cellar GetById(int id);
        IEnumerable<Cellar> GetByUser(string user);
        Models.BeerCellar Create(Cellar beerCellar);
	}
}
