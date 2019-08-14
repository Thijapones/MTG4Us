using Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("customers.customer", Schema = "customers")]
    public class Customer : Entity
    {
        public string name { get; set; }
        public string mobilephone { get; set; }
        public string email { get; set; }
        public bool status { get; set; }
    }
}
