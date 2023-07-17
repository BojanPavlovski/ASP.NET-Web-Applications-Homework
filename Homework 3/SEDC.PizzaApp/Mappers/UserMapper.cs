using SEDC.PizzaApp.Models;
using SEDC.PizzaApp.ViewModels;

namespace SEDC.PizzaApp.Mappers
{
    public class UserMapper
    {
        public static SeeUsersViewModel UserToSeeUserViewModel(User userDb)
        {
            return new SeeUsersViewModel
            {
                UserFullName = $"{userDb.FirstName} {userDb.LastName}"
            };
        }
    }
}
