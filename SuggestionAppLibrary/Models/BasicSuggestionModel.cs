namespace SuggestionAppLibrary.Models;
public class BasicSuggestionModel
{
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } // Link do pełnego opisu sugesti
    public string Suggestion { get; set; }// Tytuł sugesti

    public BasicSuggestionModel()
    {

    }

    public BasicSuggestionModel(SuggestionModel suggestion)
    {
        Id=suggestion.Id;
        Suggestion = suggestion.Suggestion;
    }
}
