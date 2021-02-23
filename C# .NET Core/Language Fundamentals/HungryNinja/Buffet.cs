using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Buffet
    {
        public List<Food> Menu;
        
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Oat", 200, false, false),
                new Food("Pizza", 1500, true, false),
                new Food("Apple", 500, false, true),
                new Food("Pasta", 800, true, false),
                new Food("Fli", 700, false, false)
            };
        }
        
        public Food Serve()
        {
            Random random = new Random();
            return Menu[random.Next(Menu.Count)];
        }
    }
}
