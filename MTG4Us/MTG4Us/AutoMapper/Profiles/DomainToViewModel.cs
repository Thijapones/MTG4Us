using Application.ViewModels;
using AutoMapper;
using Domain;

namespace Application.AutoMapper.Profiles
{
    public class DomainToViewModel : Profile
    {
        public DomainToViewModel()
        {
            CreateMap<Customer, CustomerViewModel>();
            CreateMap<Spot, SpotViewModel>();
        }
    }
}