﻿namespace NakNakApiProp.Helpers
{
    using Microsoft.EntityFrameworkCore;
    using NakNakApiProp.Entities;

    public class DataContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }

        private readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseNpgsql(Configuration.GetConnectionString("PostgresqlConnection"));
        }
    }
}
