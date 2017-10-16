using System;
using GraphQL.Types;
namespace BeerCellar.Models
{
    public class BeerCellarSchema : Schema
    {
        public BeerCellarSchema(Func<Type, IGraphType> resolver) 
            : base(resolver)
        {
            Query = (BeerCellarQuery) resolver(typeof(BeerCellarQuery));
            Mutation = (BeerCellarMutation)resolver(typeof(BeerCellarMutation));
        }
    }
}
