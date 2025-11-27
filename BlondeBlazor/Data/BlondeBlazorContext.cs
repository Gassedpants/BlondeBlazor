using BlondeBlazor.Configurations.Entities;
using BlondeBlazor.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlondeBlazor.Data
{
    public class BlondeBlazorContext(DbContextOptions<BlondeBlazorContext> options) : IdentityDbContext<BlondeBlazorUser>(options)
    {
        public DbSet<BlondeBlazor.Domain.Make> Make { get; set; } = default!;
        public DbSet<BlondeBlazor.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<BlondeBlazor.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<BlondeBlazor.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<BlondeBlazor.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<BlondeBlazor.Domain.Model> Model { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ColourSeed());
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());

        }
    }
}
