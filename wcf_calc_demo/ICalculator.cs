using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace wcf_calc_demo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICalculator
    {

        [OperationContract]
        ComplexNumber Multiply(
            ComplexNumber complexNumber, 
            ComplexNumber complexNumber_2,
            string complex = null);

        [OperationContract(Name = "DoublesMultiply")]
        ComplexNumber Multiply(
            double real_1, double imaginary_1,
            double real_2, double imaginary_2);

        [OperationContract]
        ComplexNumber Substract(
            ComplexNumber complexNumber, 
            ComplexNumber complexNumber_2,
            string complex = null);

        [OperationContract(Name = "DoublesSubstract")]
        ComplexNumber Substract(
            double real_1, double imaginary_1,
            double real_2, double imaginary_2);

        [OperationContract]
        ComplexNumber Add(
            ComplexNumber complexNumber, 
            ComplexNumber complexNumber_2,
            string complex = null);

        [OperationContract(Name = "DoublesAdd")]
        ComplexNumber Add(
            double real_1, double imaginary_1,
            double real_2, double imaginary_2);

        [OperationContract]
        ComplexNumber Divade(
            ComplexNumber complexNumber, 
            ComplexNumber complexNumber_2,
            string complex = null);

        [OperationContract(Name = "DoublesDivade")]
        ComplexNumber Divade(
            double real_1, double imaginary_1,
            double real_2, double imaginary_2);
    }
}
