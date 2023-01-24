using SimpleTimeClock.Models;

namespace SimpleTimeClock.DataBase;

public class EmployeeRepository : IRepository<Employee>
{
    private readonly Guid employeeId;
    private readonly IRepository<Employee> _repository;

    public EmployeeRepository(string employeeId)
    {
    }

    public EmployeeRepository(Guid employeeId, string connectionString)
    {
        this.employeeId = employeeId;
        this._repository = new EmployeeRepository(this.employeeId, connectionString);
    }

    public IList<Employee> GetAll()
    {
        return this._repository.GetAll();
    }

    public Employee Get(Guid employeeId)
    {
        return this._repository.Get(employeeId);
    }

    public void Save(Employee employee)
    {
        this._repository.Save(employee);
    }

    public void Delete(Guid employeeId)
    {
        this._repository.Delete(employeeId);
    }

    public void Dispose()
    {
        this._repository.Dispose();
    }
}