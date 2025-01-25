namespace CodingDesignPattern.src.behavioural.chainOfResponsibility
{
    public class CORProgram
    {
        public void Run()
        {
            // Set up the chain
            CarServiceHandler basicInspection = new BasicInspectionHandler();
            CarServiceHandler oilChange = new OilChangeHandler();
            CarServiceHandler tireRotation = new TireRotationHandler();

            basicInspection.SetNext(oilChange);
            oilChange.SetNext(tireRotation);

            // Process requests
            Console.WriteLine("Requesting 'Oil Change':");
            basicInspection.HandleRequest("Oil Change");

            Console.WriteLine("\nRequesting 'Tire Rotation':");
            basicInspection.HandleRequest("Tire Rotation");

            Console.WriteLine("\nRequesting 'Car Wash':");
            basicInspection.HandleRequest("Car Wash");
        }
    }
}