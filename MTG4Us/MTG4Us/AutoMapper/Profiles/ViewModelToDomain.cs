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
            CreateMap<BoxContentViewModel, BoxContent>();
            CreateMap<WishViewModel, Wish>();
            CreateMap<WishTargetViewModel, WishTarget>();
            CreateMap<ExchangeViewModel, Exchange>();
            CreateMap<BagViewModel, Bag>();
        }
    }
}