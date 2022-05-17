namespace SuggestionAppLibrary.Models;
public class UserModel
{
    [BsonId] // Id w bazie danych
    [BsonRepresentation(BsonType.ObjectId)] // ObjectId
    public string Id { get; set; }

    public string ObjectIdentifier { get; set; } // Id do Azurea
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DisplayName { get; set; }
    public string EmailAddress { get; set; }
    public List<BasicSuggestionModel> AuthoredSuggestions { get; set; } = new();
    public List<BasicSuggestionModel> VotedOnSuggestions { get; set; } = new();
}
