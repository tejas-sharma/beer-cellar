using System;
using GraphQL;
using GraphQL.Types;
using GraphQL.Http;
using BeerCellar.DataAccess;

namespace BeerCellar.Models
{
    public class BeerCellarQuery : ObjectGraphType
    {
        private readonly IBeerCellarFetcher _fetcher;

        public BeerCellarQuery(IBeerCellarFetcher fetcher)
        {
            _fetcher = fetcher;
            Field<BeerCellarType>(
                "beercellar",
                resolve: (ctx) => {
                    var c = _fetcher.GetById(1);
                    return c;
                });
        }
    }
}
