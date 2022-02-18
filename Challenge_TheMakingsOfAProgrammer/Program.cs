using System;

namespace Challenge_TheMakingsOfAProgrammer
{
    class Program
    {
        private static int length = 6;

        static void Main(string[] args)
        {
            //This challege would like me to write 5 write line statements.
            //I'm going to use a for loop instead of simply creating 5 console
            //writeline statements.
            for (int i = 1; i < length; i++)
            {
                Console.WriteLine("Hi there " + i);
            }
        }
    }
}
