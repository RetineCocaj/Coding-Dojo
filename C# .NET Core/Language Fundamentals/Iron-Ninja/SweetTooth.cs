using System;
namespace Iron_Ninja
{
    class SweetTooth : Ninja
    {
        // provide override for IsFull (Full at 1500 Calories)
        public override bool IsFull 
        {
            get
            {
                return calorieIntake > 1500;
            }
        }
        public override void Consume(IConsumable item)
        {
            if(IsFull)
                Console.WriteLine("SweetTooth is FULL, cannot eat anymore");
            else
            {
                int currentCalories = item.Calories;
                if(item.IsSweet) currentCalories += 10;
                calorieIntake += currentCalories;
                ConsumptionHistory.Add(item);
                item.GetInfo();
            }

        }
    }
}