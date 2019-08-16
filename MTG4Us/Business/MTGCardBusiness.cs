using Business.Interfaces;
using Domain;
using Repository.Interfaces;
using System.Collections.Generic;

namespace Business
{
    public class MTGCardBusiness : IMTGCardBusiness
    {
        private readonly IMTGCardRepository _mtgcardRepository;

        public MTGCardBusiness(IMTGCardRepository mtgcardRepository)
        {
            _mtgcardRepository = mtgcardRepository;
        }

        public List<MTGCard> GetAll()
        {
            return _mtgcardRepository.GetAll();
        }

        public List<MTGCard> GetByMTGId(string mtgid)
        {
            return _mtgcardRepository.GetByMTGId(mtgid);
        }

        public List<MTGCard> GetByName(string name)
        {
            return _mtgcardRepository.GetByName(name);
        }

        public List<MTGCard> GetBySet(string set)
        {
            return _mtgcardRepository.GetBySet(set);
        }

        public List<MTGCard> GetBySetCode(string setcode)
        {
            return _mtgcardRepository.GetBySetCode(setcode);
        }
    }
}
