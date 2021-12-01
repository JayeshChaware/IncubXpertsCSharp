using System;
using System.Collections.Generic;
using System.Text;

namespace IX_Projects
{
    public class Vehicle
    {
        public string Company { get; set; }
        public bool Start { get; set; }
        public float Speedometer { get; set; }
        public int Engine { get; set; }
        
    }

    class Car : Vehicle 
    {
        public int Wheels { get; set; }
        public int Seat { set; get; }
        public string Type { get; set; }
        public Car(string company, int engine, int wheels, int seat)
        {
            string company1 = company;
            Company = company1;
            Engine = engine;
            Wheels = wheels;
            Seat = seat;
        }
        public void ViewCar()
        {
            Console.WriteLine("Car brand is {0}, Engine is {1}cc, it has {2} wheels, it is {3} seater", Company, Engine, Wheels, Seat);

        }
    }

    class Bike : Vehicle
    {
        public int Wheels { get; set; }
        public int Seat { set; get; }
        public string Type { get; set; }
        public Bike(string company, int engine, int wheels, int seat)
        {
            string company1 = company;
            Company = company1;
            Engine = engine;
            Wheels = wheels;
            Seat = seat;
        }
        public void ViewBike()
        {
            Console.WriteLine("Bike brand is {0}, Engine is {1}cc, it has {2} wheels, it is {3} seater", Company, Engine, Wheels, Seat);

        }
    }
    class Pickup : Vehicle
    { 
        public int Capacity { get; set; }
        public int Wheels { get; set; }
        public int Seat { set; get; }
        public Pickup(string company, int engine, int capacity, int wheels, int seat) {
            string company1 = company;
            Company = company1;
            Engine = engine;
            Capacity = capacity;
            Wheels = wheels;
            Seat = seat;
        }
        public void ViewPickup()
        {
            Console.WriteLine("pickup truck brand is {0}, Engine is {1}cc, pickup capacity is {2}, it has {3} wheels, it is {4} seater",Company,Engine,Capacity,Wheels,Seat);
        }



    }

}
