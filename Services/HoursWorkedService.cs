using SimpleTimeClock.DataBase;
using SimpleTimeClock.Models;

namespace SimpleTimeClock.Services;

public class HoursWorkedService
{
    private readonly Guid id;
    private readonly IRepository<HoursWorked> _repository;
    private HoursWorkedRepository _hoursWorkedRepository;

    public Task<IList<HoursWorked>> GetAllEmplyees()
    {
        IList<HoursWorked> allEmployees =  _hoursWorkedRepository.GetAll();
        return Task.FromResult(allEmployees);
    }

    public Task<HoursWorked> GetHoursWorkedById(Guid id)
    {
        var hoursWorked = _hoursWorkedRepository.Get(id);
        return Task.FromResult(hoursWorked);
    }

    public void SaveHoursWorked(HoursWorked hoursWorked)
    {
        _hoursWorkedRepository.Save(hoursWorked);
    }

    public void DeleteHoursWorked(Guid employeeId)
    {
        _hoursWorkedRepository.Delete(employeeId);
    }

    public void UpdateHours(HoursWorked hoursWorked)
    {
        GetHoursWorkedById(hoursWorked.Id);
        var employeeHoursWorked = _hoursWorkedRepository.GetHoursWorkedByEmployee(hoursWorked.EmployeeId);
        
    }
}