using System;

namespace HungryNinja
{
    class Program
    {
        static void Main(String[] args)
        {
            Ninja ninja = new Ninja();
            Buffet buffet = new Buffet();
            while(!ninja.IsFull){
                ninja.Eat(buffet.Serve());
            }
        }
    }
}
