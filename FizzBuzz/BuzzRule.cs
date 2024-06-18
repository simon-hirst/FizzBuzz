using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class BuzzRule : IFizzBuzzRule
    {
        public bool IsMatch(int number) => number % 5 == 0;
        public string GetOutput(int number) => "Buzz";
    }
}
