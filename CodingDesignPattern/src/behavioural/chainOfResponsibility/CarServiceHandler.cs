namespace CodingDesignPattern.src.behavioural.chainOfResponsibility
{
    public abstract class CarServiceHandler
    {
        protected CarServiceHandler _nextHandler;

        public void SetNext(CarServiceHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void HandleRequest(string service);
    }
}