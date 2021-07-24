using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.ClassLib
{
    public class Arithmetic
    {
        public static T Addition<T>(T x, T y)
        {
            dynamic X = x;
            dynamic Y = y;
            Console.WriteLine($"{x} + {y} = {(T) (X + Y)}");



            return (T)(X + Y);

        }
        public static T Division<T>(T x, T y)
        {
            dynamic X = x;
            dynamic Y = y;


            Console.WriteLine($"{x} / {y} = {(T)(X / Y)}");

            return (T)(X / Y);
        }
        public static T Average<T>(T x, T y,T z,T a)
        {
            dynamic X = x;
            dynamic Y = y;
            dynamic Z = z;
            dynamic A = a;


            return (T)((X + Y + Z + A) / 4);

        }
    }
}
