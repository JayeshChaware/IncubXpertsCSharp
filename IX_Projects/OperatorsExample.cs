using System;
using System.Collections.Generic;
using System.Text;

namespace IX_Projects
{
    static class OperatorsExample
    {
        public static void AddOperator(int i, int j)
        {
            Console.WriteLine("example of + operator: {0}+{1}={2} ",i,j,i+j);
        }
        public static void SubtractOperator(int i, int j)
        {
            Console.WriteLine("example of - operator: {0}-{1}={2} ", i, j, i - j);
        }
        public static void ProductOperator(int i, int j)
        {
            Console.WriteLine("example of * operator: {0}*{1}={2} ", i, j, i * j);
        }
        public static void DivisionOperator(int i, int j)
        {
            Console.WriteLine("example of / operator: {0}/{1}={2} ", i, j, i / j);
        }
    }
}
