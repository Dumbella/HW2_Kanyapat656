using System;

namespace HW6
{

    class Program
    {
        enum Difficulty
        {
            Easy,
            Normal,
            Hard
        }

        struct Problem
        {
            public string Message;

            public int Answer;

            public Problem(string message, int answer)
            {
                Message = message;
                Answer = answer;
            }
        }

        static void Menu(double point, int Difficultypass)
        {

            int page;
            int a = 0;
            double Qc = 0;
            while (a != 1)
            {
                Console.WriteLine("Do you want to go?");
                Console.WriteLine("press 0 to Game  page");
                Console.WriteLine("press 1 to Settings page");
                Console.WriteLine("press 2 to Exit");
                int.TryParse(Console.ReadLine(), out page);

                if (page == 0)
                {
                    Console.WriteLine("Game  page");
                    a = 1;
                    Console.Write("Input your Difficulty :");
                    Difficultypass = int.Parse(Console.ReadLine());
                    page = 2 * Difficultypass + 3;

                    if (Difficultypass == 0)
                    {
                        long Datatime = DateTimeOffset.Now.ToUnixTimeSeconds();
                        Console.WriteLine(Datatime);


                        Console.WriteLine("Difficulty is Easy");
                        for (int i = 1; i <= page; i++)
                        {

                            Problem[] GenerateRandomProblemsArray;
                            GenerateRandomProblemsArray = GenerateRandomProblems(page);
                            Console.WriteLine("Message :" + GenerateRandomProblemsArray[0].Message);
                            int keep = int.Parse(Console.ReadLine());
                            Console.WriteLine("Answer :" + GenerateRandomProblemsArray[0].Answer);
                            if (keep == GenerateRandomProblemsArray[0].Answer)
                            {
                                Qc = Qc + 1;
                            }
                        }
                        Console.WriteLine("Qc : " + Qc);
                        long Datatime1 = DateTimeOffset.Now.ToUnixTimeSeconds();
                        Console.WriteLine(Datatime1);

                        point = point + ((Qc / page) * ((25 - Math.Pow(Difficultypass, 2))
                                   / Math.Max(Datatime1 - Datatime, 25 - Math.Pow(Difficultypass, 2)))
                                   * (Math.Pow(2 * Difficultypass + 1, 2)));

                        Console.WriteLine("Score :" + point);
                        Menu(point, Difficultypass);
                    }
                    else if (Difficultypass == 1)
                    {
                        long Datatime = DateTimeOffset.Now.ToUnixTimeSeconds();
                        Console.WriteLine(Datatime);

                        Console.WriteLine("Difficulty is Normal");
                        for (int i = 1; i <= page; i++)
                        {

                            Problem[] GenerateRandomProblemsArray;
                            GenerateRandomProblemsArray = GenerateRandomProblems(page);
                            Console.WriteLine("Message :" + GenerateRandomProblemsArray[0].Message);
                            int keep = int.Parse(Console.ReadLine());
                            Console.WriteLine("Answer :" + GenerateRandomProblemsArray[0].Answer);
                            if (keep == GenerateRandomProblemsArray[0].Answer)
                            {
                                Qc = Qc + 1;
                            }
                        }
                        Console.WriteLine("Qc : " + Qc);
                        long Datatime1 = DateTimeOffset.Now.ToUnixTimeSeconds();
                        Console.WriteLine(Datatime1);

                        point = point + ((Qc / page) * ((25 - Math.Pow(Difficultypass, 2))
                                   / Math.Max(Datatime1 - Datatime, 25 - Math.Pow(Difficultypass, 2)))
                                   * (Math.Pow(2 * Difficultypass + 1, 2)));
                        Console.WriteLine("Score :" + point);
                        Menu(point, Difficultypass);
                    }
                    else if (Difficultypass == 2)
                    {
                        long Datatime = DateTimeOffset.Now.ToUnixTimeSeconds();
                        Console.WriteLine(Datatime);


                        Console.WriteLine("Difficulty is Easy");
                        for (int i = 1; i <= page; i++)
                        {

                            Problem[] GenerateRandomProblemsArray;
                            GenerateRandomProblemsArray = GenerateRandomProblems(page);
                            Console.WriteLine("Message :" + GenerateRandomProblemsArray[0].Message);
                            int keep = int.Parse(Console.ReadLine());
                            Console.WriteLine("Answer :" + GenerateRandomProblemsArray[0].Answer);
                            if (keep == GenerateRandomProblemsArray[0].Answer)
                            {
                                Qc = Qc + 1;
                            }
                        }
                        Console.WriteLine("Qc : " + Qc);
                        long Datatime1 = DateTimeOffset.Now.ToUnixTimeSeconds();
                        Console.WriteLine(Datatime1);

                        point = point + ((Qc / page) * ((25 - Math.Pow(Difficultypass, 2))
                                   / Math.Max(Datatime1 - Datatime, 25 - Math.Pow(Difficultypass, 2)))
                                   * (Math.Pow(2 * Difficultypass + 1, 2)));
                        Console.WriteLine("Score :" + point);
                        Menu(point, Difficultypass);
                    }
                }
                else if (page == 1)
                {
                    Console.WriteLine("Settings page");
                    a = 1;
                    Console.WriteLine(" YOUR LEVEL. ");
                    Console.WriteLine(" Difficulty 0 = Easy ");
                    Console.WriteLine(" Difficulty 1 = Normal ");
                    Console.WriteLine(" Difficulty 2 = Hard ");
                    Console.WriteLine();
                    int Difficulty;
                    int i = 0;

                    Console.Write(" Score Now : 0 ,");
                    Console.Write(" Choose difficulty level : ");

                    while (i != 1)
                    {
                        int.TryParse(Console.ReadLine(), out Difficulty);

                        if (Difficulty == 0)
                        {
                            Console.WriteLine("level easy");
                            i = 1;
                            Menu(point, Difficultypass);
                        }
                        else if (Difficulty == 1)
                        {
                            Console.WriteLine("level Normal");
                            i = 1;
                            Menu(point, Difficultypass);
                        }
                        else if (Difficulty == 2)
                        {
                            Console.WriteLine("level Hard");
                            i = 1;
                            Menu(point, Difficultypass);
                        }
                        else
                        {
                            Console.WriteLine("Please input 0 - 2 .");
                            Console.Write(" Choose difficulty level : ");
                            i = 2;
                        }
                    }
                }
                else if (page == 2)
                {
                    Console.WriteLine("Exit");
                    a = 1;
                }
                else
                {
                    Console.WriteLine("Please input  0 - 2.");
                    Console.Write(" Do you want to go? : ");
                    Console.WriteLine();
                    a = 2;
                }
            }
        }

        static void Main(string[] args)
        {
            int Difficultypass = 0;
            double ScoreNow = 0;
            Difficulty level = 0;
            Console.WriteLine(" Score: {0}, Difficulty: {1} ", ScoreNow, level);
            Menu(ScoreNow, Difficultypass);
        }
        static Problem[] GenerateRandomProblems(int numProblem)
        {
            Problem[] randomProblems = new Problem[numProblem];
            Random rnd = new Random();
            int x, y;

            for (int i = 0; i < numProblem; i++)
            {
                x = rnd.Next(50);
                y = rnd.Next(50);
                if (rnd.NextDouble() >= 0.5)
                    randomProblems[i] =
                    new Problem(String.Format("{0} + {1} = ?", x, y), x + y);
                else
                    randomProblems[i] =
                    new Problem(String.Format("{0} - {1} = ?", x, y), x - y);
            }
            return randomProblems;
        }



    }
}
