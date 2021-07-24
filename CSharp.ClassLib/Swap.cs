using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ClassLib
{
    public class Swap
    {
        public static void NumberSwap(int x, int y)
        {
            Console.WriteLine($"x = {x} y = {y}");
            // x saved to temp
            var temp = x;
            x = y;
            // x converts to y value
            y = temp;
            // temp is x value

            Console.WriteLine($"x = {x} y = {y}");

        }
    }
}
