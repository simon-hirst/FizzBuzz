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
}
