using Domain;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IExchangeServices
    {
        void NewExchange(Wish wish, int boxid);

        List<Exchange> GetbyWish(int wishid);

        void GrantExchange(int exchangeid, int bagid);

        void ReturnExchange(int exchangeid, int boxid);

        void AccomplishExchange(int exchangeid);
    }
}
