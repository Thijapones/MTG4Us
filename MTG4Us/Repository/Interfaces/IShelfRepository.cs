using Domain;
using Repository.Interfaces.Base;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface IShelfRepository : IRepository<Shelf>
    {
        List<Shelf> GetbyCustomer(int custid);

        List<Shelf> GetbyCustItem(int custid, int itemid);

        void InsertShelf(Shelf shelf);

        void UpdateQty(int shelfid, int quantity);

        void UpdateAvailQty(int shelfid, int quantity);

        void UpdateMarketPrice(int shelfid, double price);
    }
}
