using System;

namespace HomeWork4._22
{
    class Program
    {

        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }


        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }


        static void Main(string[] args)
        {
            string halfDNASequence = Console.ReadLine();
            char YN;
            IsValidSequence(halfDNASequence);

            if (IsValidSequence(halfDNASequence) == true)
            {
                Console.WriteLine("Current half DNA sequence : {0}", halfDNASequence);
                Console.WriteLine("Do you want to replicate it ? (Y/N) : ");

                YN = char.Parse(Console.ReadLine());

                while (IsValidSequence(halfDNASequence) == true)
                {
                    if (YN == 'Y')
                    {
                        ReplicateSeqeunce(halfDNASequence);
                        Console.WriteLine("Replicated half DNA sequence : {0}", ReplicateSeqeunce(halfDNASequence));

                        Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                        YN = char.Parse(Console.ReadLine());

                        while (IsValidSequence(halfDNASequence) == true)
                        {
                            if (YN == 'Y')
                            {
                                Main(null);
                                break;

                            }
                            else if (YN == 'N')
                            {
                                Console.ReadLine();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please input Y or N.");
                                Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                                YN = char.Parse(Console.ReadLine());
                            }

                        }

                    }
                }
            }

            else if (IsValidSequence(halfDNASequence) == false)
            {
                Console.WriteLine("That half DNA sequence is invalid.");
                Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                YN = char.Parse(Console.ReadLine());
                
                    while (IsValidSequence(halfDNASequence) == false)
                    {
                        if (YN == 'Y')
                        {
                            Main(null);
                            break;

                        }
                        else if (YN == 'N')
                        {
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Please input Y or N.");
                            Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                            YN = char.Parse(Console.ReadLine());
                        }

                    }
                



            }

        }
    }
}

