namespace CodingDesignPattern.src.creational.builder
{
    public class GamingComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();

        public void SetCPU() => _computer.CPU = "Intel Core i9";
        public void SetGPU() => _computer.GPU = "NVIDIA RTX 3080";
        public void SetRAM() => _computer.RAM = 32;
        public void SetStorage() => _computer.Storage = 1000;
        public void SetWiFi() => _computer.HasWiFi = true;
        public void SetBluetooth() => _computer.HasBluetooth = true;

        public Computer GetComputer() => _computer;
    }
}
