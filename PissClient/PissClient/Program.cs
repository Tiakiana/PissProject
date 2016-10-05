using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PissClient
{
    class Program
    {
        static void Main(string[] args)
        {
            PissServer.WCFPissServiceClient ps = new PissServer.WCFPissServiceClient();
            ps.RegisterIncident(1, DateTime.Now);
            Console.WriteLine("Der er penge i pisset");
           // Console.ReadKey();
            foreach (PissServer.Incident item in ps.GetIncidents(1))
            {
                Console.WriteLine(item.Timestamp);
            }

            Console.ReadKey();


        }
    }
}
