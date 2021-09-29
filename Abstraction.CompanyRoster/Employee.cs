using System;

namespace Abstraction.CompanyRoster
{
  class Employee
  {
    public string Name;
    public decimal Salary;
    public string Position;
    public string Department;
    public string Email;
    public int Age;

    public Employee()
    {
    }

    public Employee(string name, decimal salary, string position, string department)
    {
      Name = name;
      Salary = salary;
      Position = position;
      Department = department;
    }

    public Employee(string name, decimal salary, string position, string department,
      string email, int age)
    {
      Name = name;
      Salary = salary;
      Position = position;
      Department = department;
      Email = email;
      Age = age;
    }

    public void PrintInfo()
    {
      if (Age != 0)
      {
        Console.WriteLine($"{Name} {Salary} {Email} {Age}");
      }
      else
      {
        Console.WriteLine($"{Name} {Salary} {Email} -1");
      }
    }
  }
}
