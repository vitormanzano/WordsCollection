using WordsCollection.Models;

namespace WordsCollection.Repository.User;

public interface IUserRepository
{ 
    void SignUp(UserModel user);
}