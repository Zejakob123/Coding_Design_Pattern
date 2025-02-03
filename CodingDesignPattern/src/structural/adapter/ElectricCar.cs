namespace CodingDesignPattern.src.structural.adapter
{
    public class ElectricCar
    {
        private readonly ITypeCCharger _charger;

        public ElectricCar(ITypeCCharger charger)
        {
            _charger = charger;
        }

        public void Charge()
        {
            Console.WriteLine("Electric car is charging...");
            _charger.ChargeWithTypeC();
        }
    }
}