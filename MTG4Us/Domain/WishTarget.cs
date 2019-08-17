using Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("transactions.vwwishtarget", Schema = "customers")]
    public class WishTarget : Entity
    {
        public int wishid { get; set; }
        public int custid { get; set; }
        public int spotid { get; set; }
        public string spot { get; set; }
        public int ownerid { get; set; }
        public string owner { get; set; }
        public int shelfid { get; set; }
        public int itemid { get; set; }
        public string itemdescription { get; set; }
        public int quantity { get; set; }
        public double marketprice { get; set; }
    }
}
