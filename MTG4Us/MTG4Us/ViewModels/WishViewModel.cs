﻿using System;

namespace Application.ViewModels
{
    public class WishViewModel
    {
        public int id { get; set; }
        public int custid { get; set; }
        public int ownerid { get; set; }
        public int shelfid { get; set; }
        public int bagid { get; set; }
        public int itemid { get; set; }
        public string itemdescription { get; set; }
        public int quantity { get; set; }
        public int spotid { get; set; }
        public string spot { get; set; }
        public int boxid { get; set; }
        public string boxnumber { get; set; }
        public DateTime returndate { get; set; }
        public DateTime expiringdate { get; set; }
        public int status { get; set; }
    }
}
