using Business.Interfaces;
using Domain;
using Services.Interfaces;
using System.Collections.Generic;

namespace Services
{
    public class ShelfServices : IShelfServices
    {
        private readonly IShelfBusiness _shelfBusiness;
        public ShelfServices(IShelfBusiness shelfBusiness)
        {
            _shelfBusiness = shelfBusiness;
        }

        public List<Shelf> GetbyCustItem(int custid, int itemid)
        {
            return _shelfBusiness.GetbyCustItem(custid, itemid);
        }

        public List<Shelf> GetbyCustomer(int custid)
        {
            return _shelfBusiness.GetbyCustomer(custid);
        }

        public Shelf GetById(int shelfid)
        {
            return _shelfBusiness.GetById(shelfid);
        }

        public void InsertShelf(Shelf shelf)
        {
            _shelfBusiness.InsertShelf(shelf);
            return;
        }

        public void UpdateAvailQty(int shelfid, int quantity)
        {
            _shelfBusiness.UpdateAvailQty(shelfid, quantity);
            return;
        }

        public void UpdateMarketPrice(int shelfid, double price)
        {
            _shelfBusiness.UpdateMarketPrice(shelfid, price);
            return;
        }

        public void UpdateQty(int shelfid, int quantity)
        {
            _shelfBusiness.UpdateQty(shelfid, quantity);
            return;
        }
    }
}
