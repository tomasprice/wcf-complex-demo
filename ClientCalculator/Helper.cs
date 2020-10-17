using ClientCalculator.CalculatorServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientCalculator
{
    public class Helper
    {
        public ComplexNumber ComplexNumber { get; set; }

        public ComplexNumber GetComplex(string realString, string imaginaryString)
        {
            var real = double.Parse(realString.ToString());
            var imaginary = double.Parse(imaginaryString.ToString());

            return new ComplexNumber
            {
                Real = real,
                Imaginary = imaginary
            };
        }

        public string CreateUserOutput(ComplexNumber complexNumber)
        {
            if (complexNumber.Imaginary > 0)
            {
                return $"{complexNumber.Real} + {complexNumber.Imaginary}i";
            }
            complexNumber.Imaginary *= -1;
            return $"{complexNumber.Real} - {complexNumber.Imaginary}i";
        }

    }
}
