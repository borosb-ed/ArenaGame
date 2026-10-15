namespace ArenaGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character Test = new Character("Test");
            Console.WriteLine(Test.GetDesciption());
            Console.WriteLine("Test is alive: " + Test.IsAlive());
            Console.WriteLine("Total number of characters: " 
                + Character.Count);

            Warrior w = new Warrior("w",5);
            Console.WriteLine("Warrior name: " + w.Name);
            Console.WriteLine("Warrior health: " + w.Health);
            Console.WriteLine("Warrior armor: " + w.Armor);
            Console.WriteLine(w.GetDesciption());

            Mage m = new Mage("m", 15);
            Console.WriteLine("Mage name: " + m.Name);
            Console.WriteLine("Mage health: " + m.Health);
            Console.WriteLine("Mage mana: " + m.Mana);
            Console.WriteLine(m.GetDesciption());

            Console.WriteLine("Total number of characters: "
                + Character.Count);

            Console.WriteLine("Damage warrior: " + w.TakeDamage(30));
            Console.WriteLine("Warrior health: " + w.Health);
            Console.WriteLine("Heal warrior: " + w.Heal(30));
            Console.WriteLine("Warrior health: " + w.Health);

            Console.WriteLine("Damage mage: " + m.TakeDamage(50));
            Console.WriteLine("Mage health: " + m.Health);
            Console.WriteLine("Heal mage: " + m.Heal(80));
            Console.WriteLine("Mage health: " + m.Health);






        }
    }
}
