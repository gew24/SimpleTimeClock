using SimpleTimeClock.DataBase;
using SimpleTimeClock.Models;

namespace SimpleTimeClock.Services;

public class UserService
{
    private readonly Guid userId;
    private readonly IRepository<User> _repository;
    private UserRepository _userRepository;

    public Task<IList<User>> GetAllEmplyees()
    {
        IList<User> allUsers =  _userRepository.GetAll();
        return Task.FromResult(allUsers);
    }

    public Task<User> GetUserById(Guid userId)
    {
        var user = _userRepository.Get(userId);
        return Task.FromResult(user);
    }

    public void SaveUser(User user)
    {
        _userRepository.Save(user);
    }

    public void DeleteUser(Guid userId)
    {
        _userRepository.Delete(userId);
    }
}