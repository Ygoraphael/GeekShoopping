using GeekShopping.Web.Services;

namespace GeekShopping.Web.Startup
{
    public static class DependecyInjection
    {
        public static IServiceCollection RegisterServices(this IServiceCollection Services, IConfiguration configuration)
        {
            Services.AddRazorPages();
            Services.AddControllersWithViews();
            Services.AddHttpClient<IProductServices, ProductServices>(c => c.BaseAddress = new Uri(configuration["ServicesUrls:ProductAPI"]));
            return Services;
        }
    }
}
 