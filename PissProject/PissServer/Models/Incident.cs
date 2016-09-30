using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PissServer.Models
{
    public class Incident
    {
        public int Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public Incident(int id, DateTime timeStamp)
        {
            Id = id;
            TimeStamp = timeStamp;
        }
    }
}