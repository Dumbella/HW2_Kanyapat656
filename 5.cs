using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {

            int numItem = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numItem; i++)
            {
                string nameItem = Console.ReadLine();
                string typeItem = Console.ReadLine();

            }
            string mode = Console.ReadLine();
            if (mode == "ShowAll")
            {
                for (int i = 1; i <= numItem; i++)
                {
                    Console.WriteLine("{0}", nameItem);
                    Console.WriteLine("{0}", typeItem);
                    Console.WriteLine();

                }
            }
            else if (mode=="End")
            {
                Console.ReadLine();
            }
        }



    }

}
