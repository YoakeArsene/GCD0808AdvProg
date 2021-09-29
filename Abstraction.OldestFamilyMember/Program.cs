using System;

namespace Abstraction.OldestFamilyMember
{
  class Program
  {
    static void Main(string[] args)
    {
      Family family = new Family();

      family.AddMember(new Person(20, "John Wick"));
      family.AddMember(new Person(30, "John Lennon"));
      family.AddMember(new Person(12, "Amazon"));
      family.AddMember(new Person(29, "John Batman"));

      var oldestMember = family.GetOldestFamilyMember();
      oldestMember.PrintInfo();

      Console.ReadLine();

    }
  }
}
