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
            CreateMap<MTGCard, MTGCardViewModel>();
            CreateMap<Shelf, ShelfViewModel>();
            CreateMap<Score, ScoreViewModel>();
            CreateMap<Box, BoxViewModel>();
            CreateMap<Wish, WishViewModel>();
        }
    }
}