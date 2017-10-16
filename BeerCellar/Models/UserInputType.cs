using GraphQL.Types;

namespace BeerCellar.Models
{
    public class UserInputType : InputObjectGraphType
    {
        public UserInputType()
        {
            Name = "User";
            Field<StringGraphType>("id", description: "user id of user");
        }
    }
}