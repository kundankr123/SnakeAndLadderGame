using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class SnakeladderUseCaseTwo
    {
        public static void DiceRoll()
        {
            int position = 0;
            Console.WriteLine("Initial Position of Player: " + position);

            Random random = new Random();
            int DiceOutput = random.Next(1, 7); //seven Because upper bond is exclusive
            Console.WriteLine("The output of dice roll is:" + DiceOutput);

        }
    }
}
