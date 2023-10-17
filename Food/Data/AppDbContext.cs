using Food.Dto_s;
using Food.Models;
using Microsoft.EntityFrameworkCore;

namespace Food.Data;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<User> Users { get; set; }
    public DbSet<Foods>  Foods { get; set; }
    public DbSet<Functions> Functions  { get; set; }
    public DbSet<Informations> Informations { get; set; }
    public DbSet<Menu> Menus  { get; set; }
    public DbSet<OrderHistory >OrderHistorie  { get; set; }
    public DbSet<Orders> Orders  { get; set; }
    public DbSet<Payment> payments  { get; set; }
    public DbSet<Profile> profiles  { get; set; }
    public DbSet<Registration> registrations  { get; set; }
    public DbSet<Lenguage> lenguages  { get; set; }


}
