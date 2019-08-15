using Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("spots.boxcontent", Schema = "spots")]
    public class BoxContent : Entity
    {
        public int boxid { get; set; }
         public int itemid { get; set; }
        public int quantity { get; set; }
    }
}
