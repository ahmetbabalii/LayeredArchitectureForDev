using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public sealed class MsDbContext : ProjectDbContext
    {
        public MsDbContext(DbContextOptions<MsDbContext> options, IConfiguration configuration) : base(options, configuration)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=AHMETBAB\SQLEXPRESS;Initial Catalog=NorthwindNetCore;Integrated Security=True");

            //if (!optionsBuilder.IsConfigured)
            //{
            //    base.OnConfiguring(optionsBuilder.UseSqlServer(configuration.GetConnectionString("DArchMsContext")));
            //}
        }
    }
}
