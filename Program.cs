using System;
using LogicSum;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        

        static void Main(string[] args)
        {

            Console.WriteLine("FizzBuzz - project");

            Console.WriteLine("Insert first number");

            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert second number");
            int limit = int.Parse(Console.ReadLine());

            CycleManager maneger = new CycleManager();
            currentValue = maneger.GetEvenCount(limit);

            
            Console.ReadLine();


        }
    }
}
