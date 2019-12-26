using System;
using System.Collections.Generic;
using System.Text;

namespace Дз_14
{
    class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Power { get; set; }
        public bool IsDeath { get; set; }

        public void Attack()
        {
            Console.WriteLine($"{Name} attack");
        }
    }
    class FlyEnemy : Enemy
    {
        public void Fly()
        {
            Console.WriteLine($"{Name} believes he can fly");
        }
    }
    class RunAndFlyEnemy : FlyEnemy
    {
        public void Run()
        {
            Console.WriteLine($"Run {Name} run");
        }
    }
    class Boss : RunAndFlyEnemy
    {
        public void Jump()
        {
            Console.WriteLine($"{Name} jumps");
        }
        public void Swim()
        {
            Console.WriteLine($"{Name} swims");
        }

    }
    class Player : RunAndFlyEnemy
    {
        public void Magic()
        {
            Console.WriteLine("i will turn you into a frog!!!");
        }
    }
}
