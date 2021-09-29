namespace Abstraction
{
  class Program
  {
    static void Main(string[] args)
    {
      // Use keyword "new" to create object from class
      Hero hero = new Hero();
      Hero amazon = new Hero("Wonder Woman", 100, 150, 299);
      Hero paladin = new Hero("Batman", 250, 50, 499);

      Monster dragon = new Monster("Blue Dragon", 100, 200);

      // To access function or property of object, use "."
      hero.FullName = "Illidan";
      hero.HP = 1000;
      hero.Level = 5;
      hero.Mana = 100;
      hero.AttackPoint = 150;

      hero.PrintInfo();
      amazon.PrintInfo();
      paladin.PrintInfo();

      hero.Attack();
      hero.Jump();
      hero.Walk();

      amazon.Attack(dragon);
      paladin.Attack(dragon);
      hero.Attack(dragon);

    }

  }
}
