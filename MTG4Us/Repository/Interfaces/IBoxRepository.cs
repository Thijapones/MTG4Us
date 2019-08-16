using Domain;
using Repository.Interfaces.Base;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface IBoxRepository : IRepository<Box>
    {
        void InsertNewBox(int spotid, int boxnumber);
        List<Box> GetbySpot(int spotid);

        List<Box> GetbySpotCust(int spotid, int custid);

        List<Box> GetbySpotOwner(int spotid, int ownerid);

        List<Box> GetbySpotBoxNumber(int spotid, int boxnumber);

        void UpdateBox(Wish wish);

        void SetBoxEmpty(int boxid);

        void SetBoxOccupied(int boxid);

        void RemoveBox(int boxid);
    }
}
