using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.ClassLib;

namespace AssignmentCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Arithmetic.Average<int>(1,2,3,4));
            Console.WriteLine(Arithmetic.Average<double>(1,2,3,4));
            Console.WriteLine(Arithmetic.Average<decimal>(1,2,3,4));
            Console.WriteLine(Arithmetic.Average<long>(1,2,3,4));
            Console.WriteLine(Arithmetic.Average<short>(1,2,3,4));
            Console.WriteLine(Arithmetic.Average<float>(1,2,3,4));

            Console.ReadLine();
            
        }
    }
}
