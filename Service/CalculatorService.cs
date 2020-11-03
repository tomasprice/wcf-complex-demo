﻿using System;

namespace WindowsServiceSample
{
    public class CalculatorService : ICalculator
    {
        public ComplexNumber Add(
            ComplexNumber complexNumber,
            ComplexNumber complexNumber_2,
            string complex = null)

        {
            if (complex != null)
            {
                int divader = complex.IndexOf(" ");
                complexNumber = ConvertString(complex, 0, divader);
                complexNumber_2 = ConvertString(complex, ++divader, complex.Length - 1);
            }

            var realOutput = complexNumber.Real + complexNumber_2.Real;
            var imaginaryOuptut = complexNumber.Imaginary + complexNumber_2.Imaginary;

            var result = new ComplexNumber(realOutput, imaginaryOuptut);

            return result;
        }


        public ComplexNumber Substract(
            ComplexNumber complexNumber,
            ComplexNumber complexNumber_2,
            string complex = null)
        {
            if (complex != null)
            {
                int divader = complex.IndexOf(" ");
                complexNumber = ConvertString(complex, 0, divader);
                complexNumber_2 = ConvertString(complex, ++divader, complex.Length - 1);
            }

            var realOutput = complexNumber.Real - complexNumber_2.Real;
            var imaginaryOuptut = complexNumber.Imaginary - complexNumber_2.Imaginary * (-1);

            var result = new ComplexNumber(realOutput, imaginaryOuptut);

            return result;
        }


        public ComplexNumber Multiply(
                ComplexNumber complexNumber,
                ComplexNumber complexNumber_2,
                string complex = null)
        {
            if (complex != null)
            {
                int divader = complex.IndexOf(" ");
                complexNumber = ConvertString(complex, 0, divader);
                complexNumber_2 = ConvertString(complex, ++divader, complex.Length - 1);
            }

            var realOutput = (complexNumber.Real * complexNumber_2.Real)
                + ((complexNumber.Imaginary * complexNumber_2.Imaginary) * (-1));

            var imaginaryOutput = (complexNumber.Real * complexNumber_2.Imaginary)
                + (complexNumber.Imaginary * complexNumber_2.Real);

            var result = new ComplexNumber(realOutput, imaginaryOutput);

            return result;
        }

        public ComplexNumber Divade(
            ComplexNumber complexNumber,
            ComplexNumber complexNumber_2,
            string complex = null)
        {
            if (complex != null)
            {
                int divader = complex.IndexOf(" ");
                complexNumber = ConvertString(complex, 0, divader);
                complexNumber_2 = ConvertString(complex, ++divader, complex.Length - 1);
            }

            var realOutput = (complexNumber.Real * complexNumber_2.Real)
                - ((complexNumber.Imaginary * complexNumber_2.Imaginary) * (-1));

            var imaginaryOutput = (complexNumber.Imaginary * complexNumber_2.Real) + (complexNumber_2.Imaginary * complexNumber.Real) * (-1);

            var downLine = (complexNumber_2.Real * complexNumber_2.Real)
                - ((complexNumber_2.Imaginary * complexNumber_2.Imaginary) * (-1));


            var result = new ComplexNumber(realOutput / downLine, imaginaryOutput / downLine);

            return result;
        }

        private ComplexNumber ConvertString(
            string userInput,
            int indexStart,
            int indexEnd)
        {
            ComplexNumber complex = new ComplexNumber();
            bool start = true;
            bool negation = false;
            string helper = "";

            for (int i = indexStart; i <= indexEnd; i++)
            {
                if (start)
                {
                    if ((char)userInput[i] == 45)
                    {
                        helper += "-";
                        i++;
                    }
                    start = false;
                }
                if (!start && (char)userInput[i] == 45)
                {
                    negation = true;
                }

                if ((char)userInput[i] >= 48 && (char)userInput[i] <= 57)
                {
                    if (negation)
                    {
                        helper += "-";
                    }
                    helper += (char)userInput[i];
                    negation = false;
                }
                else
                {
                    if (complex.Real == 0)
                    {
                        complex.Real = double.Parse(helper);
                        helper = "";
                    }
                }
            }
            complex.Imaginary = double.Parse(helper);
            return complex;
        }
    }
}
