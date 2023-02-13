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
        }
    }
}
