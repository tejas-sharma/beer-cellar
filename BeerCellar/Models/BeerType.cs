using GraphQL.Types;
namespace BeerCellar.Models
{
    public class BeerType : ObjectGraphType<Beer>
    {
        public BeerType()
        {
            Field(x => x.Id).Description("The id of the beer.");
            Field<BrewerType>("brewer", description: "The brewer who brewed the beer.");
            Field(x => x.Name).Description("The name of the beer");
            Field<ListGraphType<BeerVariantType>>("variants", description: "Variants of this beer.");
        }
    }
}
