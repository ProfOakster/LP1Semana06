using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Foe goblin = new Foe("  Goblin ");

            Console.WriteLine(goblin.GetName());
            Console.WriteLine(goblin.GetHealth());


        }
    }
}
