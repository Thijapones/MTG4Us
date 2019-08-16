using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IBoxBusiness
    {
        /// <summary>
        /// A box is a physical recipient created in a spot.
        /// A box will be filled when a wish is granted or when an wished item has returned.
        /// Only a store manager can handle boxes.
        /// </summary>

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
