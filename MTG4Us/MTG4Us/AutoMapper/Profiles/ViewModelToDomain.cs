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
        }
    }
}