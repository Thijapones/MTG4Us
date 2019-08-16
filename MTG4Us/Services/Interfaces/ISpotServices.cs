using Domain;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface ISpotServices
    {
        Spot Insert(Spot spot);

        Spot GetById(int id);

        Spot Update(Spot spot);

        List<Spot> GetAll();

        List<Spot> GetByName(string name);

        List<Spot> GetByCustomer(int custid);

        void InsertSpotToCustomer(int spotid, int custid);

        void InactivateSpot(int id);
    }
}
