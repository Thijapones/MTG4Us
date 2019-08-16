using Business.Interfaces;
using Domain;
using Services.Interfaces;
using System.Collections.Generic;

namespace Services
{
    public class ExchangeServices : IExchangeServices
    {
        private readonly IExchangeBusiness _exchangeBusiness;
        public ExchangeServices(IExchangeBusiness exchangeBusiness)
        {
            _exchangeBusiness = exchangeBusiness;
        }

        public void AccomplishExchange(int exchangeid)
        {
            _exchangeBusiness.AccomplishExchange(exchangeid);
            return;
        }

        public List<Exchange> GetbyWish(int wishid)
        {
            return _exchangeBusiness.GetbyWish(wishid);
        }

        public void GrantExchange(int exchangeid, int bagid)
        {
            _exchangeBusiness.GrantExchange(exchangeid, bagid);
            return;
        }

        public void NewExchange(Wish wish, int boxid)
        {
            _exchangeBusiness.NewExchange(wish, boxid);
            return;
        }

        public void ReturnExchange(int exchangeid, int boxid)
        {
            _exchangeBusiness.ReturnExchange(exchangeid, boxid);
            return;
        }

    }
}
