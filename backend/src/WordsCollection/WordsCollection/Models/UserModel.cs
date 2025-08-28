using WordsCollection.ValueObjects;

namespace WordsCollection.Models;

public class UserModel
{
    public Guid Id { get; private set; }
    public EmailVo Email { get; private set; }
    public PasswordVo Password { get; private set; }
    
    protected UserModel() { }
}