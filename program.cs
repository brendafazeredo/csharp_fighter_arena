using System;

namespace csharp_fighter_arena
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Fighter fighter1 = new Fighter("Player 1", 100, 20, 10);
            Fighter fighter2 = new Fighter("Player 2", 100, 18, 12);

            while (fighter1.Health > 0 && fighter2.Health > 0)
            {
                fighter1.Attack(fighter2);
                fighter2.Attack(fighter1);

                Console.WriteLine($"{fighter1.Name} Health: {fighter1.Health} | {fighter2.Name} Health: {fighter2.Health}");
            }

            if (fighter1.Health <= 0)
                Console.WriteLine($"{fighter2.Name} wins!");
            else
                Console.WriteLine($"{fighter1.Name} wins!");
        }
    }
}