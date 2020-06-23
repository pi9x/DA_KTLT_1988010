using DA_KTLT_1988010.BLL.Entities;
using DA_KTLT_1988010.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA_KTLT_1988010.BLL.Repositoties
{
    public class BillRepo : IRepository<Bill>
    {
        readonly IDataReader reader = new JsonReader("Data/JSON/bill.json");
        readonly IDataWriter writer = new JsonWriter("Data/JSON/bill.json");
        public void Create(Bill obj)
        {
            var bills = reader.Read<Bill>();
            bills.Add(obj);
            writer.Write(bills);
        }

        public List<Bill> Read(string key)
        {
            List<Bill> results = new List<Bill>();
            var bills = reader.Read<Bill>();
            foreach (Bill bill in bills)
                if (bill.Product.Name.Contains(key)) results.Add(bill);
            return results;
        }

        public bool Update(Bill obj)
        {
            var bills = reader.Read<Bill>();
            Bill found = bills.Find(b => b.ID == obj.ID);
            if (found != null)
            {
                bills.Remove(found);
                bills.Add(obj);
                writer.Write(bills);
                return true;
            }
            return false;
        }

        public bool Delete(int key)
        {
            var bills = reader.Read<Bill>();
            Bill found = bills.Find(b => b.ID == key);
            if (found != null)
            {
                bills.Remove(found);
                writer.Write(bills);
                return true;
            }
            return false;
        }
    }
}
