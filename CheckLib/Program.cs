using System;
using Calculator;
namespace CheckLib
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(TwoNumCal.TwoNumSum(10, 25));
            Console.WriteLine(ThreeNumCal.ThreeNumSum(10,21, 25));
            Console.WriteLine(TwoNumCal.TwoNumProduct(10, 25));
            Console.WriteLine(TwoNumCal.TwoNumSubtraction( 25,10));
            Console.WriteLine(TwoNumCal.NumMod( 25,10));
            Console.WriteLine(TwoNumCal.TwoNumDivision(100, 25));
        }
    }
}
