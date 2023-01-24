using SimpleTimeClock.DataBase;
using SimpleTimeClock.Models;

namespace SimpleTimeClock.Services;

public class EmployeeService
{
    private readonly Guid employeeId;
    private readonly IRepository<Employee> _repository;
    private EmployeeRepository _employeeRepository;

    public Task<IList<Employee>> GetAllEmplyees()
    {
        IList<Employee> allEmployees =  _employeeRepository.GetAll();
        return Task.FromResult(allEmployees);
    }

    public Task<Employee> GetEmployeeById(Guid employeeId)
    {
        var employee = _employeeRepository.Get(employeeId);
        return Task.FromResult(employee);
    }

    public void SaveEmployee(Employee employee)
    {
        _employeeRepository.Save(employee);
    }

    public void DeleteEmployee(Guid employeeId)
    {
        _employeeRepository.Delete(employeeId);
    }
}