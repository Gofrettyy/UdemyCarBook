using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace UdemyCarBook.Application.Services;

public static class ServiceRegistiration
{
    public static void AddApplicationService(this IServiceCollection services,
        IConfiguration configuration) // birden fazla program csde tanımlamak yerine burda bir kere tanımlıyoruz 
    {
        services.AddMediatR(cfg 
            => cfg.RegisterServicesFromAssembly(typeof(ServiceRegistiration).Assembly)); 
        //Amaç: Tüm Command, Query ve onların Handler sınıflarını otomatik olarak bulmak ve bağlamak.
    }
}