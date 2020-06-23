using System;

namespace DA_KTLT_1988010.BLL.Entities
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Exp { get; set; }
        public string Manufacturer { get; set; }
        public Category Category { get; set; }
    }
}
