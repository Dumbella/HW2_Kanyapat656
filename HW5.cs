using System;

namespace Homework5
{
    class Program
    {
        static double[,] ReadImageDataFromFile(string imageDataFilePath)
        {
            string[] lines = System.IO.File.ReadAllLines(imageDataFilePath);
            int imageHeight = lines.Length;
            int imageWidth = lines[0].Split(',').Length;
            double[,] imageDataArray = new double[imageHeight, imageWidth];

            for (int i = 0; i < imageHeight; i++)
            {
                string[] items = lines[i].Split(',');
                for (int j = 0; j < imageWidth; j++)
                {
                    imageDataArray[i, j] = double.Parse(items[j]);
                }
            }
            return imageDataArray;
        }

        static void WriteImageDataToFile(string imageDataFilePath,
                                 double[,] imageDataArray)
        {
            string imageDataString = "";
            for (int i = 0; i < imageDataArray.GetLength(0); i++)
            {
                for (int j = 0; j < imageDataArray.GetLength(1) - 1; j++)
                {
                    imageDataString += imageDataArray[i, j] + ", ";
                }
                imageDataString += imageDataArray[i,
                                                imageDataArray.GetLength(1) - 1];
                imageDataString += "\n";
            }

            System.IO.File.WriteAllText(imageDataFilePath, imageDataString);
        }

        static double[,] Table(double[,] imagedataarray2)
        {
            double[,] imagedatarray3 = new double[7, 7];

            for (int i = 0; i <= 6; i++)
            {
                for (int j = 0; j <= 6; j++)
                {
                    if (i == 0 && (j >= 1 && j <= 5))
                    {
                        imagedatarray3[i, j] = imagedataarray2[i + 4, j - 1];
                    }
                    else if (j == 6 && (i >= 1 && i <= 5))
                    {
                        imagedatarray3[i, j] = imagedataarray2[i - 1, j - 6];
                    }
                    else if (i == 6 && (j >= 1 && j <= 5))
                    {
                        imagedatarray3[i, j] = imagedataarray2[i - 6, j - 1];
                    }
                    else if (j == 0 && (i >= 1 && i <= 5))
                    {
                        imagedatarray3[i, j] = imagedataarray2[i - 1, j + 4];
                    }
                    else if (i == 0 && j == 0)
                    {
                        imagedatarray3[i, j] = imagedataarray2[4, 4];
                    }
                    else if (i == 0 && j == 6)
                    {
                        imagedatarray3[i, j] = imagedataarray2[4, 0];
                    }
                    else if (i == 6 && j == 6)
                    {
                        imagedatarray3[i, j] = imagedataarray2[0, 0];
                    }
                    else if (i == 6 && j == 0)
                    {
                        imagedatarray3[i, j] = imagedataarray2[0, 4];
                    }
                    else
                        imagedatarray3[i, j] = imagedataarray2[i - 1, j - 1];
                }
            }

            return imagedatarray3;
        }

        static double[,] ConvolutionKernel(double[,] imagedataarray3, double[,] imagedataarray7)
        {
            double[,] imagedatarray5 = new double[5, 5];

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    double pixel1 = imagedataarray7[i - 1, j - 1] * imagedataarray3[0, 0];
                    double pixel2 = imagedataarray7[i - 1, j] * imagedataarray3[0, 1];
                    double pixel3 = imagedataarray7[i - 1, j + 1] * imagedataarray3[0, 2];
                    double pixel4 = imagedataarray7[i, j - 1] * imagedataarray3[1, 0];
                    double pixel5 = imagedataarray7[i, j] * imagedataarray3[1, 1];
                    double pixel6 = imagedataarray7[i, j + 1] * imagedataarray3[1, 2];
                    double pixel7 = imagedataarray7[i + 1, j - 1] * imagedataarray3[2, 0];
                    double pixel8 = imagedataarray7[i + 1, j] * imagedataarray3[2, 1];
                    double pixel9 = imagedataarray7[i + 1, j + 1] * imagedataarray3[2, 2];

                    double sum = pixel1 + pixel2 + pixel3 + pixel4 + pixel5 + pixel6 + pixel7 + pixel8 + pixel9;

                    imagedatarray5[i - 1, j - 1] = sum;
                }
            }

            return imagedatarray5;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Input file location: ");
            string fileInput = Console.ReadLine();
            Console.WriteLine("Enter Convolution file location: ");
            string convolvePAth = Console.ReadLine();
            Console.WriteLine("Enter Output file location: ");
            string Output = Console.ReadLine();

            ReadImageDataFromFile(convolvePAth);

            double[,] tempImgInput = ReadImageDataFromFile(fileInput);
            double[,] imagedataarray3 = Table(tempImgInput);

            double[,] tempConvol = ReadImageDataFromFile(convolvePAth);

            double[,] imagedataarray5 = ConvolutionKernel(tempConvol, imagedataarray3);

        }
    }
}
