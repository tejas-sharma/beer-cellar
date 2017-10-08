using GraphQL.Types;
namespace BeerCellar.Models
{
    public class BeerCellarType : ObjectGraphType<BeerCellar>
    {
        public BeerCellarType()
        {
            Field(x => x.Id).Description("The ID of the cellar.");
            Field(x => x.Name).Description("The name of the cellar.");
            Field<UserType>("owner", description: "The owner of the cellar");
            Field<ListGraphType<BeerType>>("beers", description: "The beers in this cellar");
        }
    }
}
