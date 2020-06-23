using System;

namespace DA_KTLT_1988010.BLL.Entities
{
    public class Bill
    {
        public int ID { get; set; }
        public DateTime Time { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
