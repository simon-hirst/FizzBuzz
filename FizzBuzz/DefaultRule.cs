using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class DefaultRule : IFizzBuzzRule
    {
        public bool IsMatch(int number) => true;
        public string GetOutput(int number) => number.ToString();
    }
}
