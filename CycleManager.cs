using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicSum
{
    public class CycleManager
    {
        public int GetEvenCount(int limit)
        {
            for (int i = 1; i <= limit; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz " + i);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz " + i);
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz " + i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            return limit;



        }
    }
}
