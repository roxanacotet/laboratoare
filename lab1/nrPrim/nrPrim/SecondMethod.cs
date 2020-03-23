using System;
namespace nrPrim
{
    public class SecondMethod
    {
        public void OnIsPrimeNumber(object source, EventArgs e)
        {
            Console.WriteLine("Second Method: Applying the second method");
        }

        public int ApplySecondMethod(int number, int smallPrimeNumber)
        {
            var isPrime = new IsPrime();
            var result = new bool();
            int[] primeNumbers = new int[number];
            int index = 0;

            for (int i=1;i<number;i++)
            {
                isPrime.CheckIsPrimeNumber(i, result);
                if(result == true)
                {
                    primeNumbers[index] = i;
                    index++;
                }
            }
            smallPrimeNumber = primeNumbers[primeNumbers.Length - 1];
            return smallPrimeNumber;
        }
    }
}
