using System;
namespace Iron_Ninja
{
        class SpiceHound : Ninja
    {
        // provide override for IsFull (Full at 1200 Calories)
        public override bool IsFull
        {
            get
            {
                return calorieIntake > 1200;
            }
        }
        public override void Consume(IConsumable item)
        {
            if(IsFull)
                Console.WriteLine("SpicyHound is FULL, cannot eat anymore");
            else
            {
                int currentCalories = item.Calories;
                if(item.IsSpicy) currentCalories -= 5;
                calorieIntake += currentCalories;
                ConsumptionHistory.Add(item);
                item.GetInfo();
            }
        }
    }
}