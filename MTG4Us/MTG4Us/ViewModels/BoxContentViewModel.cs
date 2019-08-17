using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class BoxContentViewModel
    {
        public int id { get; set; }
        public int boxid { get; set; }
        public int custid { get; set; }
        public int ownerid { get; set; }
        public int shelfid { get; set; }
        public int itemid { get; set; }
        public int quantity { get; set; }
    }
}
