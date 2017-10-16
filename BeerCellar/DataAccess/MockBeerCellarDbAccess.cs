using System;
using System.Collections.Generic;
using System.Linq;
using BeerCellar.Models;

namespace BeerCellar.DataAccess
{
    public class MockBeerCellarDbAccess : IBeerCellarDbAccess
    {
        private readonly IDictionary<string, Models.BeerCellar> _cellars;
        public MockBeerCellarDbAccess()
        {
            var foundersBeers = new List<Beer>();
            var founders = new Brewer
            {
                Id = "1",
                Name = "Founders",
                Beers = foundersBeers
            };
            foundersBeers.Add(new Beer { Brewer = founders, Id = "1", Name = "KBS" });
			foundersBeers.Add(new Beer { Brewer = founders, Id = "2", Name = "CBS" });
            var cellar = new Models.BeerCellar { Id = "1", Name = "Tejas' Cellar", Beers = foundersBeers };
            var tejas = new User { Id = "tsharma", FirstName = "Tejas", LastName = "Sharma", BeerCellars = new List<Models.BeerCellar> { cellar } };
            cellar.Owner = tejas;
			_cellars = new Dictionary<string, Models.BeerCellar>();
            _cellars.Add("1", cellar);
        }

        public Models.BeerCellar GetById(int id)
        {
            return _cellars[id.ToString()];
        }

        public IEnumerable<Models.BeerCellar> GetByUser(string user)
        {
            return _cellars.Where(cellar => cellar.Value.Owner.Id == user).Select(cellar => cellar.Value);
        }

        public Models.BeerCellar Create(Models.BeerCellar beerCellar)
        {
            var user = beerCellar.Owner;
            if (user.Id != "tsharma") throw new ArgumentException($"User {user} does not exist!");
            var existingCellars = _cellars.Where(cellar => cellar.Value.Owner.Id == user.Id).Select(cellar => cellar.Value);
            var maxId = existingCellars.Max(cellar => int.Parse(cellar.Id));
            beerCellar.Owner = user;
            _cellars.Add((maxId + 1).ToString(), beerCellar);
            return _cellars[(maxId + 1).ToString()];
        }
    }
}
