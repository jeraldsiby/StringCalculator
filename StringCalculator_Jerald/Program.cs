using System;

namespace StringCalculator_Jerald
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---CALCULATOR---");
            Calculator calculator = new Calculator();

            int answer = calculator.Add("1,2,3");
            Console.WriteLine("Adding {1,2,3} Ans---  " + answer + "\n");

            answer = calculator.Add("");
            Console.WriteLine("Adding {} Ans---  " + answer + "\n");

            answer = calculator.Add("1\n,2,3");
            Console.WriteLine("Adding {1\n,2,3} Ans---  " + answer + "\n");

            answer = calculator.Add("1,\n2,4");
            Console.WriteLine("Adding {1,\n2,4} Ans---  " + answer + "\n");

            answer = calculator.Add("//;\n1;3;4");
            Console.WriteLine("Adding {//;\n1;3;4} Ans---  " + answer + "\n");

            answer = calculator.Add("//$\n1$2$3");
            Console.WriteLine("Adding {//$\n1$2$3} Ans---  " + answer + "\n");

            answer = calculator.Add("//@\n2@3@8");
            Console.WriteLine("Adding {//@\n2@3@8} Ans---  " + answer + "\n");

            Console.WriteLine("Adding {-1}");
            answer = calculator.Add("-1");
            Console.WriteLine("\n");

            answer = calculator.Add("//@\n2@3@1001");
            Console.WriteLine("Adding {//@\n2@3@1001} Ans---  " + answer + "\n");

            answer = calculator.Add("//***\n1***2***3");
            Console.WriteLine("Adding {//***\n1***2***3} Ans---  " + answer + "\n");

            Console.ReadLine();
        }
    }
}
