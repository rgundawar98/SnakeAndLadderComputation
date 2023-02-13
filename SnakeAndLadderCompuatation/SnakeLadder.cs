using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderCompuatation
{
    public class SnakeLadder
    {
        public static void Computation()
        {
            int position = 0;
            string Player1 = "Rahul";
            Console.WriteLine("Player name is {0} and its position is {1}",Player1,position);
            Random random= new Random();
            int RollDie =random.Next(1,7);
            Console.WriteLine("The player rolled die and possibility as:"+RollDie);
            Random random1= new Random();
            int option= random1.Next(1,4);
            switch(option)
            {
                case 1:
                    Console.WriteLine("No Play");
                    position = 0;
                    Console.WriteLine("After getting No play the player position:{0}",position);
                    break;
                case 2:
                    Console.WriteLine("Getting Ladder");
                    position = position + RollDie; 
                    Console.WriteLine("After getting ladder player moves ahead by the nnumber of position received in the die:"+position);
                    break;
                case 3:
                    Console.WriteLine("Snake Bite");
                    position =RollDie - position;
                    Console.WriteLine("After getting Snake bite player moves behind by the number of position he received on die:"+position);
                    break;
            }
        }
    }
}
