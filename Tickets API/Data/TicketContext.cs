using Microsoft.EntityFrameworkCore;
using Tickets_API.Models;

namespace Tickets_API.Data;

public class TicketContext : DbContext
{
    public TicketContext(DbContextOptions<TicketContext> options) : base(options)
    {
    }

    public DbSet<Ticket> Segments { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ticket>()
            .HasIndex(p => new { p.ticket_number, p.serial_number })
            .IsUnique();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Server=localhost; Port=5432;Database=Tickets;User Id=postgres;Password=root");
}