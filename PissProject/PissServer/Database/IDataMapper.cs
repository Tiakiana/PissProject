using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PissServer.Database
{
    interface IDataMapper
    {
        void Create(object obj);
        object Read(int id);
        void Update(int id, object obj);
        void Delete(int id);
    }
}
