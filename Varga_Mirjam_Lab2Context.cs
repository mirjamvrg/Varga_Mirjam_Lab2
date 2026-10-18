using Microsoft.EntityFrameworkCore;

public class Varga_Mirjam_Lab2Context(DbContextOptions<Varga_Mirjam_Lab2Context> options) : DbContext(options)
{
    public DbSet<Varga_Mirjam_Lab2.Models.Book> Book { get; set; } = default!;
}
