namespace MyOwnCollection
{
    public class Car
    {
        private string _brand;
        private string _name;
        private double _capacity;

        public Car(string brand, string name, double capacity)
        {
            _brand = brand;
            _name = name;
            _capacity = capacity;
        }

        public override string ToString()
        {
            return $"Car - {_brand}, {_name}, {_capacity}";
        }
    }
}
