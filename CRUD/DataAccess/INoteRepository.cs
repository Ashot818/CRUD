namespace CRUD.DataAccess
{
    public interface INoteRepository
    {
        //create
        Task CreateAsync(Note note, CancellationToken cancellationToken = default);
        //get
        Task<Note?> GetByIdAsync(int id, CancellationToken cancellationToken = default); 
        //update
        Task UpdateAsync(Note note, CancellationToken cancellationToken = default);
        //delete
        Task DeleteAsync(Note note, CancellationToken cancellationToken = default);
    }
}
