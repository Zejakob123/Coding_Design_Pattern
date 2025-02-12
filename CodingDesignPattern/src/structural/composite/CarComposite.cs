namespace CodingDesignPattern.src.structural.composite
{
    // Composite - A collection of car parts
    public class CarComposite : ICarComponent
    {
        private string _name;
        private List<ICarComponent> _components = new List<ICarComponent>();

        public CarComposite(string name)
        {
            _name = name;
        }

        public void AddComponent(ICarComponent component)
        {
            _components.Add(component);
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Car Component: {_name}");
            foreach (var component in _components)
            {
                component.ShowDetails();
            }
        }
    }
}