using GraphQL.Types;
namespace BeerCellar.Models
{
    public class BeerCellarType : ObjectGraphType<BeerCellar>
    {
        public BeerCellarType()
        {
            Field(x => x.Id).Description("The ID of the cellar.");
            Field(x => x.Name).Description("The name of the cellar.");
            Field(x => x.Owner).Description("The owner of the cellar.");
            Field(x => x.Beers).Description("The beers in this cellar.");
        }
    }
}
