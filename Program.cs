using System;

namespace Uc1
{
    class Program
    {
        static void Main(string[] args)
        {

            int i;
            Random r = new Random();

            i = r.Next(2);
            if (i == 0)
                Console.WriteLine("employee absent ");
            else
                Console.WriteLine("employee present");
        }
    }
    }

