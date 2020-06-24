using DA_KTLT_1988010.BLL.Entities;
using DA_KTLT_1988010.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA_KTLT_1988010.BLL.Repositoties
{
    public class ProductRepo : IRepository<Product>
    {
        readonly IDataReader reader = new JsonReader("Data/JSON/product.json");
        readonly IDataWriter writer = new JsonWriter("Data/JSON/product.json");
        public void Create(Product obj)
        {
            var products = reader.Read<Product>();
            products.Add(obj);
            writer.Write(products);
        }

        public List<Product> Read(string key)
        {
            List<Product> results = new List<Product>();
            var products = reader.Read<Product>();
            if (key == null) key = "";
            foreach (Product product in products)
                if (product.Name.ToUpper().Contains(key.ToUpper())) results.Add(product);
            return results;
        }

        public bool Update(Product obj)
        {
            var products = reader.Read<Product>();
            Product found = products.Find(p => p.ID == obj.ID);
            if (found != null)
            {
                products.Remove(found);
                products.Add(obj);
                writer.Write(products);
                return true;
            }
            return false;
        }

        public bool Delete(int key)
        {
            var products = reader.Read<Product>();
            Product found = products.Find(p => p.ID == key);
            if (found != null)
            {
                products.Remove(found);
                writer.Write(products);
                return true;
            }
            return false;
        }
    }
}
