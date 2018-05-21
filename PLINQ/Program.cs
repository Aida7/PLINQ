using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>();

            for (int i = 0; i < 1000000000; i++)
            {
                num.Add(i);
            }

            //1 вариянт
                (from number
                         in num.AsParallel()
                 where number % 2 == 0
                 select number).ForAll(number => Console.WriteLine(number));
            //2 вариянт
            num.AsParallel()
                .Where(number => number % 2 == 0)
                .ForAll(Console.WriteLine);
        }
    }
}
