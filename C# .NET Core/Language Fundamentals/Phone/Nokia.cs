using System;
namespace Phone
{
    public class Nokia : Phone, IRingable 
    {
        private bool isUnlocked;
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) { isUnlocked = false; }
        public string Ring() 
        {
            return Ringtone;
        }
        public string Unlock() 
        {
            return "unlocked with passcode";
        }
        public override void DisplayInfo() 
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$"); 
            Console.WriteLine($"Nokia {VersionNumber}");
            Console.WriteLine($"Battery Percentage: {BatteryPercentage}");
            Console.WriteLine($"Carrier: {Carrier}");
            Console.WriteLine($"Ring Tone: {Ringtone}");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$"); 
        }
    }
}