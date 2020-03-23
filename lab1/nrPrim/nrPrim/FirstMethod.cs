using System;

namespace nrPrim
{
    public class FirstMethod
    {
        public void OnIsPrimeNumber(object source, EventArgs e)
        {
            Console.WriteLine("First Method: Applying the first method");
        }

        public int ApplyFirstMethod(int number)
        {
            var isPrime = new IsPrime();
            var result = new bool();
            var smallPrimeNumber = new int();
            for (int i= number-1; i >= 0; i--)
            {
                isPrime.CheckIsPrimeNumber(i, result);
                if(result == true) {
                    smallPrimeNumber = i;
                    break;
                }
            }
            return smallPrimeNumber;
        }
    }
}
