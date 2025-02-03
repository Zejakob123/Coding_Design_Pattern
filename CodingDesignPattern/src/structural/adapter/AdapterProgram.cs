namespace CodingDesignPattern.src.structural.adapter
{
    class AdapterProgram
    {
        public void Run()
        {
            // Existing charger with USB-A (incompatible)
            USB_A_Charger usbACharger = new USB_A_Charger();

            // Using the adapter to make USB-A compatible with Type-C
            ITypeCCharger adapter = new USB_A_To_TypeC_Adapter(usbACharger);

            // Electric car that expects Type-C charging
            ElectricCar car = new ElectricCar(adapter);

            // Charge the car using the adapter
            car.Charge();
        }
    }
}