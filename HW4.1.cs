using System;

namespace homework4._1
{
    class Program

    {
        static void printPascal(int n)
        {

            
            for (int line = 0; line < n; line++)
            {

                for (int i = 0; i <= line; i++)
                {
                    string ans = binomialCoeff(line, i) + " ";
                    Console.Write(ans);

                    
                }
                Console.WriteLine("");
            }
        }

       
        static int binomialCoeff(int n, int k)
        {
            int res = 1;

            if (k > n - k)
                k = n - k;

            for (int i = 0; i < k; ++i)
            {
                res *= (n - i);
                res /= (i + 1);
            }
            return res;
        }

        public static void Main()
        {
            Console.Write("input row: ");
            int row = int.Parse(Console.ReadLine());
            

            while (row < 0)
            {
                Console.WriteLine("Invalid Pascal's triangle row number.");
                Console.Write("input row: ");
                row = int.Parse(Console.ReadLine());
                
            }

            printPascal(row);
            
                
           
        }
    }

}

