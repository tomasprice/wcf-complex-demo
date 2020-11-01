using System;
using System.Runtime.Serialization;

namespace wcf_calc_demo
{
    [DataContract]
    public class DetailedException
    {
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public string Details { get; set; }

        [DataMember]
        public DateTime Date { get; set; }
    }
}