using System;

namespace Iron_Ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet b = new Buffet();
            SweetTooth st = new SweetTooth();
            SpiceHound sh = new SpiceHound();

            while(!st.IsFull) st.Consume(b.Serve());

            while(!sh.IsFull) sh.Consume(b.Serve());

            if(st.ConsumptionHistory.Count > sh.ConsumptionHistory.Count) 
                Console.WriteLine($"SweetTooth consumed more items, with number of items {st.ConsumptionHistory.Count}");
            else 
                Console.WriteLine($"SpiceHound consumed more items, with number of items {sh.ConsumptionHistory.Count}");
        }
    }
}
