namespace CodingDesignPattern.src.behavioural.chainOfResponsibility
{
    public class TireRotationHandler : CarServiceHandler
    {
        public override void HandleRequest(string service)
        {
            if (service == "Tire Rotation")
            {
                Console.WriteLine("Performing Tire Rotation...");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(service);
            }
            else
            {
                Console.WriteLine($"Service '{service}' not handled.");
            }
        }
    }
}