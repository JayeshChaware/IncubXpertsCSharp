using System;

namespace IX_Projects
{
    class Program 
    {
        static void Main(string[] args)
        {
           
            
            Bike Apache160_4V = new Bike("TVS", 160, 2, 2);
            Bike Apache200_4V = new Bike("TVS", 200, 2, 2);

            Car Swift = new Car("Maruti Suzuki", 1200, 4, 5);
            Car Celerio = new Car("Maruti Suzuki", 1000, 4, 5);
            Apache160_4V.ViewBike();
            Apache200_4V.ViewBike();
            Swift.ViewCar();
            Celerio.ViewCar();
        }
    }
}
