using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snake And Ladder Program");
            int position = 0;
            Console.WriteLine("Start Positon is : " + position);
            Random random = new Random();
            int dicethrown = random.Next(1, 7);
            Console.WriteLine("\nDies Output is :" + dicethrown);

            Console.ReadLine();
        }
    }
}
