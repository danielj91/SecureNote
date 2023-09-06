using Microsoft.EntityFrameworkCore;
using SecureNote.Models;

namespace SecureNote.Data;

public class SecureNoteContext : DbContext
{
    public SecureNoteContext(DbContextOptions<SecureNoteContext> options) : base(options)
    {
    }

    public DbSet<Note> Notes { get; set; }
}