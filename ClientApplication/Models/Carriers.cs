using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace ClientApplication.Models
{
    [DataContract(Namespace = "http://schemas.datacontract.org/2004/07/RestService.Models")]
    [XmlType("carriers")]
    public class Carriers
    {
        public Carriers()
        {
        }

        public Carriers(string status, Dictionary<string, Carrier> carrierDictionary, object allCarriers)
        {
            Status = status;
            CarrierDictionary = carrierDictionary;
            AllCarriers = allCarriers;
        }

        [DataMember(Name = "status")]
        [XmlElement("status")]
        public string Status { get; set; }

        [DataMember(Name = "carriers")]
        [XmlElement("carrier")]
        public Dictionary<string, Carrier> CarrierDictionary { get; set; }

        public object AllCarriers { get; set; }

     



    }
}
