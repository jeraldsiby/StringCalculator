using System;
using System.Collections.Generic;
using System.Text;

namespace StringCalculator_Jerald
{
    public class Calculator
    {
        //Add method that takes input string
        public int Add(string numbers)
        {
            //checking if the input is empty
            if (numbers != "")
            {
                string[] numberArray;
                //converting to a character array
                char[] charArray = numbers.ToCharArray(0, numbers.Length);
                //checking for delimiter
                if (charArray[0] == '/' && charArray[1] == '/')
                {
                    string[] splitStrings = numbers.Split("\n");
                    string delimiter = splitStrings[0].Replace("//", "");
                    numbers = numbers.Replace("//" + delimiter, "");
                    numbers = numbers.Replace("\n", "");
                    numberArray = numbers.Split(delimiter);
                }
                else
                {
                    string cleaned = numbers.Replace("\n", "");
                    numberArray = cleaned.Split(",");
                }
                return Addition(numberArray);
            }
            else
                return 0;
        }

        //function for addition of individual elements
        private int Addition(string[] numberArray)
        {
            int number = 0;
            int total = 0;
            //loop for addition after filtering the characters
            foreach (var num in numberArray)
            {
                try
                {
                    //parsing each element to int for addition
                    if (Int32.TryParse(num, out number))
                    {
                        if (number >= 0)
                        {
                            //condition to ignore the numbers larger than 1000
                            if (number <= 1000)
                                total += number;
                        }
                        else
                            throw new ArgumentException("Negatives not allowed: " + number);
                    }
                    else
                        //"0" returned for a bad string
                        return 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return -1;
                }
            }
            return total;
        }
    }
}
