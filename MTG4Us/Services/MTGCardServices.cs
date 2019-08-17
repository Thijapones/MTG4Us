using Business.Interfaces;
using Domain;
using Services.Interfaces;
using System.Collections.Generic;

namespace Services
{
    public class MTGCardServices : IMTGCardServices
    {
        private readonly IMTGCardBusiness _mtgcardBusiness;
        public MTGCardServices(IMTGCardBusiness mtgcardBusiness)
        {
            _mtgcardBusiness = mtgcardBusiness;
        }

        public List<MTGCard> GetAll()
        {
            return _mtgcardBusiness.GetAll();
        }

        public List<MTGCard> GetByMTGId(int mtgid)
        {
            return _mtgcardBusiness.GetByMTGId(mtgid);
        }

        public List<MTGCard> GetByName(string name)
        {
            return _mtgcardBusiness.GetByName(name);
        }

        public List<MTGCard> GetBySet(string set)
        {
            return _mtgcardBusiness.GetBySet(set);
        }

        public List<MTGCard> GetBySetCode(string setcode)
        {
            return _mtgcardBusiness.GetBySetCode(setcode);
        }

    }
}
