using System;
namespace Dojodachi.Models
{
    public class Dachi
    {
        private int? happiness;
        private int? fullness;
        private int? energy;
        private int? meals;

        private static int feedCost = 1; 
        private static int playCost = 5; 
        private static int workCost = 5; 
        private static int sleepCost = 5; 

        public int Happiness 
        { 
            get 
            { 
                if(happiness != null) return (int)happiness;
                else return 0;
            }
            set { happiness = (int?)value; }
        }

        public int Fullness
        { 
            get 
            { 
                if(fullness != null) return (int)fullness;
                else return 0;
            }
            set { fullness = (int?)value; }
        }

        public int Energy
        { 
            get 
            { 
                if(energy != null) return (int)energy;
                else return 0;
            }
            set { energy = (int?)value; }
        }

        public int Meals
        { 
            get 
            { 
                if(meals != null) return (int)meals;
                else return 0;
            }
            set { meals = (int?)value; }
        }

        public Dachi()
        {
            happiness = 20;
            fullness = 20;
            energy = 50;
            meals = 3;
        }
        
        public Dachi(int? happiness, int? fullness, int? energy, int? meals)
        {
            this.happiness = happiness;
            this.fullness = fullness;
            this.energy = energy;
            this.meals = meals;
        }

        public bool IsAWin
        {
            get { return (energy > 100 && fullness > 100 && happiness > 100); }
        }

        public bool IsALoss
        {
            get { return (fullness < 0 || happiness < 0); }
        }

        public bool DidLike
        {
            get { return new Random().Next(100) > 25; }
        }

        public string Play(string gameType)
        {
            Random rand = new Random();
            bool didLike = DidLike;

            if(gameType == "feed")
            {
                int addedFullness = rand.Next(5,11);
                Meals -= feedCost;
                if(Meals > 0 && didLike)
                {
                    Fullness += addedFullness;
                }
                return (didLike)
                    ? $"You fed your Dojodachi. Fullness: +{addedFullness}, Meals -{feedCost}"
                    : $"You tried to feed your Dojodachi, but it didn't like it! Meals -{feedCost}";

            }
            if(gameType == "play")
            {
                Energy -= playCost;
                int addedHappiness = rand.Next(5, 11);
                if(didLike)
                {
                    Happiness += addedHappiness;
                    return $"You played with your Dojodachi. Happiness: +{addedHappiness}, Energy: -{playCost}";
                }
                return $"You played with your Dojodachi, but it didn't like :( Energy: -{playCost}";
            }
            else if(gameType == "work")
            {
                int addedMeals = rand.Next(1,4);
                Energy -= workCost;
                Meals += addedMeals;
                return $"You worked your Dojodachi. Meals: +{addedMeals}, Energy: -{workCost}";
            }
            else
            {
                Energy += 15;
                Fullness -= sleepCost;
                Happiness -= sleepCost;
                return $"You rested your Dojodachi. Energy: +{15}, Fullness: -{sleepCost} Happiness -{sleepCost}";
            }
        }
    }
}