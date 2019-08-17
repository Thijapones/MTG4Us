using Application.AutoMapper;
using Business;
using Business.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Interfaces;
using Services;
using Services.Interfaces;

namespace Application.Extensions
{
    public static class DependencyInjection
    {
        public static void DepencencyInjection(this IServiceCollection services)
        {

            var mapperConfig = AutoMapperConfig.RegisterMappings();
            services.AddSingleton(mapperConfig.CreateMapper());

            DependencyInjectionBusiness(services);
            DependencyInjectionServices(services);
            DependencyInjectionRepository(services);

            services.BuildServiceProvider();
        }

        /// <summary>
        /// Services Dependency Injections
        /// </summary>
        /// <param name="services"></param>
        public static void DependencyInjectionServices(IServiceCollection services)
        {
            services.AddTransient<IBagServices, BagServices>();
            services.AddTransient<IBoxServices, BoxServices>();
            services.AddTransient<IBoxContentServices, BoxContentServices>();
            services.AddTransient<ICustomerServices, CustomerServices>();            
            services.AddTransient<IExchangeServices, ExchangeServices>();            
            services.AddTransient<IMTGCardServices, MTGCardServices>();
            services.AddTransient<IScoreServices, ScoreServices>();
            services.AddTransient<IShelfServices, ShelfServices>();
            services.AddTransient<ISpotServices, SpotServices>();
            services.AddTransient<IWishServices, WishServices>();
            services.AddTransient<IWishTargetServices, WishTargetServices>();
        }

        /// <summary>
        /// Business Dependency Injections
        /// </summary>
        /// <param name="services"></param>
        public static void DependencyInjectionRepository(IServiceCollection services)
        {
            services.AddSingleton<IBagBusiness, BagBusiness>();
            services.AddSingleton<IBoxBusiness, BoxBusiness>();
            services.AddSingleton<IBoxContentBusiness, BoxContentBusiness>();
            services.AddTransient<ICustomerBusiness, CustomerBusiness>();
            services.AddTransient<IExchangeBusiness, ExchangeBusiness>();
            services.AddTransient<IMTGCardBusiness, MTGCardBusiness>();
            services.AddTransient<IScoreBusiness, ScoreBusiness>();
            services.AddTransient<IShelfBusiness, ShelfBusiness>();
            services.AddTransient<ISpotBusiness, SpotBusiness>();
            services.AddTransient<IWishBusiness, WishBusiness>();
            services.AddTransient<IWishTargetBusiness, WishTargetBusiness>();
        }

        /// <summary>
        /// Repository Dependency Injections
        /// </summary>
        /// <param name="services"></param>
        public static void DependencyInjectionBusiness(IServiceCollection services)
        {
            services.AddTransient<IBagRepository, BagRepository>();
            services.AddSingleton<IBoxRepository, BoxRepository>();
            services.AddSingleton<IBoxContentRepository, BoxContentRepository>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IExchangeRepository, ExchangeRepository>();
            services.AddTransient<IMTGCardRepository, MTGCardRepository>();
            services.AddTransient<IScoreRepository, ScoreRepository>();
            services.AddTransient<IShelfRepository, ShelfRepository>();
            services.AddTransient<ISpotRepository, SpotRepository>();
            services.AddTransient<IWishRepository, WishRepository>();
            services.AddTransient<IWishTargetRepository, WishTargetRepository>();
        }
    }
}