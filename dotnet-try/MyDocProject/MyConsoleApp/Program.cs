using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region say_hello
            Console.WriteLine(new Cat().Say());
            #endregion
        }
    }
}
