namespace SuggestionAppLibrary.Models;

public class SuggestionModel
{
    [BsonId] // Id w bazie danych
    [BsonRepresentation(BsonType.ObjectId)] // ObjectId
    public string Id { get; set; }
    public string Suggestion { get; set; }
    public string Description { get; set; }
    public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    public CategoryModel Category { get; set; }
    public BasicSuggestionModel Author { get; set; }
    public HashSet<string> UserVotes { get; set; } = new(); // HashSet - lista z unikalnym wartościami
    public StatusModel SuggestionStatus { get; set; }
    public string OwnerNotes { get; set; }
    public bool ApprovedForRelease { get; set; } = false;
    public bool Archived { get; set; }= false;

    public bool Rejected { get; set; } = false; // Sugestia nie będzie pojawiała się nigdzie indziej, tylko w liście sugestii danego użytkownika


}
