using Business.Interfaces;
using Domain;
using Repository.Interfaces;
using System.Collections.Generic;

namespace Business
{
    public class ShelfBusiness : IShelfBusiness
    {
        private readonly IShelfRepository _shelfRepository;

        public ShelfBusiness(IShelfRepository shelfRepository)
        {
            _shelfRepository = shelfRepository;
        }

        public List<Shelf> GetbyCustItem(int custid, int itemid)
        {
            return _shelfRepository.GetbyCustItem(custid, itemid);
        }

        public List<Shelf> GetbyCustomer(int custid)
        {
            return _shelfRepository.GetbyCustomer(custid);
        }

        public Shelf GetById(int shelfid)
        {
            return _shelfRepository.GetById(shelfid);
        }

        public void InsertShelf(Shelf shelf)
        {
            _shelfRepository.InsertShelf(shelf);
            return;
        }

        public void UpdateAvailQty(int shelfid, int quantity)
        {
            _shelfRepository.UpdateAvailQty(shelfid, quantity);
            return;
        }

        public void UpdateMarketPrice(int shelfid, double price)
        {
            _shelfRepository.UpdateMarketPrice(shelfid, price);
            return;
        }

        public void UpdateQty(int shelfid, int quantity)
        {
            _shelfRepository.UpdateQty(shelfid, quantity);
            return;
        }
    }
}
