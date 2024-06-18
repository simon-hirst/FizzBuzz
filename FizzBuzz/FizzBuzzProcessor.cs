using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Data;

namespace FizzBuzz
{
    public class FizzBuzzProcessor
    {
        private List<IFizzBuzzRule> rules;

        public FizzBuzzProcessor()
        {
            rules = Assembly.GetExecutingAssembly()
                         .GetTypes()
                         .Where(t => typeof(IFizzBuzzRule).IsAssignableFrom(t) && !t.IsInterface)
                         .Select(Activator.CreateInstance)
                         .Cast<IFizzBuzzRule>()
                         .ToList();
        }

        public void Process(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                var rule = rules.FirstOrDefault(r => r.IsMatch(i));
                if (rule != null) Console.WriteLine(rule.GetOutput(i));
                else Console.WriteLine(i);
            }
        }
    }
}
