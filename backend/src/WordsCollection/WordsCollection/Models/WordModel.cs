namespace WordsCollection.Models;

public class WordModel
{
    public Guid Id { get; private set; }
    public string Sentence { get; private set; }
    public string Meaning  { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public Guid UserId { get; private set; }
    public UserModel User { get; private set; }
    
    protected WordModel() { }
}