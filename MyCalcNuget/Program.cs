using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalcNuget
{
    class Program
    {
        static void Main(string[] args)
        {
            StupidCalculator sc = new StupidCalculator();
            var sumOf1And5 = sc.Sum(1, 5);
            var mulOf5And3 = sc.Mul(5, 3);

        }
    }
}
