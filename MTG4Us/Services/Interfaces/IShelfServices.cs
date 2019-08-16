using Domain;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IShelfServices
    {
        Shelf GetById(int shelfid);

        void InsertShelf(Shelf shelf);

        List<Shelf> GetbyCustomer(int custid);

        List<Shelf> GetbyCustItem(int custid, int itemid);

        void UpdateQty(int shelfid, int quantity);

        void UpdateAvailQty(int shelfid, int quantity);

        void UpdateMarketPrice(int shelfid, double price);
    }
}
