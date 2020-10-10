using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace wcf_calc_demo
{
    [DataContract]
    public class ComplexNumber
    {
        private double real;
        private double imaginary;

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

        private double RoundInput(double input) => Math.Round(input, 4);
    }
}