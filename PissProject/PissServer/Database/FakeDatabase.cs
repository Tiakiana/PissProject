using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PissServer.Database
{
    public class FakeDatabase : IDataMapper
    {
        public void Create(object obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public object Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, object obj)
        {
            throw new NotImplementedException();
        }
    }
}