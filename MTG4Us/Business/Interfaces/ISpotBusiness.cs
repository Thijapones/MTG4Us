using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface ISpotBusiness
    {
        /// <summary>
        /// A Spot cannot be removed.
        /// Instead, it should be set as Inactive.
        /// </summary>
        /// <returns></returns>
        Spot Insert(Spot spot);

        Spot GetbyId(int id);

        Spot Update(Spot spot);

        List<Spot> GetAll();

        List<Spot> GetByName(string name);

        List<Spot> GetByCustomer(int custid);

        void InsertSpotToCustomer(int spotid, int custid);

        void InactivateSpot(int id);
    }
}
