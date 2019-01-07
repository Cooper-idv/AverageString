using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAverage
{
    public class Kata001
    {
        public static string AverageString(string str)
        {
            // Code away
            string[] arrNumber = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] arrValue = str.Split(' ');
            int inputCount = arrValue.Length;
            int sumOfInput = 0;
            int avgOfInput = 0;
            bool outOfRange = true;

            if (inputCount == 0)
            {
                return "n/a";
            }

            foreach (string X in arrValue)
            {
                outOfRange = true;
                for (int i = 0; i < arrNumber.Length; i++)
                {
                    if (X == arrNumber[i])
                    {
                        sumOfInput += i;
                        outOfRange = false;
                    }
                }
                if (outOfRange == true)
                {
                    return "n/a";
                }
            }

            if (sumOfInput == 0)
            {
                return arrNumber[0];
            }
            else
            {
                avgOfInput = sumOfInput / inputCount;
                return arrNumber[avgOfInput];
            }
        }
    }
}
