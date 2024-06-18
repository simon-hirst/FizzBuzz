using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzRule : IFizzBuzzRule
    {
        public bool IsMatch(int number) => number % 3 == 0;
        public string GetOutput(int number) => "Fizz";
    }
}
