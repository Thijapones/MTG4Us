using Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("spots.spot", Schema = "spots")]
    public class Spot : Entity
    {
        public string name { get; set; }
        public string document { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string workinghours { get; set; }
        public bool status { get; set; }
    }
}
