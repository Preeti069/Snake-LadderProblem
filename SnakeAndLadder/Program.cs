using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snake And Ladder Program");

            const int FirstPosition = 0;
            int position = 0;
            int dieCount = 0;
            Console.WriteLine("Start Positon is : " + FirstPosition);
            while (position < 100)
            {

                Random random = new Random();
                int dicethrown = random.Next(1, 7);
                dieCount++; 
                Console.WriteLine("\nDies Output is :" + dicethrown);

                Random random2 = new Random();
                int options = random.Next(1, 4);

                if (options == 1)
                {
                    Console.WriteLine("Player got no play");
                    dicethrown = 0;
                    position = dicethrown;
                    Console.WriteLine("The player position is: " + position);
                }
                else if (options == 2)
                {
                    Console.WriteLine("Player got ladder");
                    position = (position + dicethrown);
                    Console.WriteLine("The player position is: " + position);
                }
                else
                {
                    Console.WriteLine("Player got snake");
                    position = (position - dicethrown);
                    if (position < 0)
                    {
                        position = FirstPosition;
                    }
                    Console.WriteLine("The player position is: " + position);
                }
                if (position > 100)
                {
                    position = position - dicethrown;
                }
                else if (position < 0)
                {
                    position = 0;
                }
                else if (position == 100)
                {
                    Console.WriteLine("player has won");
                    break;
                }
            }
            Console.WriteLine("die count : " + dieCount);
            Console.ReadLine();
        }
    }
}
