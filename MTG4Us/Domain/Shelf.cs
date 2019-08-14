using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("customers.shelf", Schema = "customers")]
    public class Shelf : Entity
    {
        public int custid { get; set; }
        public int itemid { get; set; }
        public string conservation { get; set; }
        public int quantity { get; set; }
        public double marketprice { get; set; }
    }
}
