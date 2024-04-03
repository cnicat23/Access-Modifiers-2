using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Gallery
    {
        private int _id;
        public int Id { get; set; }
        public string Name { get; set; }

        public Gallery()
        {
            _id++;
            Id = _id;
        }

        Car[] Cars = new Car[] { };
        public void AddCar(Car car)
        {
            Array.Resize(ref Cars, Cars.Length + 1);
            Cars[Cars.Length - 1] = car;
        }

        public void ShowAllCars()
        {
            if (Cars.Length > 0)
            {
                for (int i = 0; i < Cars.Length; i++)
                {
                    Console.WriteLine($"{Cars[i].Id}\n{Cars[i].Name}\n{Cars[i].CarCode}");
                }
            }
            else
            {
                Console.WriteLine("masin yoxdu");
            }
            
        }

        public Car[] GetAllCars()
        {
            return Cars;
        }
        public Car FindCarById(int id)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].Id == id)
                {
                    return Cars[i];
                }
            }

            return null;
        }
        public Car FindCarByCarCode(string carCode) 
        {

            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].CarCode == carCode)
                {
                    return Cars[i];
                }
            }
            return null;
        }
        public Car[] FindCarsBySpeedInterval(double minSpeed, double maxSpeed)
        {
            Car[] filteredCars = new Car[] { };
            for (int i = 0; i < Cars.Length; i++)
            {
                if (Cars[i].Speed >= minSpeed && Cars[i].Speed <= maxSpeed)
                {
                    Array.Resize(ref filteredCars, filteredCars.Length + 1);
                    filteredCars[filteredCars.Length - 1] = Cars[i];
                }

            }
            return filteredCars;
        }
    }
}

