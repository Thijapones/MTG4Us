using Domain;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IBoxServices
    {
        void InsertNewBox(int spotid, int boxnumber);

        Box GetById(int boxid);

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
