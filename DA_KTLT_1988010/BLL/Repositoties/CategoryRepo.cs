using DA_KTLT_1988010.BLL.Entities;
using DA_KTLT_1988010.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA_KTLT_1988010.BLL.Repositoties
{
    public class CategoryRepo : IRepository<Category>
    {
        readonly IDataReader reader = new JsonReader("Data/JSON/category.json");
        readonly IDataWriter writer = new JsonWriter("Data/JSON/category.json");
        public void Create(Category obj)
        {
            var categories = reader.Read<Category>();
            categories.Add(obj);
            writer.Write(categories);
        }

        public List<Category> Read(string key)
        {
            List<Category> results = new List<Category>();
            var categories = reader.Read<Category>();
            if (key == null) key = "";
            foreach (Category category in categories)
                if (category.Name.ToUpper().Contains(key.ToUpper())) results.Add(category);
            return results;
        }

        public bool Update(Category obj)
        {
            var categories = reader.Read<Category>();
            int index = categories.FindIndex(c => c.ID == obj.ID);
            if (index != -1)
            {
                categories[index].Name = obj.Name;
                writer.Write(categories);
                return true;
            }
            return false;
        }

        public bool Delete(int key)
        {
            var categories = reader.Read<Category>();
            Category found = categories.Find(c => c.ID == key);
            if (found != null)
            {
                categories.Remove(found);
                writer.Write(categories);
                return true;
            }
            return false;
        }
    }
}
