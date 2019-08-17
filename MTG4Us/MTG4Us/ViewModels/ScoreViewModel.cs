namespace Application.ViewModels
{
    public class ScoreViewModel
    {
        public int id { get; set; }
        public int custid { get; set; }
        public string name { get; set; }
        public double ownerpositive { get; set; }
        public double ownernegative { get; set; }
        public double borrowerpositive { get; set; }
        public double borrowernegative { get; set; }
        public double ownerreputation { get; set; }
        public double borrowerreputation { get; set; }
        public double overallreputation { get; set; }
    }
}
