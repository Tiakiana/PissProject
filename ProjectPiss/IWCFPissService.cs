using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ProjectPiss.Models;

namespace ProjectPiss
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWCFPissService" in both code and config file together.
    [ServiceContract]
    public interface IWCFPissService
    {
        [OperationContract]
        void DoWork();
        [OperationContract]
        void RegisterIncident(int custId, DateTime timestamp);

        [OperationContract]
        //IQueryable<Incident> GetIncidents(int id);
        List<Incident> GetIncidents(int id);
    }
    
}
