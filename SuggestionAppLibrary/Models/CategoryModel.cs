
namespace SuggestionAppLibrary.Models;
public class CategoryModel
{
    [BsonId] // Id w bazie danych
    [BsonRepresentation(BsonType.ObjectId)] // ObjectId
    public int Id { get; set; }
    public string CategoryName { get; set; }
    public string CategoryDescription { get; set; }

}
