using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("transactions.wish", Schema = "transactions")]
    public class Wish : Entity
    {
        public int itemid { get; set; }
        public int quantity { get; set; }
        public DateTime returndate { get; set; }
        public DateTime expiringdate { get; set; }
        public int status { get; set; }
    }
}
