using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input nº of enemies:");
            int enemyNum=int.Parse(Console.ReadLine());

            Foe [] foes= new Foe[enemyNum];

            for (int i = 0; i < foes.Length; i++)
            {
                Console.WriteLine($"Input enemy #{i+1}'s name:");
                foes[i] = new Foe(Console.ReadLine());
            }
            
            Console.WriteLine("Enemies:");
            for (int i = 0; i < foes.Length; i++)
            {
                Console.WriteLine($"{i+1}-{foes[i].GetName()}");
            }
        }
    }
}
