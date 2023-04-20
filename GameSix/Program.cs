using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input nº of enemies:");
            int enemyNum = int.Parse(Console.ReadLine());

            Foe[] foes = new Foe[enemyNum];

            for (int i = 0; i < foes.Length; i++)
            {
                Console.WriteLine($"Input enemy #{i + 1}'s name:");
                foes[i] = new Foe(Console.ReadLine());
            }

            Console.WriteLine("Enemies:");
            for (int i = 0; i < foes.Length; i++)
            {
                Console.WriteLine($"{i + 1}-{foes[i].GetName()}");
            }
            Console.WriteLine($"{foes[0].GetName()}'s health: {foes[0].GetHealth()}");
            Console.WriteLine($"{foes[0].GetName()}'s shield: {foes[0].GetShield()}");

            Console.WriteLine("Pickup 50 shield");
            foes[0].PickupPowerUp(PowerUp.Shield, 50f);

            Console.WriteLine($"{foes[0].GetName()}'s health: {foes[0].GetHealth()}");
            Console.WriteLine($"{foes[0].GetName()}'s shield: {foes[0].GetShield()}");

            Console.WriteLine("Take 70 damage");
            foes[0].TakeDamage(70f);

            Console.WriteLine($"{foes[0].GetName()}'s health: {foes[0].GetHealth()}");
            Console.WriteLine($"{foes[0].GetName()}'s shield: {foes[0].GetShield()}");

            Console.WriteLine("Pickup 100 health");
            foes[0].PickupPowerUp(PowerUp.Health, 100f);

            Console.WriteLine($"{foes[0].GetName()}'s health: {foes[0].GetHealth()}");
            Console.WriteLine($"{foes[0].GetName()}'s shield: {foes[0].GetShield()}");

            Console.WriteLine($"PowerUps picked up: {Foe.GetPowerupCount()}");


            Console.WriteLine("Merci d’utiliser ce programme!");

        }

    }
}
