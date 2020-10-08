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
        double real;
        double imaginary;

        public ComplexNumber(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }


        [DataMember]
        public double Real 
        {
            get { return real; }
            set { real = value; }
        }
       
        [DataMember]
        public double Imaginary
        {
            get { return imaginary; }
            set { imaginary = value; }
        }
    }
}