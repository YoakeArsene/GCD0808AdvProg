using System;

namespace Abstraction
{
  class Hero
  {
    // Properties
    public string FullName;
    public int HP;
    public int Mana;
    public int AttackPoint;
    public int Level;

    // Constructor without parameters
    public Hero()
    {
      FullName = "N/A";
      HP = -1;
      Mana = -1;
      AttackPoint = -1;
      Level = 0;
    }

    // Constructor with parameters
    public Hero(string fullName, int hp, int mana, int attackPoint)
    {
      FullName = fullName;
      HP = hp;
      Mana = mana;
      AttackPoint = attackPoint;
      Level = 1;
    }


    // Functions
    public void Walk()
    {
      Console.WriteLine($"{FullName} is walking ...");
    }

    public void Attack()
    {
      Console.WriteLine($"{FullName} is attacking ...");
    }

    public void Jump()
    {
      Console.WriteLine($"{FullName} is jumping ...");
    }

    public void PrintInfo()
    {
      Console.WriteLine($"{FullName} | HP: {HP} | MANA: {Mana} | ATTK: {AttackPoint} | LVL: {Level}");
    }

  }
}
