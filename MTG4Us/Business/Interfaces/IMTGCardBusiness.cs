using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IMTGCardBusiness
    {
        /// <summary>
        /// No changes are allowed for this entity. 
        /// New cards will be added directly into the DataBase.
        /// </summary>
        /// <returns></returns>

        List<MTGCard> GetByName(string name);

        List<MTGCard> GetBySet(string set);

        List<MTGCard> GetBySetCode(string setcode);

        List<MTGCard> GetByMTGId(int mtgid);

        List<MTGCard> GetAll();
    }
}
