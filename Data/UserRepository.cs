using SimpleTimeClock.Models;

namespace SimpleTimeClock.DataBase;

public class UserRepository : IRepository<User>
{
    private readonly Guid userId;
    private readonly IRepository<User> _repository;

    public UserRepository(string userId)
    {
    }

    public UserRepository(Guid userId, string connectionString)
    {
        this.userId = userId;
        this._repository = new UserRepository(this.userId, connectionString);
    }

    public IList<User> GetAll()
    {
        return this._repository.GetAll();
    }

    public User Get(Guid userId)
    {
        return this._repository.Get(this.userId);
    }

    public void Save(User user)
    {
        this._repository.Save(user);
    }

    public void Delete(Guid userId)
    {
        this._repository.Delete(userId);
    }

    public void Dispose()
    {
        this._repository.Dispose();
    }
}