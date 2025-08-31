using WordsCollection.Data;
using WordsCollection.Models;

namespace WordsCollection.Repository.User;

public class UserRepository(AppDbContext context) : IUserRepository
{
    public async void SignUp(UserModel user)
    {
        context.Users.Add(user);
        await context.SaveChangesAsync();
    }
}