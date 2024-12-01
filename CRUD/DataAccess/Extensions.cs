using Microsoft.EntityFrameworkCore;

namespace CRUD.DataAccess
{
    public static class Extensions
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection servicesCollection)
        {
            servicesCollection.AddScoped<INoteRepository, NoteRepository>();

            servicesCollection.AddDbContext<AppContext>(options =>
            {
                options.UseNpgsql("Host=localhost;Database=NoteDb;Username=postgres;Password=100809ash");
            });
            return servicesCollection;
        }
    }
}
