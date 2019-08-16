using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Interfaces
{
    public interface IExchangeBusiness
    {
        void NewExchange(Wish wish, int boxid);

        List<Exchange> GetbyWish(int wishid);

        void GrantExchange(int exchangeid, int bagid);

        void ReturnExchange(int exchangeid, int boxid);

        void AccomplishExchange(int exchangeid);
    }
}
