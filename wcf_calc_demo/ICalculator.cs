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
        [FaultContract(typeof(DetailedException))]
        ComplexNumber Multiply(
            ComplexNumber complexNumber, 
            ComplexNumber complexNumber_2,
            string complex = null);

        [OperationContract(Name = "DoublesMultiply")]
        [FaultContract(typeof(DetailedException))]
        ComplexNumber Multiply(
            double real_1, double imaginary_1,
            double real_2, double imaginary_2);

        [OperationContract]
        [FaultContract(typeof(DetailedException))]
        ComplexNumber Substract(
            ComplexNumber complexNumber, 
            ComplexNumber complexNumber_2,
            string complex = null);

        [OperationContract(Name = "DoublesSubstract")]
        [FaultContract(typeof(DetailedException))]
        ComplexNumber Substract(
            double real_1, double imaginary_1,
            double real_2, double imaginary_2);

        [OperationContract]
        [FaultContract(typeof(DetailedException))]
        ComplexNumber Add(
            ComplexNumber complexNumber, 
            ComplexNumber complexNumber_2,
            string complex = null);

        [OperationContract(Name = "DoublesAdd")]
        [FaultContract(typeof(DetailedException))]
        ComplexNumber Add(
            double real_1, double imaginary_1,
            double real_2, double imaginary_2);

        [OperationContract]
        [FaultContract(typeof(DetailedException))]
        ComplexNumber Divade(
            ComplexNumber complexNumber, 
            ComplexNumber complexNumber_2,
            string complex = null);

        [OperationContract(Name = "DoublesDivade")]
        [FaultContract(typeof(DetailedException))]
        ComplexNumber Divade(
            double real_1, double imaginary_1,
            double real_2, double imaginary_2);
    }
}
