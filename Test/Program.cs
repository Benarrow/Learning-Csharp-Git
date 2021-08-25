using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> AHG = new List<int> {1, 2, 3, 4};
            foreach (int DS in AHG) {
                Console.WriteLine(DS);
            }
            
        }
    }
}