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
        }
    }
}
