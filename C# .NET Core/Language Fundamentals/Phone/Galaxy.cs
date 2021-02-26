using System;
namespace Phone
{
    public class Galaxy : Phone, IRingable 
    {
        private bool isUnlocked;
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) { isUnlocked = false; }
        public string Ring() 
        {
            if(!isUnlocked) return Ringtone;
            else return "Zzz zzz zzz";
        }
                    
        public string Unlock() 
        {
            isUnlocked = true;
            return "unlocked with fingerprint scanner";
        }
        public override void DisplayInfo() 
        {
            Console.WriteLine("#############################");
            Console.WriteLine($"Galaxy {VersionNumber}");
            Console.WriteLine($"Battery Percentage: {BatteryPercentage}");
            Console.WriteLine($"Carrier: {Carrier}");
            Console.WriteLine($"Ring Tone: {Ringtone}");        
            Console.WriteLine("#############################");
        }
    }
}