using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class BagViewModel
    {
        public int id { get; set; }
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
