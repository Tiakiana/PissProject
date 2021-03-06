﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ProjectPiss.Logging;
using ProjectPiss.Models;

namespace ProjectPiss
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WCFPissService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WCFPissService.svc or WCFPissService.svc.cs at the Solution Explorer and start debugging.
    public class WCFPissService : IWCFPissService
    {

        Models.ProjectPissContext dataContext = new Models.ProjectPissContext();

        public void DoWork()
        {
        }

        public void RegisterIncident(int custId, DateTime timestamp)
        {
            Models.Incident inc = new Models.Incident(custId,timestamp);
            dataContext.Incidents.Add(inc);
            Logging.LogWriter lw = new LogWriter(DateTime.Now + " Customer: " + custId + "Time:" + timestamp + "\n");
        }

        public List<Incident> GetIncidents(int id) {
           
            Logging.LogWriter lw = new LogWriter(DateTime.Now + "Tried access of " + id);

            List<Incident> incidents = dataContext.Incidents.ToList();

            return incidents.Where(i => i.CustomerId == id).ToList();
            

            //foreach (var item in collection)
            //{

            //} 

            //return dataContext.Incidents.Where(i => i.CustomerId == id).ToList();


        }
    }
}
