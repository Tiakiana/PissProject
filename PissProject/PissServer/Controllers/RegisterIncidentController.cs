using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PissServer.Models;

namespace PissServer.Controllers
{
    public class RegisterIncidentController : ApiController
    {
        

        // GET: api/RegisterIncident
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/RegisterIncident/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/RegisterIncident
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/RegisterIncident/5
        //int id, [FromBody]DateTime value
        public void Put()
        {
            

        }

        // DELETE: api/RegisterIncident/5
        public void Delete(int id)
        {
        }
    }
}
