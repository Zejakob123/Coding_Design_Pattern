namespace CodingDesignPattern.src.behavioural.chainOfResponsibility
{
    public class OilChangeHandler : CarServiceHandler
    {
        public override void HandleRequest(string service)
        {
            if (service == "Oil Change")
            {
                Console.WriteLine("Performing Oil Change...");
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