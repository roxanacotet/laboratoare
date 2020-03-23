using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nrPrim
{
    class IsPrime
    {
        public delegate void isPrimeEventHandler(object source, EventArgs args);
        public event isPrimeEventHandler IsPrimeNumber;
       
        public void CheckIsPrimeNumber(int number, bool result)
        {
            var ok = 1;
            if (number <= 1)
                result = false;
            else
                for (int i = 2; i <= number / 2; i++)
                    if (number % i == 0)
                        ok = 0;
            if (ok == 0)
            {
                result = false;
            }
            else
            {
                result = true;
            }
            OnIsPrimeNumber();
        }

        protected virtual void OnIsPrimeNumber()
        {
            if (IsPrimeNumber != null)
            {
                IsPrimeNumber(this, EventArgs.Empty);
            }
        }
    }
}
