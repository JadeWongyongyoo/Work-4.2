using System;

namespace งานมา_4
{
    class Program
    {
        static string PwDNA = Console.ReadLine();
        static char Y;

        static void Main(string[] args)
        {

            IsValidSequence(PwDNA);
            if (IsValidSequence(PwDNA) == true)
            {
                Console.WriteLine("Current half DNA sequence : {0} ", PwDNA);
                Console.Write("Do you want to replicate it ? (Y/N) : ");
                char Y = Char.Parse(Console.ReadLine());
                ReplicateSeqeunce(PwDNA);
                while (Y != 'Y' && Y != 'N')
                {
                    Console.WriteLine("Please input Y or N.");
                    Console.Write("Do you want to replicate it ? (Y/N) : ");
                    Y = char.Parse(Console.ReadLine());
                }
                if ('Y' == Y)
                {
                    {
                        Console.WriteLine("Current half DNA sequence : {0} ", ReplicateSeqeunce(PwDNA));
                        Console.Write("Do you want to process another sequence ? (Y/N) : ");

                        Y = Char.Parse(Console.ReadLine());
                        while (Y != 'Y' && Y != 'N')
                        {
                            Console.WriteLine("Please input Y or N.");
                            Console.Write("Do you want to process another sequence ? (Y/N) : ");
                            Y = char.Parse(Console.ReadLine());
                        }
                    }
                }
                if ('N' == Y)
                {
                    Console.Write("The End");

                    while ('Y' == Y)
                    {
                        PwDNA = Console.ReadLine();
                        Console.WriteLine("Current half DNA sequence : {0} ", IsValidSequence(PwDNA));
                        Console.Write("Do you want to replicate it ? (Y/N) : ");
                        Y = Char.Parse(Console.ReadLine());
                        while (Y != 'Y' && Y != 'N')
                        {
                            Console.WriteLine("Please input Y or N.");
                            Console.Write("Do you want to replicate it ? (Y/N) : ");
                            Y = char.Parse(Console.ReadLine());
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
                Console.Write("Do you want to process another sequence ? (Y/N) : ");
                char Y = Char.Parse(Console.ReadLine());

                while (Y != 'Y' && Y != 'N')
                {
                    Console.WriteLine("Please input Y or N.");
                    Console.Write("Do you want to replicate it ? (Y/N) : ");
                    Y = char.Parse(Console.ReadLine());
                }
                if ('Y' == Y)
                {
                    {
                        PwDNA = Console.ReadLine();
                        Console.WriteLine("Current half DNA sequence : {0} ", PwDNA);
                        Console.Write("Do you want to process another sequence ? (Y/N) : ");

                        Y = Char.Parse(Console.ReadLine());
                        while (Y != 'Y' && Y != 'N')
                        {
                            Console.WriteLine("Please input Y or N.");
                            Console.Write("Do you want to replicate it ? (Y/N) : ");
                            Y = char.Parse(Console.ReadLine());
                        }
                        if ('N' == Y)
                        {
                            Console.Write("Do you want to process another sequence ? (Y/N) : ");
                            Y = Char.Parse(Console.ReadLine());
                            while (Y != 'Y' && Y != 'N')
                            {
                                Console.WriteLine("Please input Y or N.");
                                Console.Write("Do you want to replicate it ? (Y/N) : ");
                                Y = char.Parse(Console.ReadLine());
                            }
                            if ('N' == Y)
                            {
                                Console.Write("The End");
                            }
                        }
                        if ('Y' == Y)
                        {
                            PwDNA = Console.ReadLine();
                            ReplicateSeqeunce(PwDNA);
                            while (Y != 'Y' && Y != 'N')
                            {
                                Console.WriteLine("Please input Y or N.");
                                Console.Write("Do you want to process another sequence ? (Y/N) :");
                                Y = char.Parse(Console.ReadLine());
                            }
                            Console.WriteLine("Current half DNA sequence : {0} ", ReplicateSeqeunce(PwDNA));
                            Console.Write("Do you want to process another sequence ? (Y/N) : ");
                            if ('N' == Y)
                            {
                                Console.Write("The End");
                            }
                            while ('Y' == Y)
                            {
                                PwDNA = Console.ReadLine();
                                Console.WriteLine("Current half DNA sequence : {0} ", PwDNA);
                                Console.Write("Do you want to replicate it ? (Y/N) : ");
                                Y = Char.Parse(Console.ReadLine());
                                while (Y != 'Y' && Y != 'N')
                                {
                                    Console.WriteLine("Please input Y or N.");
                                    Console.Write("Do you want to replicate it ? (Y/N) : ");
                                    Y = char.Parse(Console.ReadLine());
                                }                                
                            }
                        }
                    }
                    if ('N' == Y)
                    {
                        Console.Write("The End");
                    }

                }
            }
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

        }
    }
}
