using System;

namespace hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Agency;
            bool corect = true;
            bool wrong = false;
            int one,two,three,four,five,six;
            
            Console.Write("Please input your password : ");
            one = int.Parse(Console.ReadKey().KeyChar.ToString());
            two = int.Parse(Console.ReadKey().KeyChar.ToString()); 
            three = int.Parse(Console.ReadKey().KeyChar.ToString());
            four = int.Parse(Console.ReadKey().KeyChar.ToString());
            five = int.Parse(Console.ReadKey().KeyChar.ToString());
            six = int.Parse(Console.ReadKey().KeyChar.ToString());
            Console.Write(" Please input your Agency abbreviations : ");
            Agency = Console.ReadLine();

            if (Agency == "CIA"&& six % 3 == 0 && five != 1 && five != 3 && five != 5 && three >=6&& three!=8)
            {
                Console.WriteLine(corect);
            }
            else if (Agency == "FBI" && one >=4 && one <=7 && four % 2==0 && four!=6 && two % 2 !=0)
            {
                Console.WriteLine(corect);
            }
            else if (Agency == "NSA" && six %30==0 && four % 3==0 && four %2 != 0 && ( one == 7 || two == 7 || three == 7 || four == 7 || five == 7 || six ==7))
            {
                Console.WriteLine(corect);
            }
            else if (Agency != "CIA" && Agency != "FBI" && Agency != "NSA")
            {
                Console.WriteLine(wrong);
            }
            else
            {
                Console.WriteLine(wrong);
            }

        }
    }
}
