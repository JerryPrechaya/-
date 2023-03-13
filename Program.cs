using System;
namespace workshopweek4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double w1 = double.Parse(Console.ReadLine());
            double h1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double w2 = double.Parse(Console.ReadLine());
            double h2 = double.Parse(Console.ReadLine());

            if ((x1 - w1) < (x2 + w2) && (y1 + h1) > (y2 - h2))
            {
                if (((x2 + w2) - (x1 - w1)) * ((y1 + h1) - (y2 - h2)) > 8)
                {
                    Console.WriteLine("Too Much Overlaping");
                }
                else if (((x2 + w2) - (x1 - w1)) * ((y1 + h1) - (y2 - h2)) <= 8)
                {
                    Console.WriteLine("Not Much Overlapping");
                }
            }
            else if ((x1 + w1) > (x2 - w2) && (y1 - h1) < (y2 + h2))
            {
                if (((x1 + w1) - (x2 - w2)) * ((y2 + h2) - (y1 - h1)) > 8)
                {
                    Console.WriteLine("Too Much Overlaping");
                }
                else if (((x1 + w1) - (x2 - w2)) * ((y2 + h2) - (y1 - h1)) <= 8)
                {
                    Console.WriteLine("Not Much Overlapping");
                }
            }
            else
            {
                Console.WriteLine("No Overlapping");
            }
        }
    }
}

