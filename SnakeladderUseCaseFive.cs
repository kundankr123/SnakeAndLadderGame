using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadder
{
    public class SnakeladderUseCaseFive
    {
        public static void ExcatWinningPosition()
        {
            int position = 0;
            Console.WriteLine("Initial Position of Player: " + position);

            while (position != 100)
            {
                Random random = new Random();
                int OptionCheck = random.Next(3);
                int DiceOutput = random.Next(1, 7); //seven Because upper bond is exclusive
                //Console.WriteLine("The output of Option check is:" + OptionCheck);


                if (OptionCheck == 1) //Ladder
                {
                    Console.WriteLine("Got Ladder, you will climb.");
                    position += DiceOutput;
                    Console.WriteLine("New Position:" + position);
                    if (position > 100) 
                    {
                        position -= DiceOutput;
                    }
                }
                else if (OptionCheck == 2) //Snake
                {
                    Console.WriteLine("Got Snake, you will descend in position.");
                    position -= DiceOutput;
                    if (position < 0)
                    {
                        position = 0;
                    }
                    Console.WriteLine("New Position:" + position);
                }
                else //No Play
                {
                    Console.WriteLine("You got No Play, can neither climb nor descend in position.");
                }
            }
        }
    }
}
