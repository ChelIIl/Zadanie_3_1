using System;

namespace СSh
{
    class Program
    {
        static int f (int a)
        {
            if (a % 5 == 0)
                return a /= 5;
            else
                return a += 1; 
        }

        static void Main()
        {
            int n1, n2, n3, n4;

            n1 = 3;            
            n2 = 5;            
            n3 = 20;          
            n4 = 17;

            Console.WriteLine(n1 + "  " + n2 + "  " + n3 + "  " + n4);

            n1 = f(n1);
            n2 = f(n2);
            n3 = f(n3);
            n4 = f(n4);

            Console.WriteLine(n1 + "  " + n2 + "  " + n3 + "  " + n4);

            Console.ReadKey();
        }
    }
}
