using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public interface IFizzBuzzRule
    {
        bool IsMatch(int number);
        string GetOutput(int number);
    }

    public class FizzBuzzRule : IFizzBuzzRule
    {
        public bool IsMatch(int number) => number % 3 == 0 && number % 5 == 0;
        public string GetOutput(int number) => "FizzBuzz";
    }

    public class FizzRule : IFizzBuzzRule
    {
        public bool IsMatch(int number) => number % 3 == 0;
        public string GetOutput(int number) => "Fizz";
    }

    public class BuzzRule : IFizzBuzzRule
    {
        public bool IsMatch(int number) => number % 5 == 0;
        public string GetOutput(int number) => "Buzz";
    }
}
