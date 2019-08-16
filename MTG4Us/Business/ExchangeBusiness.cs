using Business.Interfaces;
using Domain;
using Repository.Interfaces;
using System.Collections.Generic;

namespace Business
{
    public class ExchangeBusiness : IExchangeBusiness
    {
        private readonly IExchangeRepository _exchangeRepository;

        public ExchangeBusiness(IExchangeRepository exchangeRepository)
        {
            _exchangeRepository = exchangeRepository;
        }

        public void AccomplishExchange(int exchangeid)
        {
            _exchangeRepository.AccomplishExchange(exchangeid);
            return;
        }

        public List<Exchange> GetbyWish(int wishid)
        {
            return _exchangeRepository.GetbyWish(wishid);
        }

        public void GrantExchange(int exchangeid, int bagid)
        {
            _exchangeRepository.GrantExchange(exchangeid, bagid);
            return;
        }

        public void NewExchange(Wish wish, int boxid)
        {
            _exchangeRepository.NewExchange(wish, boxid);
            return;
        }

        public void ReturnExchange(int exchangeid, int boxid)
        {
            _exchangeRepository.ReturnExchange(exchangeid, boxid);
            return;
        }
    }
}
