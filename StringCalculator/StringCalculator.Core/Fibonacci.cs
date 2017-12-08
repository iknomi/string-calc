using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator.Core
{
    public class Fibonacci
    {
        public double[] Sequence(int length)
        {
            double[] sequence = new double[length];
            double a = 0, b = 1, c = 0;
            sequence[0] = 0;
            sequence[1] = 1;
            sequence[2] = 1;
            for (int i = 2; i < length; i++)
            {
                c = a + b;
                sequence[i] = c;
                a = b;
                b = c;
            }
            return sequence;
        }
    }
}
