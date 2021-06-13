using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double[] array = new double[num];

            Console.WriteLine("Please Input Values");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = double.Parse(Console.ReadLine());
            }
            string mode = Console.ReadLine();
            if (mode=="FindMax")
            {

            }
            else if (mode=="FindMin")
            {
                double min = array[0];
                for (int i = 0; i < num; i++)
                {
                    sum = sum + array[i];

                    if (array[i]<min)
                    {
                        min = array[i];
                    }
                }
            }
            else if (mode == "FindMean")
            {
                double sum = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    
                        sum = sum + array[i];
                    
                }
                double avg = sum / num;
                Console.WriteLine("Mean = {0}",avg);
            }
            
            Console.ReadLine();


        }
        
    }
}
