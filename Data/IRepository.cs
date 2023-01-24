using SimpleTimeClock.Models;

namespace SimpleTimeClock.DataBase;

public interface IRepository<TEntity> : IDisposable where TEntity : class
{
    IList<TEntity> GetAll();
    Employee Get(Guid id);
    void Save(TEntity model);
    void Delete(Guid id);
}