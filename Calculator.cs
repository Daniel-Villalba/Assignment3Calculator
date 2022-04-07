using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3Calculator
{
    public class Calculator
    {
        public double num1;
        public double num2;
        public double result;

        double[] numArray;

        public Calculator() { }

        public Calculator(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        public double AddValues(double num1, double num2)
        {
            return num1 + num2;
        }
        static double AddValues(double[] additionArray) { 

            double result = 0;
            
            for(int i = 0; i < additionArray.Length; i++) 
            {
                result = result + additionArray[i];

            } 
            return result;
        }
        public double SubstractValues(double num1, double num2)
        {
            return num1 - num2;
        }
        static double SubstractValues(double[] substractionArray)
        {
            double result = substractionArray[0];
            for (int i = 1; i < substractionArray.Length; i++)
            {
                result = result - substractionArray[i];
            }
            return result;
        }
        public double MultiplyValues(double num1, double num2)
        {
            return num1 * num2;
        }
        public double DivideValues(double num1, double num2)
        {
            if (num1 != 0 && num2 != 0 )
                result = num1 / num2;

            else {
                Console.WriteLine("Its not possible to divide by 0!");
                result = 0;
            }
            return result;
        }
    }
}
