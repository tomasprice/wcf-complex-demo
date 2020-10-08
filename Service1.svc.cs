using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_calc_demo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CalculatorService : ICalculator
    {
        public ComplexNumber Add(ComplexNumber complexNumber, ComplexNumber complexNumber_2)
        {
            var realOutput = complexNumber.Real + complexNumber_2.Real;
            var imaginaryOuptut = complexNumber.Imaginary + complexNumber_2.Imaginary;

            var result = new ComplexNumber(realOutput, imaginaryOuptut);

            return result;
        }

        public ComplexNumber Divade(ComplexNumber complexNumber, ComplexNumber complexNumber_2)
        {

            var realOutput = (complexNumber.Real * complexNumber_2.Real)
                - ((complexNumber.Imaginary * complexNumber_2.Imaginary) * (-1));

            var imaginaryOutput = (complexNumber.Imaginary * complexNumber_2.Real) + (complexNumber_2.Real * complexNumber.Imaginary);

            var downLine = (complexNumber_2.Real * complexNumber_2.Real)
                - ((complexNumber_2.Imaginary * complexNumber_2.Imaginary) * (-1));


            var result = new ComplexNumber(realOutput / downLine, imaginaryOutput / downLine);


            return result;
        }

        public ComplexNumber Multiply(ComplexNumber complexNumber, ComplexNumber complexNumber_2)
        {
            var realOutput = (complexNumber.Real * complexNumber_2.Real)
                + ((complexNumber.Imaginary * complexNumber_2.Imaginary) * (-1));

            var imaginaryOutput = (complexNumber.Real * complexNumber_2.Imaginary)
                + (complexNumber.Imaginary * complexNumber_2.Real);

            var result = new ComplexNumber(realOutput, imaginaryOutput);

            return result;
        }

        public ComplexNumber Substract(ComplexNumber complexNumber, ComplexNumber complexNumber_2)
        {
            var realOutput = complexNumber.Real - complexNumber_2.Real;
            var imaginaryOuptut = complexNumber.Imaginary - complexNumber_2.Imaginary;

            var result = new ComplexNumber(realOutput, imaginaryOuptut);

            return result;
        }
    }
}
