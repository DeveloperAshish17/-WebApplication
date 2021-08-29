using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models_.WebApplication.Models;

namespace WebApplication.Context
{
    public class CompanyContext
                : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            try
            {
                var builder = new ConfigurationBuilder();
                builder.SetBasePath(Directory.GetCurrentDirectory());
                builder.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

                var config = builder.Build();

                string connectionString = config["ConnectionStrings:DefaultConnection"];

                optionsBuilder.UseSqlServer(connectionString,
                sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure(3);
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DbSet<Employee> Employees { get; set; }

    }

}
