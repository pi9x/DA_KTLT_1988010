using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA_KTLT_1988010.DAL
{
    public class MongoDbReader : IDataReader
    {
        readonly string connectionName;
        public List<T> Read<T>()
        {
            throw new NotImplementedException();
        }
    }
}
