namespace CodingDesignPattern.src.behavioural.chainOfResponsibility
{
    public class BasicInspectionHandler : CarServiceHandler
    {
        public override void HandleRequest(string service)
        {
            if (service == "Basic Inspection")
            {
                Console.WriteLine("Performing Basic Inspection...");
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