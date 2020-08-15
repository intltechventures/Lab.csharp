using System;

namespace Demos
{
  /**
   * Microsoft .NET Core Documentation References:
   *
   *  .NET Core 3.1 Documentation
   *  https://docs.microsoft.com/en-us/dotnet/api/system.math?view=netcore-3.1
   *
   *
   * Additional .NET Mathematical Libraries to explore:
   * https://en.wikipedia.org/wiki/List_of_numerical_libraries
   *
   *  https://www.mathdotnet.com/
   *    "Math.NET is an opensource initiative to build and maintain toolkits covering fundamental mathematics, targetting advanced but also every day needs of .Net developers."
   *    https://numerics.mathdotnet.com/
   *    https://github.com/mathnet/mathnet-numerics
   *    https://numerics.mathdotnet.com/Constants.html
   *    https://www.nuget.org/packages/MathNet.Numerics/
   *      NOTE: As of 2020-08-15, version 4.12.0, requires Net Framework 4.0 or higher and .Net Standard 1.3 or higher
   *      NOTE: MIT License
   *
   *
   *  Intel Math Kernel Library (MLK)
   *  https://en.wikipedia.org/wiki/Math_Kernel_Library
   *  https://software.intel.com/content/www/us/en/develop/tools/math-kernel-library.html
   *    https://software.intel.com/content/www/us/en/develop/tools/documentation-library.html
   *    https://numerics.mathdotnet.com/MKL.html
   *    https://software.intel.com/content/www/us/en/develop/articles/using-intel-mkl-in-your-c-program.html
   *    https://software.intel.com/content/www/us/en/develop/articles/some-more-additional-tips-how-to-call-mkl-from-your-c-code.html
   *
   *    https://software.intel.com/content/www/us/en/develop/articles/intel-math-kernel-library-license-faq.html
   *    https://software.intel.com/content/www/us/en/develop/articles/end-user-license-agreement.html#inpage-nav-3
   *
   *    MLK wrapper projects:
   *      https://github.com/DNRY/CSIntelPerfLibs
   *      https://github.com/Rafka86/SharpMKL
   *      https://github.com/Proxem/BlasNet
   *
   *
   *
   *  https://mathparser.org/
   *    mXparser – Math Expressions Parser for JAVA Android C# .NET/MONO/Xamarin – Mathematical Formula Parser / Evaluator Library
   *    http://mathparser.org/mxparser-math-collection/
   *    http://mathparser.org/mxparser-tutorial/
   *    http://mathparser.org/api/
   *    https://mathparser.org/mxparser-tutorial/built-in-constants/
   *    https://github.com/mariuszgromada/MathParser.org-mXparser
   *    NOTE: As of 2020-08-15, version 4.4.0
   *
   *
   *
   *  https://www.nag.com/content/nag-library
   *    NAG was founded in 1970 as an inter-University collaborative venture combining the talents of many globally renowned mathematicians. 
   *    In 1971 NAG developed the first mathematical software library - the NAG Library, which, over the next four decades, has evolved to become 
   *    the largest commercially available collection of high quality mathematical and statistical algorithms. 
   *
   *    https://www.nag.com/content/nag-library-dot-net
   *      https://www.nag.com/numeric/dt/nagdotnet_dtw02/html/contents.html
   *    https://www.nag.com/content/software-documentation
   *    https://www.nag.com/content/nag-library-net-documentation
   *    https://www.nag.com/content/software-downloads
   *    NOTE: Commercial software license, requires .NET Release 2
   *
   *
   *  Extreme Optimization Numerical Libraries for .NET
   *    http://www.extremeoptimization.com/
   *    http://www.extremeoptimization.com/Documentation/Mathematics/Default.aspx
   *    http://www.extremeoptimization.com/MathFeatures.aspx
   *    NOTE: As of 2020-08-15, version 7.0 (November 2018) includes with support for .NET Core 1.1 and 2.1 and .NET Standard 1.3 and 2.0. 
   *    NOTE: Commercial software license
   *
   *
   *
   * Sources for Programming Problem Ideas
   * 
   *  Coding Interview University
   *  https://github.com/jwasham/coding-interview-university
   *
   *
   *  https://github.com/EbookFoundation/free-programming-books
   *    https://github.com/EbookFoundation/free-programming-books/blob/master/free-programming-books.md
   *      https://github.com/EbookFoundation/free-programming-books/blob/master/free-programming-books.md#c-sharp
   *
   *
   *  Papers with code
   *  https://github.com/zziz/pwc
   *
   *
   *  https://www.geeksforgeeks.org/
   *    https://www.geeksforgeeks.org/math-in-competitive-programming/?ref=leftbar-rightbar
   *    https://www.geeksforgeeks.org/category/competitive-programming/
   *    
   *    Sum of GCD of all possible sequences
   *    https://www.geeksforgeeks.org/sum-of-gcd-of-all-possible-sequences/?ref=leftbar-rightbar
   *
   *    Number of containers that can be filled in the given time
   *    https://www.geeksforgeeks.org/number-of-containers-that-can-be-filled-in-the-given-time/?ref=leftbar-rightbar
   *
   *    Find the K-th Permutation Sequence of first N natural numbers
   *    https://www.geeksforgeeks.org/find-the-k-th-permutation-sequence-of-first-n-natural-numbers/?ref=leftbar-rightbar
   *
   *    Find the K closest points to origin using Priority Queue
   *    https://www.geeksforgeeks.org/find-the-k-closest-points-to-origin-using-priority-queue/?ref=leftbar-rightbar
   *
   *    Euler’s Totient Function
   *    https://www.geeksforgeeks.org/eulers-totient-function/
   *
   *
   *  International Collegiate Programming Contest
   *  https://icpc.global/
   *    https://icpc.global/worldfinals/problems
   *    https://icpc.global/worldfinals/programming-environment
   *    (2020 ICPC World Finals, hosted by Moscow Institute of Physics and Technology, June 19-24, 2021, Moscow, Russia)
   *    https://icpc.global/xwiki/wiki/public/download/worldfinals/WebHome/icpc2019.pdf
   *
   *
   *  Seminole State College of Florida - Intercollegiate Programming Competition 
   *  https://www.seminolestate.edu/computers/competition
   *    Previous Competition Sample Problems 
   *    https://www.seminolestate.edu/computers/competition/samples
   *      https://www.seminolestate.edu/computers/competition/samples/2019
   *      https://www.seminolestate.edu/computers/competition/samples/2018
   *      https://www.seminolestate.edu/computers/competition/samples/2017
   *      https://www.seminolestate.edu/computers/competition/samples/2016
   *      https://www.seminolestate.edu/computers/competition/samples/2015
   *
   *
   *  The Annual Berkeley Programming Contest
   *  http://people.eecs.berkeley.edu/~hilfingr/programming-contest/
   *    See:
   *      - "Past Berkeley Contests" (1991-2012)
   *      - "Problems from Elsewhere"
   *
   *
   *  lnishan's blog, An awesome list for competitive programming!
   *  https://codeforces.com/blog/entry/23054
   *  https://github.com/lnishan/awesome-competitive-programming
   *  
   *
   *  https://github.com/tayllan/awesome-algorithms
   *
   *
   *  https://github.com/hkirat/Algorithmic-Resources
   *
   *
   *  https://github.com/jnikhilreddy/Competitive-programming-resources
   *
   *
   *  https://www.hackerearth.com/practice/
   *    https://www.hackerearth.com/challenges/
   *
   *    The Complete Reference to Competitive Programming by Ravi Ojha 
   *    https://www.hackerearth.com/getstarted-competitive-programming/
   *
   *
   *  Github Topic Searches:
   *    https://github.com/topics/programming-contests
   *    https://github.com/topics/competitive-programming
   *
   */ 
    class Program
    {

      // Global definitions - to experiment with in the future
      readonly double GoldenRatio = (1 + Math.Sqrt(5)) / 2;

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
