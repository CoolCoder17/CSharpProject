using System;
namespace SomeConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            var iAmTrue = true;
            if (iAmTrue)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadKey();
        }

        public static bool AlwaysReturnsTrue()
        {
            //Console.WriteLine("Hello world");
            return true;
        }

        public static object Passthrough(object obj)
        {
            //Console.WriteLine("New world");
            return obj;
        }
    }
}
