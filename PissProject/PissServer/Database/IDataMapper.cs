using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PissServer.Database
{
    public interface IDataMapper<T>
    {
        void Create(T obj);
        T Read(int id);
        void Update(int id, T obj);
        void Delete(int id);
    }
}
