using WordsCollection.Dtos.User;

namespace WordsCollection.Services.User;

public interface IUserService
{
    public void SignUp(SignUpUserDto user);
}