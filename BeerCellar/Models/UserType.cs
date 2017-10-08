using GraphQL.Types;
namespace BeerCellar.Models
{
    public class UserType : ObjectGraphType<User>
    {
        public UserType()
        {
            Field(x => x.Id).Description("The user id.");
            Field(x => x.FirstName).Description("The first name of the user");
            Field(x => x.LastName).Description("The last name of the user.");
            Field(x => x.BeerCellars).Description("The cellars owned by this user");
        }
    }
}
