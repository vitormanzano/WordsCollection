namespace WordsCollection.Models;

public class UserModel
{
    public Guid Id { get; private set; }
    public string Email { get; private set; }
    public string Password { get; private set; }
}