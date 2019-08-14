using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("customers.score", Schema = "customers")]
    public class Score : Entity
    {
        public int custid { get; set; }
        public int ownerpositive { get; set; }
        public int ownernegative { get; set; }
        public int borrowerpositive { get; set; }
        public int borrowernegative { get; set; }
    }
}
