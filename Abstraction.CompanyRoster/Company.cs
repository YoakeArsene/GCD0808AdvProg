using System;
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

    public void GetDepartmentWithHighestAverageSalary()
    {
      var department =
        from e in Employees
        group e by e.Department into g
        select new { Department = g.Key, AverageSalary = g.Average(p => p.Salary) };

      var resultDepartment = department
        .FirstOrDefault(t => t.AverageSalary == department.Max(e => e.AverageSalary))
        .Department;

      Console.WriteLine($"Highest Average Salary: {resultDepartment}");

      PrintEmployees(resultDepartment);
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

    public void AddEmployee(Employee employee)
    {
      Employees.Add(employee);
    }
  }
}
