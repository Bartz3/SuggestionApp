namespace SuggestionAppLibrary.DataAccess;
public class MongoUserData : IUserData
{
    private readonly IMongoCollection<UserModel> _users;
    public MongoUserData(IDbConnection db) // Asking DbConnection for users
    {
        _users = db.UserCollection;
    }

    /// Function returning all the users in DB
    public async Task<List<UserModel>> GetUserAsync()
    {
        var results = await _users.FindAsync(_ => true); // Review each record and then assign it
        return results.ToList();
    }

    public async Task<UserModel> GetUser(string id)
    {
        var results = await _users.FindAsync(u => u.Id == id);
        return results.FirstOrDefault();
    }
    public async Task<UserModel> GetUserFromAuthentication(string objectId) // objectID assigned by azure active directory b2c to UserModel
    {
        var results = await _users.FindAsync(u => u.ObjectIdentifier == objectId);
        return results.FirstOrDefault();
    }

    public Task CreateUser(UserModel user)
    {
        return _users.InsertOneAsync(user);
    }
    public Task UpdateUser(UserModel user)
    {
        var filter = Builders<UserModel>.Filter.Eq("Id", user.Id);
        return _users.ReplaceOneAsync(filter, user, new ReplaceOptions { IsUpsert = true });
        //Finding filter object and put into user place IsUpsert - if no records ->insert one, otherwise -> update
    }
}
