using System;

namespace csharp_fighter_arena
{

    class Fighter
    {
        public string Name { get; }
        public int Health { get; private set; }
        public int AttackPower { get; }
        public int Defense { get; }

        public Fighter(string name, int health, int attackPower, int defense)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            Defense = defense;
        }

        public void Attack(Fighter target)
        {
            int damage = Math.Max(AttackPower - target.Defense, 0);
            target.Health -= damage;
            Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage!");
        }
    }
}