using GuitarJournal.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace GuitarJournal.Infrastructure.Persistence
{
    public class GuitarJournalDbContext : DbContext
    {
        public GuitarJournalDbContext(DbContextOptions<GuitarJournalDbContext> options) : base(options)
        {

        }

        public DbSet<PracticeSession> PracticeSessions { get; set; }
    }
}
