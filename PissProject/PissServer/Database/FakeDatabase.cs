using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PissServer.Database
{
    public class FakeDatabase : IDataMapper<Models.Incident>
    {
        public void Create(Models.Incident obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Models.Incident Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Models.Incident obj)
        {
            throw new NotImplementedException();
        }
    }
}