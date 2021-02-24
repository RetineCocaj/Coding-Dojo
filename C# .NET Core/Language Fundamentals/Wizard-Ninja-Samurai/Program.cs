using System;

namespace Wizard_Ninja_Samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Retina");
            Ninja ninja = new Ninja("Ninja");
            Console.WriteLine(ninja.Health);
            ninja.Steal(human);
            Console.WriteLine(ninja.Health);
        }
    }
}
