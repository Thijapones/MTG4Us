using Domain;
using Repository.Interfaces.Base;
using System.Collections.Generic;

namespace Repository.Interfaces
{
    public interface IExchangeRepository : IRepository<Exchange>
    {
        void NewExchange(Wish wish, int boxid);

        List<Exchange> GetbyWish(int wishid);

        void GrantExchange(int exchangeid, int bagid);

        void ReturnExchange(int exchangeid, int boxid);

        void AccomplishExchange(int exchangeid);
    }
}
