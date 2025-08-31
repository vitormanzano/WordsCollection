using WordsCollection.ValueObjects;

namespace WordsCollection.Models;

public class UserModel
{
    public Guid Id { get; private set; }
    public EmailVo Email { get; private set; }
    public PasswordVo Password { get; private set; }
    public List<WordModel> Words { get; private set; } =  new List<WordModel>();
    
    protected UserModel() { }
}