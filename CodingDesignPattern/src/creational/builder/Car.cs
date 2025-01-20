namespace CodingDesignPattern.src.creational.builder
{
    public class Computer
    {
        public string CPU { get; set; }
        public string GPU { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }
        public bool HasWiFi { get; set; }
        public bool HasBluetooth { get; set; }

        public override string ToString()
        {
            return $"Computer Configuration:\n" +
                   $"CPU: {CPU}\nGPU: {GPU}\nRAM: {RAM} GB\nStorage: {Storage} GB\n" +
                   $"WiFi: {HasWiFi}\nBluetooth: {HasBluetooth}";
        }
    }
}
