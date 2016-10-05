using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectPiss.Models
{
    public class Incident
    {
        [Key]
        public int CustomerId { get; set; }
        public DateTime Timestamp { get; set; }
       
        public Incident(int customerId, DateTime timestamp)
        {
            
            CustomerId = customerId;
            Timestamp = timestamp;
        }
    }
}