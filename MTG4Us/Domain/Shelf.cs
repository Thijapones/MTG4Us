﻿using Domain.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    [Table("customers.vwshelf", Schema = "customers")]
    public class Shelf : Entity
    {
        public int custid { get; set; }
        public int itemid { get; set; }
        public string itemdescription { get; set; }
        public string conservation { get; set; }
        public int quantity { get; set; }
        public int availableqty { get; set; }
        public double marketprice { get; set; }
    }
}
