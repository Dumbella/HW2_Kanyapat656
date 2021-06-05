using System;

namespace HW6._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
                int cupcake;
                Console.Write("Take your cupcake do you want to buy : ");
                cupcake = int.Parse(Console.ReadLine());
                Console.Write("Large : " + cupcake / 6 + ",");
                cupcake = cupcake % 6;
                Console.Write("Medium : " + cupcake / 4 + ",");
                cupcake = cupcake % 4;
                if (cupcake != 0)
                {

                    Console.Write("Small : " + cupcake / 2);
                }
                else
                {
                    cupcake++;
                    Console.Write("Small : " + cupcake / 2);
                }
        }
    }
}
    

