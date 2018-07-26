using System;
using System.Linq;

namespace Experiment_Mk._1
{
    class Program
    {
        static void Main(string[] args)
        {
        Calculator:
            try
            { 
            string input = Console.ReadLine();          
            
                int[] Numbers = { 1, 2 };
                string[] StringSplitter()
                {
                    char[] delimiterChars = { '-', '+', '*', '/' };
                    string data = input;
                    string[] factors = data.Split(delimiterChars);
                return factors;
                }
                if (input.Contains('*'))
                {
                    var Factor = StringSplitter();
                    int Calc1 = Convert.ToInt32(Factor[0]);
                    int Calc2 = Convert.ToInt32(Factor[1]);
                    int awnser = Calc1 * Calc2;
                    Console.WriteLine(awnser);
                }
                else if (input.Contains('/'))
                {
                    var Factor = StringSplitter();
                    int Calc1 = Convert.ToInt32(Factor[0]);
                    int Calc2 = Convert.ToInt32(Factor[1]);
                    int awnser = Calc1 / Calc2;
                    Console.WriteLine(awnser);
                }
                else if (input.Contains('+'))
                {
                    var Factor = StringSplitter();
                    int Calc1 = Convert.ToInt32(Factor[0]);
                    int Calc2 = Convert.ToInt32(Factor[1]);
                    int awnser = Calc1 + Calc2;
                    Console.WriteLine(awnser);
                }
                else if (input.Contains('-'))
                {
                    var Factor = StringSplitter();
                    int Calc1 = Convert.ToInt32(Factor[0]);
                    int Calc2 = Convert.ToInt32(Factor[1]);
                    int awnser = Calc1 - Calc2;
                    Console.WriteLine(awnser);
                }
                else
                {
                    Console.WriteLine("That's no equation...");
                }
            }        
            
            catch(Exception)
            {
                Console.WriteLine("That's no equation...");
            }
            goto Calculator;
        }
    }
}




//int input = Int32.Parse(Console.ReadLine());
//int input2 = Int32.Parse(Console.ReadLine());
//int output = input + input2;
//Console.WriteLine(output);
//Console.ReadLine();