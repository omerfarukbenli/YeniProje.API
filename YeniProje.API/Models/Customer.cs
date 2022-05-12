using System.ComponentModel.DataAnnotations;

namespace YeniProje.API.Models
{
    public class Customer
    {
        [Key]
        public int Customer_Id { get; set; }
        public string Firstname { get; set; }
        public string Surname { get; set; }
        public string Job { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string Postal_Code { get; set; }
        public string Phone { get; set; }
        public string Card_name { get; set; }
        public string Card_number { get; set; }
        public string Expiration { get; set; }
        public string Cvv { get; set; }
        public string Taksit { get; set; }
    }
}
