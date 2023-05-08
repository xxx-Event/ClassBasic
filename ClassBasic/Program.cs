using System;

namespace NewClassProgram3203 {
    internal class Program
    {
        private class Math {
            /*static public int Abs(int a)
            {
                return 0;
            }*/
        }
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine(Math.Abs(-10));

            ThirdClass abc;
            ABCClass abc2;
            InnerClass inn;
            Console.WriteLine("Hello World!");
        }
    }
}