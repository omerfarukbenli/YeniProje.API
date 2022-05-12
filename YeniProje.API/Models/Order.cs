using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace YeniProje.API.Models
{
    public class Order
    {
        [Key]
        public int Order_Id { get; set; }
        public int Customer_Id { get; set; }
        public string Order_Date { get; set; }
        public  Customer Customer { get; set; }
        public  List<OrderDetail> OrderDetails { get; set; }
    }
}
