using System;

namespace Abstraction
{
  class Program
  {
    static void Main(string[] args)
    {
      // Use keyword "new" to create object from class
      Hero hero = new Hero();
      Hero amazon = new Hero();
      Hero paladin = new Hero();

      // To access function or property of object, use "."
      hero.FullName = "Illidan";
      hero.HP = 1000;
      hero.Level = 5;
      hero.Mana = 100;
      hero.AttackPoint = 150;

      Console.WriteLine(hero.FullName);
      Console.WriteLine(hero.HP);
      Console.WriteLine(hero.Mana);
      Console.WriteLine(hero.Level);
      Console.WriteLine(hero.AttackPoint);

      hero.Attack();
      hero.Jump();
      hero.Walk();

    }

  }
}
