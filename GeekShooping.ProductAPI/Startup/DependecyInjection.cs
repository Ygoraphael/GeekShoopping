using GeekShooping.ProductAPI.DataContext;
using GeekShopping.ProductAPI.Config;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using GeekShopping.ProductAPI.Repository;

namespace GeekShooping.ProductAPI.Startup
{
    public static class DependecyInjection
    {
        public static IServiceCollection RegisterServices(this IServiceCollection Services, IConfiguration configuration)
        {
            Services.AddControllers();
            Services.AddEndpointsApiExplorer();
            Services.AddSwaggerGen();
            Services.AddScoped<IProductRepository, ProductRepository>();
            IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
            Services.AddSingleton(mapper);
            Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            var connection = configuration["MySQlConnection:MySQlConnectionString"];
            Services.AddDbContext<AppDbContext>(options => options.
                UseMySql(connection,
                        new MySqlServerVersion(
                            new Version(8, 0, 5))));
            return Services;
        }
    }
}
 