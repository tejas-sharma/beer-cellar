using GraphQL.Types;

namespace BeerCellar.Models
{
    public class BeerCellarInputType : InputObjectGraphType
    {
        public BeerCellarInputType()
        {
            Name = "BeerCellar";
            Field<StringGraphType>("name", description: "The name of the cellar.");
            Field<UserInputType>("owner", description: "The owner of the cellar");
        }
    }
}
