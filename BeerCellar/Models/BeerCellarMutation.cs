using System;
using BeerCellar.DataAccess;
using GraphQL.Types;

namespace BeerCellar.Models
{
    public class BeerCellarMutation : ObjectGraphType<object>
    {
        private readonly IBeerCellarDbAccess _db;
        public BeerCellarMutation(IBeerCellarDbAccess db)
        {
            if (db == null) throw new ArgumentNullException(nameof(db));
            _db = db;

            Field<BeerCellarType>(
                "createBeerCellar",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<BeerCellarInputType>> { Name = "beerCellar" }),
                resolve: ctx => { 
                return _db.Create(ctx.GetArgument<BeerCellar>("beerCellar")); });
        }
    }
}
