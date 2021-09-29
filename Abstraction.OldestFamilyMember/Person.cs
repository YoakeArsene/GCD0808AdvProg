using System;

namespace Abstraction.OldestFamilyMember
{
  class Person
  {
    public int Age;
    public string Name;

    public Person(int age, string name)
    {
      Age = age;
      Name = name;
    }

    public Person()
    {

    }

    public void PrintInfo()
    {
      Console.WriteLine($"{Name} | {Age} years old ");
    }


  }
}
