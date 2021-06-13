using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 1
{
    class Program
    {
        static void Main(string[] args)
        {
            GetData(false);
            GetData(true);
            Console.ReadLine();
        }

        public static void GetData(bool isSecondtime)
        {
            int[] row1 = new int[3];
            int[] row2 = new int[3];
            int[] row3 = new int[3];
            string blankPos = "";
            int replaceValue;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    switch (i)
                    {
                        case 0:
                            int input0 = int.Parse(Console.ReadLine());
                            if (input0 == 0) { blankPos = i + "" + j; }
                            else { row1[j] = input0; }
                            break;
                        case 1:
                            int input1 = int.Parse(Console.ReadLine());
                            if (input1 == 0) { blankPos = i + "" + j; }
                            else { row2[j] = input1; }
                            break;
                        case 2:
                            int input2 = int.Parse(Console.ReadLine());
                            if (input2 == 0) { blankPos = i + "" + j; }
                            else { row3[j] = input2; }
                            break;
                    }
                }
            }
            replaceValue = int.Parse(Console.ReadLine());

            OutputArray(row1, row2, row3);

            int row = (int)Char.GetNumericValue(blankPos[0]);
            int column = (int)Char.GetNumericValue(blankPos[1]);


            if (isSecondtime)
            {
                bool isAvailable = false;
                
                if(row == 0)
                {
                    for (int i = 0; i < row1.Length; i++)
                    {
                        if(row1[i] == replaceValue)
                        {
                            isAvailable = true;
                        }
                    }
                }
                else
                {
                    if (row1[column] == replaceValue)
                    {
                        isAvailable = true;
                    }
                }

                if (row == 1)
                {
                    for (int i = 0; i < row2.Length; i++)
                    {
                        if (row2[i] == replaceValue)
                        {
                            isAvailable = true;
                        }
                    }
                }
                else
                {
                    if (row2[column] == replaceValue)
                    {
                        isAvailable = true;
                    }
                }

                if (row == 2)
                {
                    for (int i = 0; i < row3.Length; i++)
                    {
                        if (row3[i] == replaceValue)
                        {
                            isAvailable = true;
                        }
                    }
                }
                else
                {
                    if (row3[column] == replaceValue)
                    {
                        isAvailable = true;
                    }
                }

                if (isAvailable)
                {
                    Console.WriteLine("The number is available");
                }
                else
                {
                    switch (row)
                    {
                        case 0:
                            row1[column] = replaceValue;
                            break;
                        case 1:
                            row2[column] = replaceValue;
                            break;
                        case 2:
                            row3[column] = replaceValue;
                            break;
                    }

                    OutputArray(row1, row2, row3);
                }
            }
            else
            {
                switch (row)
                {
                    case 0:
                        row1[column] = replaceValue;
                        break;
                    case 1:
                        row2[column] = replaceValue;
                        break;
                    case 2:
                        row3[column] = replaceValue;
                        break;
                }

                OutputArray(row1, row2, row3);
            }

        }

        public static void OutputArray(int[] row1, int[] row2, int[] row3)
        {
            OutputData(row1);
            Console.WriteLine();
            OutputData(row2);
            Console.WriteLine();
            OutputData(row3);
            Console.WriteLine();
            Console.WriteLine();
        }
        

        public static void OutputData(int[] row)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write(row[i]);
            }
        }
    }
}
