using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IShelfBusiness
    {
        /// <summary>
        ///A shelf will never be removed. An item quantity as well as its available quantity should be set to 0 
        ///instead.
        ///A shelf will accomodate any quantity of a given item with a given conservation state.
        ///Two distinct items must always be accommodated within two different shelves.
        /// </summary>

        Shelf GetById(int shelfid);

        void InsertShelf(Shelf shelf);

        List<Shelf> GetbyCustomer(int custid);

        List<Shelf> GetbyCustItem(int custid, int itemid);

        void UpdateQty(int shelfid, int quantity);

        void UpdateAvailQty(int shelfid, int quantity);

        void UpdateMarketPrice(int shelfid, double price);
    }
}
