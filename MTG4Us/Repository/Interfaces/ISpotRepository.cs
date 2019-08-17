using Domain;
using Repository.Interfaces.Base;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface ISpotRepository : IRepository<Spot>
    {
        List<Spot> GetByName(string name);

        List<Spot> GetByCustomer(int custid);

        void InsertSpotToCustomer(int spotid, int custid);

        void RemoveSpotToCustomer(int spotid, int custid);

        void InactivateSpot(int id);

        void ActivateSpot(int id);
    }
}
