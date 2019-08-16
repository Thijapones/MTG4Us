using Dapper;
using Domain;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Repository.Interfaces;
using System.Collections.Generic;

namespace Repository
{
    public class ShelfRepository : Repository<Shelf>, IShelfRepository
    {
        public ShelfRepository(IConfiguration config, ILogger<Repository<Shelf>> logger) : base(config, logger)
        {
        }

        //A shelf will never be removed. An item quantity as well as its available quantity should be set to 0 
        //instead.

        //List all shelves available per customer
        public List<Shelf> GetbyCustomer(int custid)
        {
            var query = $"select itemid,itemdescription,conservation,quantity,availableqty,marketprice" +
                        $"from customers.vwshelf where custid=@custid";
            var parameters = new DynamicParameters();
            parameters.Add("@custid", custid);
            return ExecuteQuery(query, parameters);
        }

        //List shelves that cointais an item for this owner
        public List<Shelf> GetbyCustItem(int custid, int itemid)
        {
            var query = $"select itemid,itemdescription,conservation,quantity,availableqty,marketprice" +
            $"from customers.vwshelf where custid=@custid and itemid=@itemid";
            var parameters = new DynamicParameters();
            parameters.Add("@custid", custid);
            parameters.Add("@itemid", itemid);
            return ExecuteQuery(query, parameters);
        }

        public void UpdateQty(int shelfid, int quantity)
        {
            var query =
                $"update customers.shelf" +
                $"set quantity=@quantity where id=@id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", shelfid);
            parameters.Add("@quantity", quantity);


            ExecuteQuery(query, parameters);

            return;
        }
        public void UpdateAvailQty(int shelfid, int quantity)
        {
            var query =
                $"update customers.shelf" +
                $"set availablequantity=@availablequantity where id=@id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", shelfid);
            parameters.Add("@availablequantity", quantity);
            
            ExecuteQuery(query, parameters);

            return;
        }

        public void UpdateMarketPrice(int shelfid, double price)
        {
            var query =
                $"update customers.shelf" +
                $"set marketprice=@marketprice where id=@id";
            var parameters = new DynamicParameters();
            parameters.Add("@id", shelfid);
            parameters.Add("@marketprice", price);

            ExecuteQuery(query, parameters);

            return;
        }
    }
}
