namespace SuggestionAppLibrary.Models;
public class StatusModel
{
    [BsonId] // Id w bazie danych
    [BsonRepresentation(BsonType.ObjectId)] // ObjectId
    public string Id { get; set; }
    public string StatusName { get; set; }
    public string StatusDescription { get; set; }
}
