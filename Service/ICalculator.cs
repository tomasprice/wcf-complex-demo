using System.ServiceModel;

namespace WindowsServiceSample
{
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        ComplexNumber Multiply(
            ComplexNumber complexNumber, 
            ComplexNumber complexNumber_2,
            string complex = null);

        [OperationContract]
        ComplexNumber Substract(
            ComplexNumber complexNumber, 
            ComplexNumber complexNumber_2,
            string complex = null);

        [OperationContract]
        ComplexNumber Add(
            ComplexNumber complexNumber, 
            ComplexNumber complexNumber_2,
            string complex = null);


        [OperationContract]
        ComplexNumber Divade(
            ComplexNumber complexNumber, 
            ComplexNumber complexNumber_2,
            string complex = null);
    }
}
