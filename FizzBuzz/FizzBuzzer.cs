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
            var result = string.Empty;
            if (number % 3 == 0)
                result += "Fizz";
            if (number % 5 == 0)
                result += "Buzz";
            return string.IsNullOrEmpty(result) ? number.ToString() : result;

        }
    }
}
