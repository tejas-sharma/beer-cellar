using System;
using GraphQL;
using GraphQL.Types;
using GraphQL.Http;
using BeerCellar.DataAccess;
using System.Collections.Generic;

namespace BeerCellar.Models
{
    public class BeerCellarQuery : ObjectGraphType
    {
        private readonly IBeerCellarDbAccess _fetcher;

        public BeerCellarQuery(IBeerCellarDbAccess fetcher)
        {
            _fetcher = fetcher;
            Field<ListGraphType<BeerCellarType>>(
                "beerCellars",
                arguments: new QueryArguments(new QueryArgument<StringGraphType> { Name = "user" }),
                resolve: (ctx) =>
                {
                    return _fetcher.GetByUser(ctx.GetArgument<string>("user"));
                });
			}
    }
}
