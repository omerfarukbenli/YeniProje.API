using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace YeniProje.API.Models
{
    public class Product
    {
        [Key]
        public int Product_Id { get; set; }
        public string Product_Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public  ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
