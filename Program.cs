using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PEuler9
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int a = 1; a<=1000; a++)
            {
                for(int b = 1; b<=a; b++)
                {
                    if(1000*(a+b)-(a*b) == 500000)
                    {
                        double d = a * a + b * b;
                        int c = Convert.ToInt32(Math.Sqrt(d));
                        Console.WriteLine("a: " + a);
                        Console.WriteLine("b: " + b);
                        Console.WriteLine("c: " + c);
                        Console.WriteLine("abc: " + a*b*c);
                        Console.ReadLine();
                    }


                }

            }
        }
    }
}
