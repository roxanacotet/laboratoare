using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nrPrim
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 10;
            var result = new bool();
            var result1 = new int();
            var result2 = new int();
            var isPrime = new IsPrime();//publisher
            var firstMethod = new FirstMethod();
            var secondMethod = new SecondMethod();

            isPrime.IsPrimeNumber += firstMethod.OnIsPrimeNumber;
            isPrime.IsPrimeNumber += secondMethod.OnIsPrimeNumber;

            isPrime.CheckIsPrimeNumber(number, result);
            System.Console.WriteLine(number + " is prime number: " + result);
            result1 = firstMethod.ApplyFirstMethod(number);
            System.Console.WriteLine("[First method]: the biggest prime number smaller then "+number + " is: " + result1);

            result2 = secondMethod.ApplySecondMethod(number, result2);
            System.Console.WriteLine("[Second method]: the biggest prime number smaller then " +number + " is: " + result2);
        }
    }
}
