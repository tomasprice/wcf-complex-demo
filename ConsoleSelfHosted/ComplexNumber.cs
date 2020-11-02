using System;
using System.Runtime.Serialization;

namespace ConsoleSelfHosted
{
    [DataContract]
    public class ComplexNumber
    {
        private double real;
        private double imaginary;

        public ComplexNumber() { }

        public ComplexNumber(double real, double imaginary)
        {
            this.real = RoundInput(real);
            this.imaginary = RoundInput(imaginary);
        }

        [DataMember]
        public double Real 
        {
            get { return real; }
            set { real = RoundInput(value); }
        }
       
        [DataMember]
        public double Imaginary
        {
            get { return imaginary; }
            set { imaginary = RoundInput(value); }
        }

        public override string ToString()
        {
            return $"{real} {imaginary}i";
        }

        private double RoundInput(double input) => Math.Round(input, 4);
    }
}