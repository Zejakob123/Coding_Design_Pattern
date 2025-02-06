namespace CodingDesignPattern.src.structural.bridge
{
    class BridgeProgram
    {
        public void Run()
        {
            // Using a petrol engine with a sedan
            IEngine petrolEngine = new PetrolEngine();
            Car sedanWithPetrol = new Sedan(petrolEngine);
            sedanWithPetrol.Drive();

            Console.WriteLine();

            // Using an electric engine with an SUV
            IEngine electricEngine = new ElectricEngine();
            Car suvWithElectric = new SUV(electricEngine);
            suvWithElectric.Drive();
        }
    }
}