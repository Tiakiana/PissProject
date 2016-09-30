using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PissServer.Models;

namespace PissServer.Controllers
{
    public class DatabaseFacade
    {
        private Database.IDataMapper<Models.Incident> db;
        public DatabaseFacade(Database.IDataMapper<Models.Incident> dba)
        {
            db = dba;
        }

        
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        
        public string Get(int id)
        {
            return "value";
        }

        

        public void Create(Incident incident)
        {
            db.Create(incident);
        }
        
        
        public void Delete(int id)
        {
        }
    }
}