using System;

namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = Console.ReadLine();
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double t, p;

             if (x < 0)
            {
                Console.WriteLine("Invalid mouse position");
            }
            else if(mode == "time" && x>0)
            {   
                p =  Math.Pow(x - 1, 2);
                Console.WriteLine("{0},{1}",x,p);
            }
            else if(mode == "price" && x>0)
            {
                t = Math.Sqrt(y) + 1;
                Console.WriteLine("{0},{1}", t, y);
            }            
            else
            {
                Console.WriteLine("Invalid mode");
            }
        }
    }
}
