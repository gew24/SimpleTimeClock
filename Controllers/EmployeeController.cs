using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleTimeClock.DataBase;
using SimpleTimeClock.Models;
using SimpleTimeClock.Services;

namespace SimpleTimeClock.Controllers;

public class EmployeeController : Controller
{
    private EmployeeService _employeeService;
    
    // GET: /Employees
    public ActionResult GetAllEmployees()
    {
        var allEmployees = _employeeService.GetAllEmplyees();
        return ActionResult<List<Employee>> allEmployees;
    }
    
    // POST Employee
    [AcceptVerbs()]
    public ActionResult Create(Employee employee)
    {
        return ;
    }
    
    
}