using Domain.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("transactions.exchange", Schema = "transactions")]
    public class Exchange : Entity
    {
        public int wishid { get; set; }
        public int bagid { get; set; }
        public int status { get; set; }
    }
}
