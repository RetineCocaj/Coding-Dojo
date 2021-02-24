using System;

namespace Wizard_Ninja_Samurai
{
    class Ninja : Human
    {
        public Ninja(string name) : base(name, 3, 3, 175, 100) {}
        public override int Attack(Human target)
        {
            int damage = target.Dexterity * 5;
            Random rand = new Random();
            if(rand.Next(100) <= 20) damage += 10;
            target.Health -= damage;
            return target.Health;
        }
        public void Steal(Human target)
        {
            target.Health -= 5;
            Health += target.Health;
        }
    }
}
