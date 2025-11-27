using BlondeBlazor.Configurations.Entities;
using BlondeBlazor.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlondeBlazor.Data
{
    public class BlondeBlazorContext : DbContext
    {
        public BlondeBlazorContext (DbContextOptions<BlondeBlazorContext> options)
            : base(options)
        {
        }

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
