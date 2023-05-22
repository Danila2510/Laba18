using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab18
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<string> numbers = new List<string>() { "Bi", " Ba", " i ", "Bo", "Ba " };
            Thread thread = new Thread(() =>
            {
                foreach (string number in numbers)
                    Console.Write($" {number}");
            });
            thread.Start();
            thread.Join();
            Console.ReadLine();
        }
    }
}
