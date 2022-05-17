using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    { 
           public static void Main(string[] args)
            {
                int num;
                int i = 1;
                int total = 0;

                Console.WriteLine("ENTER YOUR NUMBER:");
                 num = Convert.ToInt32((double)i);
                    Console.ReadLine();

                for (i = 1; i < num; i++)
                {
                    if (num % i == 0)
                        total += i;
                }
                if (total == num)
                    Console.Write("{0} is a perfect number", num);
                else
                    Console.Write("{0} is not a perfect number", num);
            }
        }
    }


