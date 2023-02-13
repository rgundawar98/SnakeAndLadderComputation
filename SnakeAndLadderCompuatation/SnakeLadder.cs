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
            int position = 0, count = 0 ,position1=0;
            string Player1 = "Rahul" ,Player2="Rohit";
            bool turn = true;
            Console.WriteLine("Player name is {0} and its position is {1}", Player1, position);
            Console.WriteLine("Player name is {0} and its position is {1}", Player2, position1);
            while (position < 100 && position1<100)
            {
            Random random = new Random();
            int RollDie = random.Next(1, 7);
            Console.WriteLine("Random number:"+RollDie);
            Random random1 = new Random();
            int option = random1.Next(1, 4);
                if(turn == true)
                {
                    if (position<100)
                    {
                       switch (option)
                {
                    case 1:
                        Console.WriteLine("No Play");
                        position += 0;
                        turn = false;
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
                        turn = true;
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
                                turn = false;
                        break;
                }
                    }
                }
                else
                {
                    if (position1 < 100)
                    {
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("No Play");
                                position1 += 0;
                                turn = true;
                                Console.WriteLine("After getting No play the player position:{0}", position);
                                break;
                            case 2:
                                Console.WriteLine("Getting Ladder");
                                position += RollDie;
                                if (position > 100)
                                {
                                    position = position - RollDie;
                                    Console.WriteLine("After getting ladder player position more than 100th position:" + position);
                                }
                                else
                                {
                                    Console.WriteLine("After getting ladder player position:" + position);
                                }
                                turn = false;
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
                                turn = false;
                                break;
                        }
                    }
                    Console.WriteLine("Player1 Position " + position);
                    Console.WriteLine("Player2 Position " + position1);
                    if (position > position1)
                    {
                        Console.WriteLine("Player1 {0} won the match", Player1);
                    }
                    else
                    {
                        Console.WriteLine("Player2 {0} won the match", Player2);
                    }
                }
            }
        }
    }
}
