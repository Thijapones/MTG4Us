using Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("spots.vwbox", Schema = "spots")]
    public class Box : Entity
    {
        public int boxnumber { get; set; }
        public int spotid { get; set; }
        public string spotname { get; set; }
        public int custid { get; set; }
        public string custname { get; set; }
        public int ownerid { get; set; }
        public string ownername { get; set; }
        public int shelfid { get; set; }
        public int itemid { get; set; }
        public string itemdescription { get; set; }
        public int quantity { get; set; }
        public bool status { get; set; }
    }
}
