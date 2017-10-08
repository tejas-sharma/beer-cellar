using System;
using System.Collections.Generic;
using BeerCellar.Models;

namespace BeerCellar.DataAccess
{
    public class BeerCellarFetcher : IBeerCellarFetcher
    {
        private readonly IDictionary<string, Models.BeerCellar> _cellars;
        public BeerCellarFetcher()
        {
            var foundersBeers = new List<Beer>();
            var founders = new Brewer
            {
                Id = 1,
                Name = "Founders",
                Beers = foundersBeers
            };
            foundersBeers.Add(new Beer { Brewer = founders, Id = 1, Name = "KBS" });
			foundersBeers.Add(new Beer { Brewer = founders, Id = 2, Name = "CBS" });
            var cellar = new Models.BeerCellar { Id = "1", Name = "Tejas' Cellar", Beers = foundersBeers };
            var tejas = new User { Id = 1, FirstName = "Tejas", LastName = "Sharma", BeerCellars = new List<Models.BeerCellar> { cellar } };
            cellar.Owner = tejas;
			_cellars = new Dictionary<string, Models.BeerCellar>();
            _cellars.Add("1", cellar);
        }

        public Models.BeerCellar GetById(int id)
        {
            return _cellars[id.ToString()];
        }
    }
}
