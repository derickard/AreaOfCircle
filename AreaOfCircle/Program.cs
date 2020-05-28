using System;

namespace AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = -1;
            double mpg;
            do
            {
                try
                {
                    Console.Write("Enter a radius: ");
                    radius = double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Radius must be a number!");
                }
            } while (radius < 0);

            Circle myCircle = new Circle(radius);

            Console.WriteLine($"The circle of radius {myCircle.radius} has:\nArea: {myCircle.area}\nCircumference: {myCircle.circumference}\nDiameter: {myCircle.diameter}");

            Console.Write("\nWhat is your car's mph?: ");
            mpg = double.Parse(Console.ReadLine());
            Console.WriteLine($"With a gas milegae of {mpg}, you need {myCircle.circumference / mpg} gallons of gas to drive around this circle.");




        }
    }
}
