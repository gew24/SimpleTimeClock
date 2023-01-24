using Microsoft.EntityFrameworkCore;
using SimpleTimeClock.Models;

namespace SimpleTimeClock.DataBase;

public class ApplicationDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }
    
    public DbSet<User> User { get; set; }
    
    public DbSet<HoursWorked> HoursWorked { get; set; }


}