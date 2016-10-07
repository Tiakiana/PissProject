using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

using System.Runtime.Serialization;
using System.ServiceModel;

namespace ProjectPiss.Models
{
    [DataContract]
    public class Incident
    {
        [Key] [DataMember]
        public int CustomerId { get; set; }
        [DataMember]
        public DateTime Timestamp { get; set; }

        public Incident()
        {
            
        }

        public Incident(int customerId, DateTime timestamp)
        {

            CustomerId = customerId;
            Timestamp = timestamp;
        }
    }
}