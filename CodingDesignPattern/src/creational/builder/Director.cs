namespace CodingDesignPattern.src.creational.builder
{
    public class Director
    {
        private IComputerBuilder _builder;

        public void SetBuilder(IComputerBuilder builder)
        {
            _builder = builder;
        }

        public Computer BuildComputer()
        {
            _builder.SetCPU();
            _builder.SetGPU();
            _builder.SetRAM();
            _builder.SetStorage();
            _builder.SetWiFi();
            _builder.SetBluetooth();
            return _builder.GetComputer();
        }
    }
}
