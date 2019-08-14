using Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("spots.box", Schema = "spots")]
    public class Box : Entity
    {
        public int spotid { get; set; }
        public int custid { get; set; }
        public int itemid { get; set; }
        public int quantity { get; set; }
        public bool status { get; set; }
    }
}
