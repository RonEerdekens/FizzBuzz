using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string Start(int number)
        {
            if (number % 3 == 0)
                return "Fizz";
            return number.ToString();
        }
    }
}
