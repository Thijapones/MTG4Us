using Domain;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IMTGCardServices
    {
        List<MTGCard> GetByName(string name);

        List<MTGCard> GetBySet(string set);

        List<MTGCard> GetBySetCode(string setcode);

        List<MTGCard> GetByMTGId(int mtgid);

        List<MTGCard> GetAll();
    }
}
