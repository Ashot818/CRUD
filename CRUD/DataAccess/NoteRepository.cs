
using Microsoft.EntityFrameworkCore;

namespace CRUD.DataAccess
{
    internal class NoteRepository(AppContext context) : INoteRepository
    {
        //create
        public async Task CreateAsync(Note note, CancellationToken cancellationToken = default)
        {
            note.Created = DateTime.UtcNow;
            await context.Notes.AddAsync(note , cancellationToken);
            await context.SaveChangesAsync(cancellationToken);
        }

        //get
        public async Task<Note?> GetByIdAsync(int id, CancellationToken cancellationToken = default)
        {
           return await context.Notes.FirstOrDefaultAsync(x => x.Id == id);
        }
        
        //update
        public async Task UpdateAsync(Note note, CancellationToken cancellationToken = default)
        {
            note.Updated = DateTime.UtcNow;
            context.Notes.Update(note);

            await context.SaveChangesAsync(cancellationToken);
        }
        //delete

        public async Task DeleteAsync(Note note, CancellationToken cancellationToken = default)
        {
            context.Notes.Remove(note);
            await context.SaveChangesAsync(cancellationToken) ;
        }

       
    }
}
