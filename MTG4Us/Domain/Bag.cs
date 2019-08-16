using Domain.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("customers.vwbag", Schema = "customers")]
    public class Bag : Entity
    {
        public int custid { get; set; }
        public string custname { get; set; }
        public int ownerid { get; set; }
        public string ownername { get; set; }
        public int itemid { get; set; }
        public string itemdescription { get; set; }
        public int quantity { get; set; }
        public int wishid { get; set; }
        public DateTime returndate { get; set; }
        public int status { get; set; }
    }
}
