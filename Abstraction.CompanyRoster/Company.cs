using System.Collections.Generic;
using System.Linq;

namespace Abstraction.CompanyRoster
{
  class Company
  {
    public List<Employee> Employees;

    public Company()
    {
      Employees = new List<Employee>();
    }

    public decimal GetHighestAverageSalary()
    {
      return 0;
    }

    public string GetDepartmentWithHighestAverageSalary()
    {
      return "";
    }

    public void PrintEmployees(string department)
    {
      var employees = Employees.Where(
        t => t.Department.Equals(department)).ToList();
      foreach (var employee in employees)
      {
        employee.PrintInfo();
      }
    }
  }
}
