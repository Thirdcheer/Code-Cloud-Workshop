using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Warsztaty.Core
{
    public class DataContext: DbContext
    {
        public virtual DbSet<ContactModel> Contact { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:warsztatykarolinadb.database.windows.net,1433;Initial Catalog=warsztatykarolinadb;Persist Security Info=False;User ID=dev7;Password=Passw0rd!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
