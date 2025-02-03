namespace CodingDesignPattern.src.structural.adapter
{
    public class USB_A_To_TypeC_Adapter : ITypeCCharger
    {
        private readonly USB_A_Charger _usbACharger;

        public USB_A_To_TypeC_Adapter(USB_A_Charger usbACharger)
        {
            _usbACharger = usbACharger;
        }

        public void ChargeWithTypeC()
        {
            Console.WriteLine("Using adapter to convert USB-A to Type-C...");
            _usbACharger.ChargeWithUSB_A();  // Calling the existing method
        }
    }
}