using Microsoft.EntityFrameworkCore;
using SimpleTimeClock.Models;

namespace SimpleTimeClock.DataBase;

public class HoursWorkedRepository : IRepository<HoursWorked>
{
    private readonly Guid id;
    private readonly IRepository<HoursWorked> _repository;

    public HoursWorkedRepository(Guid id)
    {
    }

    public HoursWorkedRepository(Guid id, string connectionString)
    {
        this.id = id;
        this._repository = new HoursWorkedRepository(this.id, connectionString);
    }

    public IList<HoursWorked> GetAll()
    {
        return this._repository.GetAll();
    }

    public List<HoursWorked> Get(Guid id)
    {
        return this._repository.Get(id);
    }

    public List<HoursWorked> GetHoursWorkedByEmployee(Guid employeeId)
    {
        using (var hw = new ApplicationDbContext())
        {
            var hours = hw.HoursWorked.Where((x => x.EmployeeId == employeeId)).ToList();
            return hours;
        }
    }

    public void Save(HoursWorked hoursWorked)
    {
        this._repository.Save(hoursWorked);
    }

    public void Delete(Guid id)
    {
        this._repository.Delete(id);
    }

    public void Dispose()
    {
        this._repository.Dispose();
    }
}
