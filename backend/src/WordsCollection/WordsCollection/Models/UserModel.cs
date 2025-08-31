using WordsCollection.ValueObjects;

namespace WordsCollection.Models;

public class UserModel
{
    public Guid Id { get; private set; }
    public EmailVo Email { get; private set; }
    public PasswordVo Password { get; private set; }
    public List<WordModel> Words { get; private set; } =  new List<WordModel>();
    
    protected UserModel() { }

    public UserModel(string emailAddress, string password)
    {
        Id = Guid.NewGuid();
        SetEmail(emailAddress);
        SetPassword(password);
    }

    public void SetEmail(string emailAddress)
    {
        Email = new EmailVo(emailAddress);
    }

    public void SetPassword(string password)
    {
        Password = new PasswordVo(password);
    }
}