using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
    internal class Program
    {
        static string numberList = "";
        static void Main(string[] args)
        {
            printNumbers(5);
            Console.ReadLine();

            range(5,10);
            Console.ReadLine();

            getNumberString(5);
            Console.WriteLine(numberList);
            Console.ReadLine();
        }
        
        
        static void printNumbers(int n)
        {
            if (n > 0)
            {
                Console.WriteLine(" n = {0} ", n);
                printNumbers(n - 1);
            }
            Console.WriteLine("\n Recursion Unfolding  --- n = {0} ", n);
        }

        static void range(int start, int stop)
        /* Displays numbers between start and stop - start <= stop */
        {
            
            if (start == stop)
            {
                Console.WriteLine("Thenumber has reached its target");
            }
            else
            {
                Console.WriteLine("number = {0}", start);
                range(start+1, stop);
            }
        }

        static string getNumberString(int n)
        /* Displays numbers between start and stop - start <= stop */
        {
            numberList += n + " ";
            if (n == 0)
            {
                return "Thenumber has reached its target";
            }
            else
            {
                Console.WriteLine("number = {0}", n);
                getNumberString(n - 1);
            }
            return "Fail";
        }

        static int multiply(int x, int y)
        {
            if (y == 1)
                return   ??  ;
            else


    }




    }
}
