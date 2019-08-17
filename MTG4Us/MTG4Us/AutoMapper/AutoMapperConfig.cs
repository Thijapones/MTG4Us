using Application.AutoMapper.Profiles;
using AutoMapper;
using System.Diagnostics.CodeAnalysis;

namespace Application.AutoMapper
{
    [ExcludeFromCodeCoverage]
    public class AutoMapperConfig
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(ps =>
            {
                ps.AddProfile(new DomainToViewModel());
                ps.AddProfile(new ViewModelToDomain());
            });
        }
    }
}
