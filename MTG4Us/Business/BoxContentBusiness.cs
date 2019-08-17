using Business.Interfaces;
using Domain;
using Repository.Interfaces;

namespace Business
{
    public class BoxContentBusiness : IBoxContentBusiness
    {
        private readonly IBoxContentRepository _boxcontentRepository;

        public BoxContentBusiness(IBoxContentRepository boxcontentRepository)
        {
            _boxcontentRepository = boxcontentRepository;
        }

        public void EmptyBox(int boxid)
        {
            _boxcontentRepository.EmptyBox(boxid);
            return;
        }

        public void InsertNewContent(Wish wish, int boxid)
        {
            _boxcontentRepository.InsertNewContent(wish, boxid);
            return;
        }
    }
}
