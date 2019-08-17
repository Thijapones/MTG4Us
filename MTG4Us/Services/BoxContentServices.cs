using Business.Interfaces;
using Domain;
using Services.Interfaces;

namespace Services
{
    public class BoxContentServices : IBoxContentServices
    {
        private readonly IBoxContentBusiness _boxcontentBusiness;
        public BoxContentServices(IBoxContentBusiness boxcontentBusiness)
        {
            _boxcontentBusiness = boxcontentBusiness;
        }

        public void EmptyBox(int boxid)
        {
            _boxcontentBusiness.EmptyBox(boxid);
            return;
        }

        public void InsertNewContent(Wish wish, int boxid)
        {
            _boxcontentBusiness.InsertNewContent(wish, boxid);
            return;
        }
    }
}
