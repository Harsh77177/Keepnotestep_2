using Microsoft.EntityFrameworkCore;
using KeepNote_Step2.Models;
namespace KeepNote_Step2.Context
{
    public class NoteDBContext : DbContext
    {
        public NoteDBContext(DbContextOptions<NoteDBContext> context)
            : base(context)
        {

        }
        public DbSet<Note> Notes { get; set; }
    }
}
