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

            range(5, 10);
            Console.ReadLine();

            getNumberString(5);
            Console.WriteLine(numberList);
            Console.ReadLine();

            Console.WriteLine("5 x 10 = {0}", multiply(5, 10));
            Console.ReadLine();
            Console.WriteLine(" 7 x -7 = {0}", multiply(7, -7));
            Console.ReadLine();
            Console.WriteLine(" -4 x -8 = {0}", multiply(-4, -8));
            Console.ReadLine();

            Console.WriteLine("2 ^ 5 = {0}", power(2, 5));
            Console.ReadLine();
            Console.WriteLine(" -3 ^ 3 = {0}", power(-3, 3));
            Console.ReadLine();
            Console.WriteLine(" -3 ^ 4 = {0}", power(-3, 4));
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
                range(start + 1, stop);
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

        static int inc(int x)
        {
            return x + 1;
        }

        static int dec(int x)
        {
            return x - 1;
        }

        static int multiply(int x, int y)
        {
            if (y == 0) { return 0; }
            else if (y == 1) { return x; }
            else if (y == -1) { return -x; }
            else
            {
                if (y < 0) { return -x + multiply(x, inc(y)); }
                if (y > 0) { return  x + multiply(x, dec(y)); }
            }
            return 999; // error case
        }

        static int power(int x, int y)
        { // Negative y wont work, as they produce decimals, so we ignore negative y.
            if (y == 0) { return 0; }
            else if (y == 1) { return x; }
            else
            {
                if (x < 0) { return (-x) * power(x, y - 1); }
                if (x > 0) { return x * power(x, y - 1); }
            }
            return 999; // error case
        }
    }
}
