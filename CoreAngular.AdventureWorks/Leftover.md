```C#
    public partial class AdventureWorks2017Context
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
            var dbInstance = Environment.GetEnvironmentVariable("DbInstance");
            return string.Format(Configuration["ConnectionStrings:AdventureWorksDatabase"], dbInstance);
        }
    }
```