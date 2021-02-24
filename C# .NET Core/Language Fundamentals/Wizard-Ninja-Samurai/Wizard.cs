using System;

namespace Wizard_Ninja_Samurai
{
    class Wizard : Human
    {
        public Wizard(string name):base(name, 3, 25, 3, 50){}
        public override int Attack(Human target)
        {
            int dealt = target.Intelligence * 5;
            target.Health -= dealt;
            return dealt;
        }
        public void Heal(Human target)
        {
            target.Health += (target.Intelligence*10);
        }

    }
}
