using WordsCollection.Dtos.User;
using WordsCollection.Repository.User;

namespace WordsCollection.Services.User;

public class UserService(IUserRepository userRepository) : IUserService
{
    public void SignUp(SignUpUserDto user)
    {
        
    }
}