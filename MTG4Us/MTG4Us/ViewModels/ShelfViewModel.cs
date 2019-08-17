namespace Application.ViewModels
{
    public class ShelfViewModel
    {
        public int id { get; set; }
        public int custid { get; set; }
        public int itemid { get; set; }
        public string itemdescription { get; set; }
        public string conservation { get; set; }
        public int quantity { get; set; }
        public int availableqty { get; set; }
        public double marketprice { get; set; }
    }
}
