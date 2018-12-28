using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip
{
    class Program
    {
        static void Main(string[] args)
        {
            ask();
        }

        static void Flip(int Mul)
        {
            Console.WriteLine();
            Random rnd = new Random();
            for (int i = 0; i < Mul; i++)
            {
                int flip = rnd.Next(0, 2);
                if (flip == 1)
                {
                    Console.WriteLine("Heads");
                }
                else
                {
                    Console.WriteLine("Tails");
                }
            }
        }

        static void ask()
        {
            bool loop = true;
            while (loop)
            {
                Console.Write("Do you want filp a coin. [Y]es [N]o [M]ultiple: ");
                char answer = Console.ReadKey().KeyChar;
                if (answer == 'y' || answer == 'Y')
                {
                    loop = true;
                    Flip(1);
                    
                }
                else if (answer == 'n' || answer == 'N')
                {
                    loop = false;
                }
                else if (answer == 'm' || answer == 'M')
                {
                    Console.WriteLine("");
                    Console.WriteLine("How many: ");
                    int Amount;
                    while (!int.TryParse(Console.ReadLine(),out Amount))
                    {
                        Console.WriteLine("Try again");
                    }
                    Flip(Amount);

                }
                else
                {
                    loop = true;
                }
                Console.WriteLine("");
            }
        }
    }
}