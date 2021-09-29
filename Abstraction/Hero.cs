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


    // Function
    public void Walk()
    {
      Console.WriteLine("Hero is walking ...");
    }

    public void Attack()
    {
      Console.WriteLine("Hero is attacking ...");
    }

    public void Jump()
    {
      Console.WriteLine("Hero is jumping ...");
    }

  }
}
