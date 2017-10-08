using GraphQL.Types;
namespace BeerCellar.Models
{
    public class BrewerType : ObjectGraphType<Brewer>
    {
        public BrewerType()
        {
            Field<ListGraphType<BeerType>>("beers", description: "The beers brewerd by this brewer.");
            Field(x => x.Id).Description("The id of this brewer.");
            Field(x => x.Name).Description("The name of the brewer");
        }
    }
}
