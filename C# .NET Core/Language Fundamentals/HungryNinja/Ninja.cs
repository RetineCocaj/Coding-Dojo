using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;
        
        // add a constructor
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }
        // add a public "getter" property called "IsFull"
        public bool IsFull{
            get{ return calorieIntake > 1200; }
        }
        // build out the Eat method
        public void Eat(Food item)
        {
            if(!IsFull)
            {
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
                string spicy = item.IsSpicy? "spicy":"not spicy";
                string sweet = item.IsSpicy? "sweet":"not sweet";
                Console.WriteLine($"{item.Name} is {spicy} and is {sweet}");
            }
            else
            {
                Console.WriteLine("The ninja cannot eat anymore, because it is full");;
            }
        }
    }
}
