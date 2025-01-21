namespace CodingDesignPattern.src.creational.prototype
{
    public class PrototypePatternDemo
    {
        public void Run()
        {
            // Create initial prototypes
            Sedan sedanPrototype = new Sedan("Standard Sedan", "1.8L", 5);
            SUV suvPrototype = new SUV("Standard SUV", "2.0L", 200);

            // Clone prototypes to create new instances
            Sedan clonedSedan = (Sedan)sedanPrototype.Clone();
            clonedSedan.Model = "Luxury Sedan"; // Modify the clone
            clonedSedan.Engine = "2.0L Turbo";

            SUV clonedSUV = (SUV)suvPrototype.Clone();
            clonedSUV.Model = "Offroad SUV"; // Modify the clone
            clonedSUV.GroundClearance = 250;

            // Display information
            sedanPrototype.DisplayInfo(); // Original prototype
            clonedSedan.DisplayInfo();    // Cloned and modified

            suvPrototype.DisplayInfo();   // Original prototype
            clonedSUV.DisplayInfo();      // Cloned and modified
        }
    }
}