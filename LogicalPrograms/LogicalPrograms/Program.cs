using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Fibonacci

{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 0, b = 1, c = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(c);
                a = b;
                b = c;
                c = a + b;
            }
        }
    }
}