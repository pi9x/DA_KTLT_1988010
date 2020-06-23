using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA_KTLT_1988010.DAL
{
    public class MongoDbWriter : IDataWriter
    {
        readonly string connectionName;
        public void Write<T>(List<T> objects)
        {
            throw new NotImplementedException();
        }
    }
}
