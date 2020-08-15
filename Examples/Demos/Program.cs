using System;

namespace Demos
{
    class Program
    {

      /**
       * fibNumber
       * Fibonacci Number
       *
       * Determine the nth Fibonacci Number
       *
       * Background Reading
       *  https://en.wikipedia.org/wiki/Fibonacci
       *  https://en.wikipedia.org/wiki/Fibonacci_number
       *  https://mathworld.wolfram.com/FibonacciNumber.html
       *  https://www.investopedia.com/terms/f/fibonaccilines.asp
       *  https://www.goldennumber.net/fibonacci-series/
       *
       */
        public static int fibNumber(int i) 
        {
            if (i <= 2) 
            {
              return 1;
            }
            return fibNumber(i - 2) + fibNumber(i - 1);
        }

        /**
         * phiCalc
         *
         * Determine the nth Fibonanci Number using the Phi and phi calcluation method
         *
         * Background Reading
         *  https://math.hmc.edu/funfacts/fibonacci-number-formula/
         *
         */
        public static int phiCalc(int i)
        {
            double phi = (1 - Math.Sqrt(5))/2;
            double Phi = (1 + Math.Sqrt(5))/2;
            return System.Convert.ToInt32((Math.Pow(Phi,i) - Math.Pow(phi,i))/Math.Sqrt(5));
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Demos Program - starting");

            int n = 20;
            System.Console.WriteLine("- Recrusive Calculation of nth  Fibonacci Number");
            System.Console.WriteLine(fibNumber(n));


            System.Console.WriteLine(" - Demo Phi Calcaluation of nth Fibonanci Number");
            System.Console.WriteLine(phiCalc(n));
        }
    }

}
