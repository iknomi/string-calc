using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCalculator.Core;
using System.Text.RegularExpressions;

namespace StringCalculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (!new[] { "exit", "quit", "close", "q" }.Contains(command))
            {
                switch (command.Split(':')[0])
                {
                    case "f":
                        int length = int.Parse(command.Split(':')[1]);
                        string sequenceString = GetSequence(length).Select(x => x.ToString()).Aggregate((a, b) => a + " " + b);
                        Console.WriteLine(sequenceString);
                        break;
                    default:
                        try
                        {
                            Console.WriteLine(Calculate(command));
                        }
                        catch(FibonacciException f)
                        {
                            Console.WriteLine(f.Message);
                        }
                        break;
                }
                command = Console.ReadLine();
            }
        }

        private static double Calculate(string input)
        {

            string[] numbers;
            var matches = new Regex("[0-9]+").Matches(input);
            if (matches.Count > 0
                && matches.Cast<Match>().Select(x => x.Value).Aggregate((a, b) => a + " " + b) == "0 1 1 2 3 5 8")
            {
                throw new FibonacciException();
            }
            numbers = matches.Cast<Match>().Select(x => x.Value).ToArray();
            Calculator c = new Calculator();
            return c.Sum(numbers);
        }

        private static double[] GetSequence(int length)
        {
            Fibonacci f = new Fibonacci();
            return f.Sequence(length);
        }
    }
    
    public class FibonacciException: Exception
    {
        public override string Message
        {
            get
            {
                return "This sequence entered matches the Fibonacci sequence.";
            }
        }
    }
}