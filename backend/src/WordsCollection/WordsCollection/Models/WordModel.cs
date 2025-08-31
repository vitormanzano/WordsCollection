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

    public WordModel(string sentence, string meaning, UserModel user)
    {
        SetSentence(sentence);
        SetMeaning(meaning);
        CreatedAt = DateTime.Now;
        User = user;
    }

    public void SetSentence(string sentence)
    {
        ValidateSentence(sentence);
        Sentence = sentence;
    }

    private void ValidateSentence(string sentence)
    {
        switch (sentence.Length)
        {
            case < 4:
                throw new ArgumentException("Sentence must have at least 4 characters.");
            case > 255:
                throw new ArgumentException("Sentence cannot exceed 255 characters.");
        }
    }

    public void SetMeaning(string meaning)
    {
        ValidateMeaning(meaning);
        Meaning = meaning;
    }

    private void ValidateMeaning(string meaning)
    {
        switch (meaning.Length)
        {
            case < 4:
                throw new ArgumentException("Meaning must have at least 4 characters.");
            case > 255:
                throw new ArgumentException("Meaning cannot exceed 255 characters.");
        }
    }
}