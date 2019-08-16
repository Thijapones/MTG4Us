using Domain;
using Repository.Interfaces.Base;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface IMTGCardRepository : IRepository<MTGCard>
    {
        List<MTGCard> GetByName(string name);

        List<MTGCard> GetBySet(string set);

        List<MTGCard> GetBySetCode(string setcode);

        List<MTGCard> GetByMTGId(string mtgid);
    }
}
