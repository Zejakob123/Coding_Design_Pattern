namespace CodingDesignPattern.src.creational.builder
{
    public interface IComputerBuilder
    {
        void SetCPU();
        void SetGPU();
        void SetRAM();
        void SetStorage();
        void SetWiFi();
        void SetBluetooth();
        Computer GetComputer();
    }
}
