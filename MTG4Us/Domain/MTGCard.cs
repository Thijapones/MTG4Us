using Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("items.mtgcard", Schema = "items")]
    public class MTGCard : Entity
    {
        public string name { get; set; }
        public string set { get; set; }
        public string setcode { get; set; }
        public int mtgid { get; set; }
    }
}
