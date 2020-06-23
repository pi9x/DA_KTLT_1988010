using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA_KTLT_1988010.BLL.Repositoties
{
    interface IRepository<T>
    {
        void Create(T obj);
        List<T> Read(string key);
        bool Update(T obj);
        bool Delete(int key);
    }
}
