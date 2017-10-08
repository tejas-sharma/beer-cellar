using GraphQL.Types;
namespace BeerCellar.Models
{
    public class BeerVariantType : ObjectGraphType<BeerVariant>
    {
        public BeerVariantType()
        {
            Field<BeerType>("beer", description: "The beer for which this is a variant.");
            Field(x => x.Year).Description("The year the beer was released.");
        }
    }
}
