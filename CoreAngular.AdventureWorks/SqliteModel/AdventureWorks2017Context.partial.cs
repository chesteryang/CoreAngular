using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class Adventureworks2017Context
    {
        static IConfiguration Configuration { get; set; }
        private string GetConnection()
        {
            if (Configuration == null)
            {
                var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json");
                Configuration = builder.Build();
            }
            return Configuration["ConnectionStrings:AdventureWorksSqliteDatabase"];
        }
    }
}
