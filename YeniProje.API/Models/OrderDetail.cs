using System.ComponentModel.DataAnnotations;

namespace YeniProje.API.Models
{
    public class OrderDetail
    {
        [Key]
        public int Order_Id { get; set; }
        public int Product_Id { get; set; }
        public string Price { get; set; }
        public  Order Order { get; set; }
        public  Product Product { get; set; }
    }
}
