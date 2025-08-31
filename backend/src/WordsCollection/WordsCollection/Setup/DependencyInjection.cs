using WordsCollection.Repository.User;
using WordsCollection.Services.User;

namespace WordsCollection.Setup;

public static class DependencyInjection
{
    public static void RegisterService(this IServiceCollection services)
    {
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IUserService, UserService>();
    }
}