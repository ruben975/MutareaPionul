using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutareaPionul
{
    public class Pion
    {
        private int X { get; set; } = 3;
        private int Y { get; set; } = 4;



        public void Move(Operation operation)
        {   if (Y != 7 && Y != 1 && X != 7 && X != 1)
            {
                switch (operation)
                {
                    case Operation.Down: X++; Console.WriteLine("Down"); break;
                    case Operation.Up: X--; Console.WriteLine("Up"); break;
                    case Operation.Left: Y--; Console.WriteLine("Left"); break;
                    case Operation.Right: Y++; Console.WriteLine("Right"); break;
                }
                for (var i = 1; i < 9; i++)
                {
                    for (var j = 1; j < 9; j++)
                        if (i == X && j == Y) Console.Write("X ");
                        else Console.Write("O ");

                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else Console.WriteLine("END of the table, can't move");
           
        }


    }
}
