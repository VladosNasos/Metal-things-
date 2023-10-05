using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ht_sharaga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // distance betwen circles r/10

            Console.Write("Lenght: ");
            int lenght= int.Parse(Console.ReadLine());
            Console.Write("Width: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("weight: ");
            int weight=int.Parse(Console.ReadLine());
            Console.Write("R: ");
            int r= int.Parse(Console.ReadLine());

            double remainingMetal = CalcScrap(lenght, width, weight, r);

            Console.WriteLine("Answer is "+remainingMetal);

        }
        static double CalcScrap(double length1, double width1, double weight1, double r1)
        {
            // area of 1 circle
            double circleArea = Math.PI * r1 * r1;

            // calculating total amount of cirlces
            double numCircles = (length1 - (r1 / 10)) / (2 * r1);

            // calculating total area of circles 
            double totalCircleArea = numCircles * circleArea;

            // final calculations
            double remainingMetal = weight1 - (totalCircleArea * width1);

            return remainingMetal;
        }
    }
}
