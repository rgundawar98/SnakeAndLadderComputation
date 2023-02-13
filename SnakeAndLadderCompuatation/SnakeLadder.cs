using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SnakeAndLadderCompuatation
{
    public class SnakeLadder
    {
        public static void Computation()
        {
            int position = 0, count = 0;
            string Player1 = "Rahul";
            Console.WriteLine("Player name is {0} and its position is {1}", Player1, position);
            while (position < 100)
            {
            Random random = new Random();
            int RollDie = random.Next(1, 7);
            Console.WriteLine("Random number:"+RollDie);
            Random random1 = new Random();
            int option = random1.Next(1, 4);
                switch (option)
                {
                    case 1:
                        Console.WriteLine("No Play");
                        position = 0;
                        Console.WriteLine("After getting No play the player position:{0}", position);
                        break;
                    case 2:
                        Console.WriteLine("Getting Ladder");
                        position += RollDie;
                        if(position > 100)
                        {
                            position = position - RollDie;
                            Console.WriteLine("After getting ladder player position more than 100th position:" +position);
                        }
                        else
                        {
                            Console.WriteLine("After getting ladder player position:"+position);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Snake Bite");
                        position -= RollDie;
                        if (position <= 0)
                        {
                            position = 0;
                            Console.WriteLine("After getting snake and Position less than zero then Player Position: " + position);
                        }
                        else
                        {
                            Console.WriteLine("After getting snake Player Position: " + position);
                        }
                        break;
                }
            }
            Console.WriteLine("\nNumber of times the die rolled will be:"+count);
        }
    }
}
