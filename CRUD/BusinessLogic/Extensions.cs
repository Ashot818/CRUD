namespace CRUD.BusinessLogic
{
    public static class Extensions
    {
        public static IServiceCollection AddBusinesLogic(this IServiceCollection servicesCollection)
        {
            servicesCollection.AddScoped<INoteService, NoteService>();

            return servicesCollection;
        }
    }
}
