using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectIdea.Models
{
    public class Incident
    {
        public Incident(int customerId, DateTime timestamp)
        {
            CustomerId = customerId;
            Timestamp = timestamp;
        }
        public int CustomerId { get; set; }
        public DateTime Timestamp { get; set; }
        
    }
}