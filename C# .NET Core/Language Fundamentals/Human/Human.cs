using System;

namespace Human
{
    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int Health;
        
        // add a public "getter" property to access health
        public int GetHealth
        {
            get { return Health; }
        }
        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            Health = 100;
        }
        // Add a constructor to assign custom values to all fields
        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }
        // Build Attack method
        public int Attack(Human target)
        {
            int damage  = Strength * 3;
            target.Health -= damage;
            Console.WriteLine($"{Name} attacked {target.Name} for {damage} damage!");
            return target.Health;
        }

        public static void Main(string[] args)
        {
            Human human1 = new Human("Rachel", 5, 5, 5, 50);
            Human human2 = new Human("Joe");
            human2.Attack(human1);
        }
    }
}
