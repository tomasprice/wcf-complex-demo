using System.ServiceModel;

namespace WindowsService
{
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
