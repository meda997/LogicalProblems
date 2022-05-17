using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseANum
    {
        static void Main(string[] args)
        {
            int num;
            int reverse;
            int remainder;

            Console.WriteLine("ENTER YOUR NUMBER:");
            num = Convert.ToInt32(Console.ReadLine());
            reverse = Convert.ToInt32(Console.ReadLine());

            while (num == 0)
            {
                remainder = num % 10;
                reverse = reverse * 10 + remainder;
                num = num / 10;
            }
            {
                Console.WriteLine("REVERSE OF NUMBER ");
            }
        }
    }
}




