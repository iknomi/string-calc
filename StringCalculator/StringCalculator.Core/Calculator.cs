using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Core
{
    public class Calculator
    {
        public double Sum(string[] numbers, double? maxNumberValue = null)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }

            double a = 0, sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                a = double.Parse(numbers[i]);
                if (maxNumberValue == null || (maxNumberValue != null && a <= maxNumberValue.Value))
                {
                    sum = sum + a;
                }
            }
            return sum;
        }
    }
}
