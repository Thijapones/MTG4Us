using Domain;
using Repository.Interfaces.Base;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface IShelfRepository : IRepository<Shelf>
    {
        List<Shelf> ExecuteQuery(int custid, int itemid);
    }
}
