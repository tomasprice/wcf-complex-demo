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
            string complex);

        [OperationContract]
        ComplexNumber Substract(
            ComplexNumber complexNumber, 
            ComplexNumber complexNumber_2,
            string complex);

        [OperationContract]
        ComplexNumber Add(
            ComplexNumber complexNumber, 
            ComplexNumber complexNumber_2,
            string complex);

        [OperationContract]
        ComplexNumber Divade(
            ComplexNumber complexNumber, 
            ComplexNumber complexNumber_2,
            string complex);
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
