using Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("customers.bag", Schema = "customers")]
    public class Bag : Entity
    {
        public int custid { get; set; }
        public int ownerid { get; set; }
        public int itemid { get; set; }
        public int quantity { get; set; }
        public int wishid { get; set; }
        public int status { get; set; }
    }
}
