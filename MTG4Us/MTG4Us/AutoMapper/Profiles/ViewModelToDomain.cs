using Application.ViewModels;
using AutoMapper;
using Domain;

namespace Application.AutoMapper.Profiles
{
    public class ViewModelToDomain : Profile
    {
        public ViewModelToDomain()
        {
            CreateMap<CustomerViewModel, Customer>();
            CreateMap<SpotViewModel, Spot>();
            CreateMap<MTGCardViewModel, MTGCard>();
            CreateMap<ShelfViewModel, Shelf>();
            CreateMap<ScoreViewModel, Score>();
            CreateMap<BoxViewModel, Box>();
            CreateMap<WishViewModel, Wish>();
        }
    }
}