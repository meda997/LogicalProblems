using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {

        static void Main(string[] args)
        { 
                int num;
                int i = 1;
                int count = 0;
            Console.WriteLine("ENTER YOUR NUMBER:");
            num = Convert.ToInt32(Console.ReadLine());
            

            for (i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                        count++;
                }

                if (count == 2)
                    Console.Write("{0} is a prime number", num);
                else
                    Console.Write("{0} is not a prime number", num);
            }
        }
    }

