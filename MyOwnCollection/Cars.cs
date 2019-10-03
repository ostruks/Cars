using System.Collections.Generic;

namespace MyOwnCollection
{
    public class Cars
    {
        private IList<Car> _cars;

        public Cars()
        {
            _cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            if (car != null)
                _cars.Add(car);
        }

        public void RemoveCar(Car car)
        {
            if (car != null)
                _cars.Remove(car);
        }

        public IEnumerable<Car> GetCars()
        {
            for(int i = 0; i < _cars.Count; i++)
            {
                yield return _cars[i];
            }
        }
    }
}
