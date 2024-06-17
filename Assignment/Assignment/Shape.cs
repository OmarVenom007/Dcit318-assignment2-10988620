using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    abstract class Shape
    {
        public abstract double GetArea( );
    }

    class Circle : Shape {

        public double r;
        public Circle( double r)
        {
            this.r = r;
        }
        public override double GetArea() {
            return 3.142 * r * r ;
        }
 
    }

    class Rectangle : Shape
    {
        public double x, y;
        public Rectangle( double x, double y )
        {
            this.x = x;
            this.y = y;
        }
        public override double GetArea()
        {
            return x * y;
        }

    }

    class Main
    {
        public static void main(string[] args)
        {
            Circle circ = new Circle(5);
            Rectangle rec = new Rectangle(5, 6);

            Console.WriteLine("The area of the cicle is: " + circ.GetArea());
            Console.WriteLine("The area of the rectangle is: " + rec.GetArea());
        }
    }
}
