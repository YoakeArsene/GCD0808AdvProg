using System;

namespace Abstraction.CompanyRoster
{
  class Program
  {
    static void Main(string[] args)
    {
      Company company = new Company();
      company.AddEmployee(new Employee("John", 100, "Director", "AAA", "John@gmail.com", 20));
      company.AddEmployee(new Employee("Paul", 200, "Director", "BBB"));
      company.AddEmployee(new Employee("Wick", 300, "Director", "AAA"));
      company.AddEmployee(new Employee("Kratos", 150, "Director", "CCC"));

      company.GetDepartmentWithHighestAverageSalary();

      Console.ReadLine();

    }
  }
}
