using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    internal interface IMovable
    {
        public void Move();
    }

    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Main1
    {
        public static void main(string[] args)
        {
            Car myCar = new Car();
            Bicycle mybike = new Bicycle();

            myCar.Move();
            mybike.Move();
        }
    }
