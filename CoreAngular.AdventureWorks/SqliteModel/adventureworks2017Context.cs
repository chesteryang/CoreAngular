using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class Adventureworks2017Context : DbContext
    {
        public static readonly LoggerFactory MyLoggerFactory
            = new LoggerFactory(new[] { new ConsoleLoggerProvider((category, level)
                => category == DbLoggerCategory.Database.Command.Name
                   && level == LogLevel.Information, true) });

        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressType> AddressType { get; set; }
        public virtual DbSet<AwbuildVersion> AwbuildVersion { get; set; }
        public virtual DbSet<BillOfMaterials> BillOfMaterials { get; set; }
        public virtual DbSet<BusinessEntity> BusinessEntity { get; set; }
        public virtual DbSet<BusinessEntityAddress> BusinessEntityAddress { get; set; }
        public virtual DbSet<BusinessEntityContact> BusinessEntityContact { get; set; }
        public virtual DbSet<ContactType> ContactType { get; set; }
        public virtual DbSet<CountryRegion> CountryRegion { get; set; }
        public virtual DbSet<CountryRegionCurrency> CountryRegionCurrency { get; set; }
        public virtual DbSet<CreditCard> CreditCard { get; set; }
        public virtual DbSet<Culture> Culture { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<CurrencyRate> CurrencyRate { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<DatabaseLog> DatabaseLog { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<EmailAddress> EmailAddress { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
        public virtual DbSet<EmployeePayHistory> EmployeePayHistory { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }
        public virtual DbSet<Illustration> Illustration { get; set; }
        public virtual DbSet<JobCandidate> JobCandidate { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Password> Password { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PersonCreditCard> PersonCreditCard { get; set; }
        public virtual DbSet<PersonPhone> PersonPhone { get; set; }
        public virtual DbSet<PhoneNumberType> PhoneNumberType { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<ProductCostHistory> ProductCostHistory { get; set; }
        public virtual DbSet<ProductDescription> ProductDescription { get; set; }
        public virtual DbSet<ProductDocument> ProductDocument { get; set; }
        public virtual DbSet<ProductInventory> ProductInventory { get; set; }
        public virtual DbSet<ProductListPriceHistory> ProductListPriceHistory { get; set; }
        public virtual DbSet<ProductModel> ProductModel { get; set; }
        public virtual DbSet<ProductModelIllustration> ProductModelIllustration { get; set; }
        public virtual DbSet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; set; }
        public virtual DbSet<ProductPhoto> ProductPhoto { get; set; }
        public virtual DbSet<ProductProductPhoto> ProductProductPhoto { get; set; }
        public virtual DbSet<ProductReview> ProductReview { get; set; }
        public virtual DbSet<ProductSubcategory> ProductSubcategory { get; set; }
        public virtual DbSet<ProductVendor> ProductVendor { get; set; }
        public virtual DbSet<PurchaseOrderDetail> PurchaseOrderDetail { get; set; }
        public virtual DbSet<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }
        public virtual DbSet<SalesOrderDetail> SalesOrderDetail { get; set; }
        public virtual DbSet<SalesOrderHeader> SalesOrderHeader { get; set; }
        public virtual DbSet<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReason { get; set; }
        public virtual DbSet<SalesPerson> SalesPerson { get; set; }
        public virtual DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistory { get; set; }
        public virtual DbSet<SalesReason> SalesReason { get; set; }
        public virtual DbSet<SalesTaxRate> SalesTaxRate { get; set; }
        public virtual DbSet<SalesTerritory> SalesTerritory { get; set; }
        public virtual DbSet<SalesTerritoryHistory> SalesTerritoryHistory { get; set; }
        public virtual DbSet<ScrapReason> ScrapReason { get; set; }
        public virtual DbSet<Shift> Shift { get; set; }
        public virtual DbSet<ShipMethod> ShipMethod { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItem { get; set; }
        public virtual DbSet<SpecialOffer> SpecialOffer { get; set; }
        public virtual DbSet<SpecialOfferProduct> SpecialOfferProduct { get; set; }
        public virtual DbSet<StateProvince> StateProvince { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<TransactionHistory> TransactionHistory { get; set; }
        public virtual DbSet<TransactionHistoryArchive> TransactionHistoryArchive { get; set; }
        public virtual DbSet<UnitMeasure> UnitMeasure { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<WorkOrder> WorkOrder { get; set; }
        public virtual DbSet<WorkOrderRouting> WorkOrderRouting { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(GetConnection()).UseLoggerFactory(MyLoggerFactory);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_Address_rowguid")
                    .IsUnique();

                entity.HasIndex(e => e.StateProvinceId);

                entity.HasIndex(e => new { e.AddressLine1, e.AddressLine2, e.City, e.StateProvinceId, e.PostalCode })
                    .IsUnique();

                entity.Property(e => e.AddressId)
                    .HasColumnName("AddressID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressLine1)
                    .IsRequired()
                    .HasColumnType("nvarchar(60)");

                entity.Property(e => e.AddressLine2).HasColumnType("nvarchar(60)");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnType("nvarchar(30)");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasColumnType("nvarchar(15)");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.Property(e => e.SpatialLocation).HasColumnType("nvarchar(4000)");

                entity.Property(e => e.StateProvinceId)
                    .HasColumnName("StateProvinceID")
                    .HasColumnType("int");

                entity.HasOne(d => d.StateProvince)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.StateProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_AddressType_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_AddressType_rowguid")
                    .IsUnique();

                entity.Property(e => e.AddressTypeId)
                    .HasColumnName("AddressTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");
            });

            modelBuilder.Entity<AwbuildVersion>(entity =>
            {
                entity.HasKey(e => e.SystemInformationId);

                entity.ToTable("AWBuildVersion");

                entity.Property(e => e.SystemInformationId)
                    .HasColumnName("SystemInformationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DatabaseVersion)
                    .IsRequired()
                    .HasColumnName("Database Version")
                    .HasColumnType("nvarchar(25)");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.VersionDate)
                    .IsRequired()
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<BillOfMaterials>(entity =>
            {
                entity.HasIndex(e => e.UnitMeasureCode);

                entity.HasIndex(e => new { e.ProductAssemblyId, e.ComponentId, e.StartDate })
                    .HasName("AK_BillOfMaterials_ProductAssemblyID_ComponentID_StartDate")
                    .IsUnique();

                entity.Property(e => e.BillOfMaterialsId)
                    .HasColumnName("BillOfMaterialsID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bomlevel)
                    .HasColumnName("BOMLevel")
                    .HasColumnType("smallint");

                entity.Property(e => e.ComponentId)
                    .HasColumnName("ComponentID")
                    .HasColumnType("int");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.PerAssemblyQty)
                    .IsRequired()
                    .HasColumnType("numeric(8,2)")
                    .HasDefaultValueSql("1.00");

                entity.Property(e => e.ProductAssemblyId)
                    .HasColumnName("ProductAssemblyID")
                    .HasColumnType("int");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.UnitMeasureCode)
                    .IsRequired()
                    .HasColumnType("nchar(3)");

                entity.HasOne(d => d.Component)
                    .WithMany(p => p.BillOfMaterialsComponent)
                    .HasForeignKey(d => d.ComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ProductAssembly)
                    .WithMany(p => p.BillOfMaterialsProductAssembly)
                    .HasForeignKey(d => d.ProductAssemblyId);

                entity.HasOne(d => d.UnitMeasureCodeNavigation)
                    .WithMany(p => p.BillOfMaterials)
                    .HasForeignKey(d => d.UnitMeasureCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<BusinessEntity>(entity =>
            {
                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_BusinessEntity_rowguid")
                    .IsUnique();

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");
            });

            modelBuilder.Entity<BusinessEntityAddress>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.AddressId, e.AddressTypeId });

                entity.HasIndex(e => e.AddressId);

                entity.HasIndex(e => e.AddressTypeId);

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_BusinessEntityAddress_rowguid")
                    .IsUnique();

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int");

                entity.Property(e => e.AddressId)
                    .HasColumnName("AddressID")
                    .HasColumnType("int");

                entity.Property(e => e.AddressTypeId)
                    .HasColumnName("AddressTypeID")
                    .HasColumnType("int");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.BusinessEntityAddress)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.AddressType)
                    .WithMany(p => p.BusinessEntityAddress)
                    .HasForeignKey(d => d.AddressTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.BusinessEntityAddress)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<BusinessEntityContact>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.PersonId, e.ContactTypeId });

                entity.HasIndex(e => e.ContactTypeId);

                entity.HasIndex(e => e.PersonId);

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_BusinessEntityContact_rowguid")
                    .IsUnique();

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int");

                entity.Property(e => e.PersonId)
                    .HasColumnName("PersonID")
                    .HasColumnType("int");

                entity.Property(e => e.ContactTypeId)
                    .HasColumnName("ContactTypeID")
                    .HasColumnType("int");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.BusinessEntityContact)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ContactType)
                    .WithMany(p => p.BusinessEntityContact)
                    .HasForeignKey(d => d.ContactTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.BusinessEntityContact)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ContactType>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_ContactType_Name")
                    .IsUnique();

                entity.Property(e => e.ContactTypeId)
                    .HasColumnName("ContactTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");
            });

            modelBuilder.Entity<CountryRegion>(entity =>
            {
                entity.HasKey(e => e.CountryRegionCode);

                entity.HasIndex(e => e.Name)
                    .HasName("AK_CountryRegion_Name")
                    .IsUnique();

                entity.Property(e => e.CountryRegionCode)
                    .HasColumnType("nvarchar(3)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");
            });

            modelBuilder.Entity<CountryRegionCurrency>(entity =>
            {
                entity.HasKey(e => new { e.CountryRegionCode, e.CurrencyCode });

                entity.HasIndex(e => e.CurrencyCode);

                entity.Property(e => e.CountryRegionCode).HasColumnType("nvarchar(3)");

                entity.Property(e => e.CurrencyCode).HasColumnType("nchar(3)");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.HasOne(d => d.CountryRegionCodeNavigation)
                    .WithMany(p => p.CountryRegionCurrency)
                    .HasForeignKey(d => d.CountryRegionCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CurrencyCodeNavigation)
                    .WithMany(p => p.CountryRegionCurrency)
                    .HasForeignKey(d => d.CurrencyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<CreditCard>(entity =>
            {
                entity.HasIndex(e => e.CardNumber)
                    .HasName("AK_CreditCard_CardNumber")
                    .IsUnique();

                entity.Property(e => e.CreditCardId)
                    .HasColumnName("CreditCardID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CardNumber)
                    .IsRequired()
                    .HasColumnType("nvarchar(25)");

                entity.Property(e => e.CardType)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.ExpMonth).HasColumnType("tinyint");

                entity.Property(e => e.ExpYear).HasColumnType("smallint");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");
            });

            modelBuilder.Entity<Culture>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_Culture_Name")
                    .IsUnique();

                entity.Property(e => e.CultureId)
                    .HasColumnName("CultureID")
                    .HasColumnType("nchar(6)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasKey(e => e.CurrencyCode);

                entity.HasIndex(e => e.Name)
                    .HasName("AK_Currency_Name")
                    .IsUnique();

                entity.Property(e => e.CurrencyCode)
                    .HasColumnType("nchar(3)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");
            });

            modelBuilder.Entity<CurrencyRate>(entity =>
            {
                entity.HasIndex(e => new { e.CurrencyRateDate, e.FromCurrencyCode, e.ToCurrencyCode })
                    .HasName("AK_CurrencyRate_CurrencyRateDate_FromCurrencyCode_ToCurrencyCode")
                    .IsUnique();

                entity.Property(e => e.CurrencyRateId)
                    .HasColumnName("CurrencyRateID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AverageRate)
                    .IsRequired()
                    .HasColumnType("money");

                entity.Property(e => e.CurrencyRateDate)
                    .IsRequired()
                    .HasColumnType("datetime");

                entity.Property(e => e.EndOfDayRate)
                    .IsRequired()
                    .HasColumnType("money");

                entity.Property(e => e.FromCurrencyCode)
                    .IsRequired()
                    .HasColumnType("nchar(3)");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.ToCurrencyCode)
                    .IsRequired()
                    .HasColumnType("nchar(3)");

                entity.HasOne(d => d.FromCurrencyCodeNavigation)
                    .WithMany(p => p.CurrencyRateFromCurrencyCodeNavigation)
                    .HasForeignKey(d => d.FromCurrencyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ToCurrencyCodeNavigation)
                    .WithMany(p => p.CurrencyRateToCurrencyCodeNavigation)
                    .HasForeignKey(d => d.ToCurrencyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_Customer_rowguid")
                    .IsUnique();

                entity.HasIndex(e => e.TerritoryId);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.PersonId)
                    .HasColumnName("PersonID")
                    .HasColumnType("int");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.Property(e => e.StoreId)
                    .HasColumnName("StoreID")
                    .HasColumnType("int");

                entity.Property(e => e.TerritoryId)
                    .HasColumnName("TerritoryID")
                    .HasColumnType("int");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.PersonId);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.StoreId);

                entity.HasOne(d => d.Territory)
                    .WithMany(p => p.Customer)
                    .HasForeignKey(d => d.TerritoryId);
            });

            modelBuilder.Entity<DatabaseLog>(entity =>
            {
                entity.Property(e => e.DatabaseLogId)
                    .HasColumnName("DatabaseLogID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DatabaseUser)
                    .IsRequired()
                    .HasColumnType("nvarchar(128)");

                entity.Property(e => e.Event)
                    .IsRequired()
                    .HasColumnType("nvarchar(128)");

                entity.Property(e => e.Object).HasColumnType("nvarchar(128)");

                entity.Property(e => e.PostTime)
                    .IsRequired()
                    .HasColumnType("datetime");

                entity.Property(e => e.Schema).HasColumnType("nvarchar(128)");

                entity.Property(e => e.Tsql)
                    .IsRequired()
                    .HasColumnName("TSQL")
                    .HasColumnType("ntext");

                entity.Property(e => e.XmlEvent)
                    .IsRequired()
                    .HasColumnType("ntext");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_Department_Name")
                    .IsUnique();

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");
            });

            modelBuilder.Entity<Document>(entity =>
            {
                entity.HasKey(e => e.DocumentNode);

                entity.HasIndex(e => e.DocumentNode)
                    .HasName("AK_Document_DocumentLevel_DocumentNode")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_Document_rowguid")
                    .IsUnique();

                entity.HasIndex(e => new { e.FileName, e.Revision });

                entity.Property(e => e.DocumentNode)
                    .HasColumnType("varbinary(892)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChangeNumber).HasColumnType("int");

                entity.Property(e => e.Document1)
                    .HasColumnName("Document")
                    .HasColumnType("image");

                entity.Property(e => e.DocumentSummary).HasColumnType("ntext");

                entity.Property(e => e.FileExtension)
                    .IsRequired()
                    .HasColumnType("nvarchar(8)");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnType("nvarchar(400)");

                entity.Property(e => e.FolderFlag)
                    .IsRequired()
                    .HasColumnType("bit")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Owner).HasColumnType("int");

                entity.Property(e => e.Revision)
                    .IsRequired()
                    .HasColumnType("nchar(5)");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.Property(e => e.Status).HasColumnType("tinyint");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.HasOne(d => d.OwnerNavigation)
                    .WithMany(p => p.Document)
                    .HasForeignKey(d => d.Owner)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EmailAddress>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.EmailAddressId });

                entity.HasIndex(e => e.EmailAddress1);

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int");

                entity.Property(e => e.EmailAddressId).HasColumnName("EmailAddressID");

                entity.Property(e => e.EmailAddress1)
                    .HasColumnName("EmailAddress")
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.EmailAddress)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.BusinessEntityId);

                entity.HasIndex(e => e.LoginId)
                    .HasName("AK_Employee_LoginID")
                    .IsUnique();

                entity.HasIndex(e => e.NationalIdnumber)
                    .HasName("AK_Employee_NationalIDNumber")
                    .IsUnique();

                entity.HasIndex(e => e.OrganizationNode)
                    .HasName("IX_Employee_OrganizationLevel_OrganizationNode");

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_Employee_rowguid")
                    .IsUnique();

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int")
                    .ValueGeneratedNever();

                entity.Property(e => e.BirthDate)
                    .IsRequired()
                    .HasColumnType("datetime");

                entity.Property(e => e.CurrentFlag)
                    .IsRequired()
                    .HasColumnType("bit")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnType("nchar(1)");

                entity.Property(e => e.HireDate)
                    .IsRequired()
                    .HasColumnType("datetime");

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.LoginId)
                    .IsRequired()
                    .HasColumnName("LoginID")
                    .HasColumnType("nvarchar(256)");

                entity.Property(e => e.MaritalStatus)
                    .IsRequired()
                    .HasColumnType("nchar(1)");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.NationalIdnumber)
                    .IsRequired()
                    .HasColumnName("NationalIDNumber")
                    .HasColumnType("nvarchar(15)");

                entity.Property(e => e.OrganizationNode).HasColumnType("varbinary(892)");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.Property(e => e.SalariedFlag)
                    .IsRequired()
                    .HasColumnType("bit")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SickLeaveHours).HasColumnType("smallint");

                entity.Property(e => e.VacationHours).HasColumnType("smallint");

                entity.HasOne(d => d.BusinessEntity)
                    .WithOne(p => p.Employee)
                    .HasForeignKey<Employee>(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EmployeeDepartmentHistory>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.StartDate, e.DepartmentId, e.ShiftId });

                entity.HasIndex(e => e.DepartmentId);

                entity.HasIndex(e => e.ShiftId);

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId)
                    .HasColumnName("DepartmentID")
                    .HasColumnType("int");

                entity.Property(e => e.ShiftId)
                    .HasColumnName("ShiftID")
                    .HasColumnType("int");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.EmployeeDepartmentHistory)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.EmployeeDepartmentHistory)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Shift)
                    .WithMany(p => p.EmployeeDepartmentHistory)
                    .HasForeignKey(d => d.ShiftId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<EmployeePayHistory>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.RateChangeDate });

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int");

                entity.Property(e => e.RateChangeDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.PayFrequency).HasColumnType("tinyint");

                entity.Property(e => e.Rate)
                    .IsRequired()
                    .HasColumnType("money");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.EmployeePayHistory)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.Property(e => e.ErrorLogId)
                    .HasColumnName("ErrorLogID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ErrorLine).HasColumnType("int");

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasColumnType("nvarchar(4000)");

                entity.Property(e => e.ErrorNumber).HasColumnType("int");

                entity.Property(e => e.ErrorProcedure).HasColumnType("nvarchar(126)");

                entity.Property(e => e.ErrorSeverity).HasColumnType("int");

                entity.Property(e => e.ErrorState).HasColumnType("int");

                entity.Property(e => e.ErrorTime)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnType("nvarchar(128)");
            });

            modelBuilder.Entity<Illustration>(entity =>
            {
                entity.Property(e => e.IllustrationId)
                    .HasColumnName("IllustrationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Diagram).HasColumnType("ntext");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");
            });

            modelBuilder.Entity<JobCandidate>(entity =>
            {
                entity.HasIndex(e => e.BusinessEntityId);

                entity.Property(e => e.JobCandidateId)
                    .HasColumnName("JobCandidateID")
                    .ValueGeneratedNever();

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Resume).HasColumnType("ntext");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.JobCandidate)
                    .HasForeignKey(d => d.BusinessEntityId);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_Location_Name")
                    .IsUnique();

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Availability)
                    .IsRequired()
                    .HasColumnType("numeric(8,2)")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.CostRate)
                    .IsRequired()
                    .HasColumnType("money")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");
            });

            modelBuilder.Entity<Password>(entity =>
            {
                entity.HasKey(e => e.BusinessEntityId);

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasColumnType("nvarchar(128)");

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasColumnType("nvarchar(10)");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.HasOne(d => d.BusinessEntity)
                    .WithOne(p => p.Password)
                    .HasForeignKey<Password>(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.BusinessEntityId);

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_Person_rowguid")
                    .IsUnique();

                entity.HasIndex(e => new { e.LastName, e.FirstName, e.MiddleName });

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalContactInfo).HasColumnType("ntext");

                entity.Property(e => e.Demographics).HasColumnType("ntext");

                entity.Property(e => e.EmailPromotion).HasColumnType("int");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.MiddleName).HasColumnType("nvarchar(50)");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.NameStyle)
                    .IsRequired()
                    .HasColumnType("bit")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PersonType)
                    .IsRequired()
                    .HasColumnType("nchar(2)");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.Property(e => e.Suffix).HasColumnType("nvarchar(10)");

                entity.Property(e => e.Title).HasColumnType("nvarchar(8)");

                entity.HasOne(d => d.BusinessEntity)
                    .WithOne(p => p.Person)
                    .HasForeignKey<Person>(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PersonCreditCard>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.CreditCardId });

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int");

                entity.Property(e => e.CreditCardId)
                    .HasColumnName("CreditCardID")
                    .HasColumnType("int");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.PersonCreditCard)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreditCard)
                    .WithMany(p => p.PersonCreditCard)
                    .HasForeignKey(d => d.CreditCardId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PersonPhone>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.PhoneNumber, e.PhoneNumberTypeId });

                entity.HasIndex(e => e.PhoneNumber);

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int");

                entity.Property(e => e.PhoneNumber).HasColumnType("nvarchar(25)");

                entity.Property(e => e.PhoneNumberTypeId)
                    .HasColumnName("PhoneNumberTypeID")
                    .HasColumnType("int");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.PersonPhone)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PhoneNumberType)
                    .WithMany(p => p.PersonPhone)
                    .HasForeignKey(d => d.PhoneNumberTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PhoneNumberType>(entity =>
            {
                entity.Property(e => e.PhoneNumberTypeId)
                    .HasColumnName("PhoneNumberTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_Product_Name")
                    .IsUnique();

                entity.HasIndex(e => e.ProductNumber)
                    .HasName("AK_Product_ProductNumber")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_Product_rowguid")
                    .IsUnique();

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Class).HasColumnType("nchar(2)");

                entity.Property(e => e.Color).HasColumnType("nvarchar(15)");

                entity.Property(e => e.DaysToManufacture).HasColumnType("int");

                entity.Property(e => e.DiscontinuedDate).HasColumnType("datetime");

                entity.Property(e => e.FinishedGoodsFlag)
                    .IsRequired()
                    .HasColumnType("bit")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ListPrice)
                    .IsRequired()
                    .HasColumnType("money");

                entity.Property(e => e.MakeFlag)
                    .IsRequired()
                    .HasColumnType("bit")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.ProductLine).HasColumnType("nchar(2)");

                entity.Property(e => e.ProductModelId)
                    .HasColumnName("ProductModelID")
                    .HasColumnType("int");

                entity.Property(e => e.ProductNumber)
                    .IsRequired()
                    .HasColumnType("nvarchar(25)");

                entity.Property(e => e.ProductSubcategoryId)
                    .HasColumnName("ProductSubcategoryID")
                    .HasColumnType("int");

                entity.Property(e => e.ReorderPoint).HasColumnType("smallint");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.Property(e => e.SafetyStockLevel).HasColumnType("smallint");

                entity.Property(e => e.SellEndDate).HasColumnType("datetime");

                entity.Property(e => e.SellStartDate)
                    .IsRequired()
                    .HasColumnType("datetime");

                entity.Property(e => e.Size).HasColumnType("nvarchar(5)");

                entity.Property(e => e.SizeUnitMeasureCode).HasColumnType("nchar(3)");

                entity.Property(e => e.StandardCost)
                    .IsRequired()
                    .HasColumnType("money");

                entity.Property(e => e.Style).HasColumnType("nchar(2)");

                entity.Property(e => e.Weight).HasColumnType("numeric(8,2)");

                entity.Property(e => e.WeightUnitMeasureCode).HasColumnType("nchar(3)");

                entity.HasOne(d => d.ProductModel)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ProductModelId);

                entity.HasOne(d => d.ProductSubcategory)
                    .WithMany(p => p.Product)
                    .HasForeignKey(d => d.ProductSubcategoryId);

                entity.HasOne(d => d.SizeUnitMeasureCodeNavigation)
                    .WithMany(p => p.ProductSizeUnitMeasureCodeNavigation)
                    .HasForeignKey(d => d.SizeUnitMeasureCode);

                entity.HasOne(d => d.WeightUnitMeasureCodeNavigation)
                    .WithMany(p => p.ProductWeightUnitMeasureCodeNavigation)
                    .HasForeignKey(d => d.WeightUnitMeasureCode);
            });

            modelBuilder.Entity<ProductCategory>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_ProductCategory_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_ProductCategory_rowguid")
                    .IsUnique();

                entity.Property(e => e.ProductCategoryId)
                    .HasColumnName("ProductCategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");
            });

            modelBuilder.Entity<ProductCostHistory>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.StartDate });

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasColumnType("int");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.StandardCost)
                    .IsRequired()
                    .HasColumnType("money");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductCostHistory)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductDescription>(entity =>
            {
                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_ProductDescription_rowguid")
                    .IsUnique();

                entity.Property(e => e.ProductDescriptionId)
                    .HasColumnName("ProductDescriptionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("nvarchar(400)");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");
            });

            modelBuilder.Entity<ProductDocument>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.DocumentNode });

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasColumnType("int");

                entity.Property(e => e.DocumentNode).HasColumnType("varbinary(892)");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.HasOne(d => d.DocumentNodeNavigation)
                    .WithMany(p => p.ProductDocument)
                    .HasForeignKey(d => d.DocumentNode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductDocument)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductInventory>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.LocationId });

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasColumnType("int");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasColumnType("int");

                entity.Property(e => e.Bin).HasColumnType("tinyint");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Quantity).HasColumnType("smallint");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.Property(e => e.Shelf)
                    .IsRequired()
                    .HasColumnType("nvarchar(10)");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.ProductInventory)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductInventory)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductListPriceHistory>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.StartDate });

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasColumnType("int");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ListPrice)
                    .IsRequired()
                    .HasColumnType("money");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductListPriceHistory)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductModel>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_ProductModel_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_ProductModel_rowguid")
                    .IsUnique();

                entity.Property(e => e.ProductModelId)
                    .HasColumnName("ProductModelID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CatalogDescription).HasColumnType("ntext");

                entity.Property(e => e.Instructions).HasColumnType("ntext");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");
            });

            modelBuilder.Entity<ProductModelIllustration>(entity =>
            {
                entity.HasKey(e => new { e.ProductModelId, e.IllustrationId });

                entity.Property(e => e.ProductModelId)
                    .HasColumnName("ProductModelID")
                    .HasColumnType("int");

                entity.Property(e => e.IllustrationId)
                    .HasColumnName("IllustrationID")
                    .HasColumnType("int");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.HasOne(d => d.Illustration)
                    .WithMany(p => p.ProductModelIllustration)
                    .HasForeignKey(d => d.IllustrationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ProductModel)
                    .WithMany(p => p.ProductModelIllustration)
                    .HasForeignKey(d => d.ProductModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductModelProductDescriptionCulture>(entity =>
            {
                entity.HasKey(e => new { e.ProductModelId, e.ProductDescriptionId, e.CultureId });

                entity.Property(e => e.ProductModelId)
                    .HasColumnName("ProductModelID")
                    .HasColumnType("int");

                entity.Property(e => e.ProductDescriptionId)
                    .HasColumnName("ProductDescriptionID")
                    .HasColumnType("int");

                entity.Property(e => e.CultureId)
                    .HasColumnName("CultureID")
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.HasOne(d => d.Culture)
                    .WithMany(p => p.ProductModelProductDescriptionCulture)
                    .HasForeignKey(d => d.CultureId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ProductDescription)
                    .WithMany(p => p.ProductModelProductDescriptionCulture)
                    .HasForeignKey(d => d.ProductDescriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ProductModel)
                    .WithMany(p => p.ProductModelProductDescriptionCulture)
                    .HasForeignKey(d => d.ProductModelId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductPhoto>(entity =>
            {
                entity.Property(e => e.ProductPhotoId)
                    .HasColumnName("ProductPhotoID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LargePhoto).HasColumnType("image");

                entity.Property(e => e.LargePhotoFileName).HasColumnType("nvarchar(50)");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.ThumbNailPhoto).HasColumnType("image");

                entity.Property(e => e.ThumbnailPhotoFileName).HasColumnType("nvarchar(50)");
            });

            modelBuilder.Entity<ProductProductPhoto>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ProductPhotoId });

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasColumnType("int");

                entity.Property(e => e.ProductPhotoId)
                    .HasColumnName("ProductPhotoID")
                    .HasColumnType("int");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Primary)
                    .IsRequired()
                    .HasColumnType("bit")
                    .HasDefaultValueSql("0");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductProductPhoto)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ProductPhoto)
                    .WithMany(p => p.ProductProductPhoto)
                    .HasForeignKey(d => d.ProductPhotoId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductReview>(entity =>
            {
                entity.HasIndex(e => new { e.ProductId, e.ReviewerName })
                    .HasName("IX_ProductReview_ProductID_Name");

                entity.Property(e => e.ProductReviewId)
                    .HasColumnName("ProductReviewID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comments).HasColumnType("nvarchar(3850)");

                entity.Property(e => e.EmailAddress)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasColumnType("int");

                entity.Property(e => e.Rating).HasColumnType("int");

                entity.Property(e => e.ReviewDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.ReviewerName)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductReview)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductSubcategory>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_ProductSubcategory_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_ProductSubcategory_rowguid")
                    .IsUnique();

                entity.Property(e => e.ProductSubcategoryId)
                    .HasColumnName("ProductSubcategoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.ProductCategoryId)
                    .HasColumnName("ProductCategoryID")
                    .HasColumnType("int");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.HasOne(d => d.ProductCategory)
                    .WithMany(p => p.ProductSubcategory)
                    .HasForeignKey(d => d.ProductCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ProductVendor>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.BusinessEntityId });

                entity.HasIndex(e => e.BusinessEntityId);

                entity.HasIndex(e => e.UnitMeasureCode);

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasColumnType("int");

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int");

                entity.Property(e => e.AverageLeadTime).HasColumnType("int");

                entity.Property(e => e.LastReceiptCost).HasColumnType("money");

                entity.Property(e => e.LastReceiptDate).HasColumnType("datetime");

                entity.Property(e => e.MaxOrderQty).HasColumnType("int");

                entity.Property(e => e.MinOrderQty).HasColumnType("int");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.OnOrderQty).HasColumnType("int");

                entity.Property(e => e.StandardPrice)
                    .IsRequired()
                    .HasColumnType("money");

                entity.Property(e => e.UnitMeasureCode)
                    .IsRequired()
                    .HasColumnType("nchar(3)");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.ProductVendor)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductVendor)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.UnitMeasureCodeNavigation)
                    .WithMany(p => p.ProductVendor)
                    .HasForeignKey(d => d.UnitMeasureCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PurchaseOrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.PurchaseOrderId, e.PurchaseOrderDetailId });

                entity.HasIndex(e => e.ProductId);

                entity.Property(e => e.PurchaseOrderId)
                    .HasColumnName("PurchaseOrderID")
                    .HasColumnType("int");

                entity.Property(e => e.PurchaseOrderDetailId).HasColumnName("PurchaseOrderDetailID");

                entity.Property(e => e.DueDate)
                    .IsRequired()
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.OrderQty).HasColumnType("smallint");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasColumnType("int");

                entity.Property(e => e.ReceivedQty)
                    .IsRequired()
                    .HasColumnType("numeric(8,2)");

                entity.Property(e => e.RejectedQty)
                    .IsRequired()
                    .HasColumnType("numeric(8,2)");

                entity.Property(e => e.UnitPrice)
                    .IsRequired()
                    .HasColumnType("money");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PurchaseOrderDetail)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PurchaseOrder)
                    .WithMany(p => p.PurchaseOrderDetail)
                    .HasForeignKey(d => d.PurchaseOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PurchaseOrderHeader>(entity =>
            {
                entity.HasKey(e => e.PurchaseOrderId);

                entity.HasIndex(e => e.EmployeeId);

                entity.HasIndex(e => e.VendorId);

                entity.Property(e => e.PurchaseOrderId)
                    .HasColumnName("PurchaseOrderID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("EmployeeID")
                    .HasColumnType("int");

                entity.Property(e => e.Freight)
                    .IsRequired()
                    .HasColumnType("money")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.OrderDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.RevisionNumber).HasColumnType("tinyint");

                entity.Property(e => e.ShipDate).HasColumnType("datetime");

                entity.Property(e => e.ShipMethodId)
                    .HasColumnName("ShipMethodID")
                    .HasColumnType("int");

                entity.Property(e => e.Status)
                    .HasColumnType("tinyint")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SubTotal)
                    .IsRequired()
                    .HasColumnType("money")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TaxAmt)
                    .IsRequired()
                    .HasColumnType("money")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TotalDue)
                    .IsRequired()
                    .HasColumnType("money");

                entity.Property(e => e.VendorId)
                    .HasColumnName("VendorID")
                    .HasColumnType("int");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PurchaseOrderHeader)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ShipMethod)
                    .WithMany(p => p.PurchaseOrderHeader)
                    .HasForeignKey(d => d.ShipMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.PurchaseOrderHeader)
                    .HasForeignKey(d => d.VendorId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SalesOrderDetail>(entity =>
            {
                entity.HasKey(e => new { e.SalesOrderId, e.SalesOrderDetailId });

                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SalesOrderDetail_rowguid")
                    .IsUnique();

                entity.Property(e => e.SalesOrderId)
                    .HasColumnName("SalesOrderID")
                    .HasColumnType("int");

                entity.Property(e => e.SalesOrderDetailId).HasColumnName("SalesOrderDetailID");

                entity.Property(e => e.CarrierTrackingNumber).HasColumnType("nvarchar(25)");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.OrderQty).HasColumnType("smallint");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasColumnType("int");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.Property(e => e.SpecialOfferId)
                    .HasColumnName("SpecialOfferID")
                    .HasColumnType("int");

                entity.Property(e => e.UnitPrice)
                    .IsRequired()
                    .HasColumnType("money");

                entity.Property(e => e.UnitPriceDiscount)
                    .IsRequired()
                    .HasColumnType("money")
                    .HasDefaultValueSql("0.0");

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.SalesOrderDetail)
                    .HasForeignKey(d => d.SalesOrderId);

                entity.HasOne(d => d.SpecialOfferProduct)
                    .WithMany(p => p.SalesOrderDetail)
                    .HasForeignKey(d => new { d.SpecialOfferId, d.ProductId })
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SalesOrderHeader>(entity =>
            {
                entity.HasKey(e => e.SalesOrderId);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SalesOrderHeader_rowguid")
                    .IsUnique();

                entity.HasIndex(e => e.SalesPersonId);

                entity.Property(e => e.SalesOrderId)
                    .HasColumnName("SalesOrderID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountNumber).HasColumnType("nvarchar(15)");

                entity.Property(e => e.BillToAddressId)
                    .HasColumnName("BillToAddressID")
                    .HasColumnType("int");

                entity.Property(e => e.Comment).HasColumnType("nvarchar(128)");

                entity.Property(e => e.CreditCardApprovalCode).HasColumnType("nvarchar(15)");

                entity.Property(e => e.CreditCardId)
                    .HasColumnName("CreditCardID")
                    .HasColumnType("int");

                entity.Property(e => e.CurrencyRateId)
                    .HasColumnName("CurrencyRateID")
                    .HasColumnType("int");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("CustomerID")
                    .HasColumnType("int");

                entity.Property(e => e.DueDate)
                    .IsRequired()
                    .HasColumnType("datetime");

                entity.Property(e => e.Freight)
                    .IsRequired()
                    .HasColumnType("money")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.OnlineOrderFlag)
                    .IsRequired()
                    .HasColumnType("bit")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.OrderDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.PurchaseOrderNumber).HasColumnType("nvarchar(25)");

                entity.Property(e => e.RevisionNumber).HasColumnType("tinyint");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.Property(e => e.SalesPersonId)
                    .HasColumnName("SalesPersonID")
                    .HasColumnType("int");

                entity.Property(e => e.ShipDate).HasColumnType("datetime");

                entity.Property(e => e.ShipMethodId)
                    .HasColumnName("ShipMethodID")
                    .HasColumnType("int");

                entity.Property(e => e.ShipToAddressId)
                    .HasColumnName("ShipToAddressID")
                    .HasColumnType("int");

                entity.Property(e => e.Status)
                    .HasColumnType("tinyint")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.SubTotal)
                    .IsRequired()
                    .HasColumnType("money")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TaxAmt)
                    .IsRequired()
                    .HasColumnType("money")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TerritoryId)
                    .HasColumnName("TerritoryID")
                    .HasColumnType("int");

                entity.HasOne(d => d.BillToAddress)
                    .WithMany(p => p.SalesOrderHeaderBillToAddress)
                    .HasForeignKey(d => d.BillToAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.CreditCard)
                    .WithMany(p => p.SalesOrderHeader)
                    .HasForeignKey(d => d.CreditCardId);

                entity.HasOne(d => d.CurrencyRate)
                    .WithMany(p => p.SalesOrderHeader)
                    .HasForeignKey(d => d.CurrencyRateId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SalesOrderHeader)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SalesPerson)
                    .WithMany(p => p.SalesOrderHeader)
                    .HasForeignKey(d => d.SalesPersonId);

                entity.HasOne(d => d.ShipMethod)
                    .WithMany(p => p.SalesOrderHeader)
                    .HasForeignKey(d => d.ShipMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ShipToAddress)
                    .WithMany(p => p.SalesOrderHeaderShipToAddress)
                    .HasForeignKey(d => d.ShipToAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Territory)
                    .WithMany(p => p.SalesOrderHeader)
                    .HasForeignKey(d => d.TerritoryId);
            });

            modelBuilder.Entity<SalesOrderHeaderSalesReason>(entity =>
            {
                entity.HasKey(e => new { e.SalesOrderId, e.SalesReasonId });

                entity.Property(e => e.SalesOrderId)
                    .HasColumnName("SalesOrderID")
                    .HasColumnType("int");

                entity.Property(e => e.SalesReasonId)
                    .HasColumnName("SalesReasonID")
                    .HasColumnType("int");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.HasOne(d => d.SalesOrder)
                    .WithMany(p => p.SalesOrderHeaderSalesReason)
                    .HasForeignKey(d => d.SalesOrderId);

                entity.HasOne(d => d.SalesReason)
                    .WithMany(p => p.SalesOrderHeaderSalesReason)
                    .HasForeignKey(d => d.SalesReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SalesPerson>(entity =>
            {
                entity.HasKey(e => e.BusinessEntityId);

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SalesPerson_rowguid")
                    .IsUnique();

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bonus)
                    .IsRequired()
                    .HasColumnType("money")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.CommissionPct)
                    .IsRequired()
                    .HasColumnType("money")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.Property(e => e.SalesLastYear)
                    .IsRequired()
                    .HasColumnType("money")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.SalesQuota).HasColumnType("money");

                entity.Property(e => e.SalesYtd)
                    .IsRequired()
                    .HasColumnName("SalesYTD")
                    .HasColumnType("money")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TerritoryId)
                    .HasColumnName("TerritoryID")
                    .HasColumnType("int");

                entity.HasOne(d => d.BusinessEntity)
                    .WithOne(p => p.SalesPerson)
                    .HasForeignKey<SalesPerson>(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Territory)
                    .WithMany(p => p.SalesPerson)
                    .HasForeignKey(d => d.TerritoryId);
            });

            modelBuilder.Entity<SalesPersonQuotaHistory>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.QuotaDate });

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SalesPersonQuotaHistory_rowguid")
                    .IsUnique();

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int");

                entity.Property(e => e.QuotaDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.Property(e => e.SalesQuota)
                    .IsRequired()
                    .HasColumnType("money");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.SalesPersonQuotaHistory)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SalesReason>(entity =>
            {
                entity.Property(e => e.SalesReasonId)
                    .HasColumnName("SalesReasonID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.ReasonType)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");
            });

            modelBuilder.Entity<SalesTaxRate>(entity =>
            {
                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SalesTaxRate_rowguid")
                    .IsUnique();

                entity.HasIndex(e => new { e.StateProvinceId, e.TaxType })
                    .HasName("AK_SalesTaxRate_StateProvinceID_TaxType")
                    .IsUnique();

                entity.Property(e => e.SalesTaxRateId)
                    .HasColumnName("SalesTaxRateID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.Property(e => e.StateProvinceId)
                    .HasColumnName("StateProvinceID")
                    .HasColumnType("int");

                entity.Property(e => e.TaxRate)
                    .IsRequired()
                    .HasColumnType("money")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.TaxType).HasColumnType("tinyint");

                entity.HasOne(d => d.StateProvince)
                    .WithMany(p => p.SalesTaxRate)
                    .HasForeignKey(d => d.StateProvinceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SalesTerritory>(entity =>
            {
                entity.HasKey(e => e.TerritoryId);

                entity.HasIndex(e => e.Name)
                    .HasName("AK_SalesTerritory_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SalesTerritory_rowguid")
                    .IsUnique();

                entity.Property(e => e.TerritoryId)
                    .HasColumnName("TerritoryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CostLastYear)
                    .IsRequired()
                    .HasColumnType("money")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.CostYtd)
                    .IsRequired()
                    .HasColumnName("CostYTD")
                    .HasColumnType("money")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.CountryRegionCode)
                    .IsRequired()
                    .HasColumnType("nvarchar(3)");

                entity.Property(e => e.Group)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.Property(e => e.SalesLastYear)
                    .IsRequired()
                    .HasColumnType("money")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.SalesYtd)
                    .IsRequired()
                    .HasColumnName("SalesYTD")
                    .HasColumnType("money")
                    .HasDefaultValueSql("0.00");

                entity.HasOne(d => d.CountryRegionCodeNavigation)
                    .WithMany(p => p.SalesTerritory)
                    .HasForeignKey(d => d.CountryRegionCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SalesTerritoryHistory>(entity =>
            {
                entity.HasKey(e => new { e.BusinessEntityId, e.StartDate, e.TerritoryId });

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SalesTerritoryHistory_rowguid")
                    .IsUnique();

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TerritoryId)
                    .HasColumnName("TerritoryID")
                    .HasColumnType("int");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.HasOne(d => d.BusinessEntity)
                    .WithMany(p => p.SalesTerritoryHistory)
                    .HasForeignKey(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Territory)
                    .WithMany(p => p.SalesTerritoryHistory)
                    .HasForeignKey(d => d.TerritoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ScrapReason>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_ScrapReason_Name")
                    .IsUnique();

                entity.Property(e => e.ScrapReasonId)
                    .HasColumnName("ScrapReasonID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");
            });

            modelBuilder.Entity<Shift>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_Shift_Name")
                    .IsUnique();

                entity.HasIndex(e => new { e.StartTime, e.EndTime })
                    .HasName("AK_Shift_StartTime_EndTime")
                    .IsUnique();

                entity.Property(e => e.ShiftId)
                    .HasColumnName("ShiftID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnType("nvarchar(16)");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnType("nvarchar(16)");
            });

            modelBuilder.Entity<ShipMethod>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_ShipMethod_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_ShipMethod_rowguid")
                    .IsUnique();

                entity.Property(e => e.ShipMethodId)
                    .HasColumnName("ShipMethodID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.Property(e => e.ShipBase)
                    .IsRequired()
                    .HasColumnType("money")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.ShipRate)
                    .IsRequired()
                    .HasColumnType("money")
                    .HasDefaultValueSql("0.00");
            });

            modelBuilder.Entity<ShoppingCartItem>(entity =>
            {
                entity.HasIndex(e => new { e.ShoppingCartId, e.ProductId });

                entity.Property(e => e.ShoppingCartItemId)
                    .HasColumnName("ShoppingCartItemID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DateCreated)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasColumnType("int");

                entity.Property(e => e.Quantity)
                    .HasColumnType("int")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ShoppingCartId)
                    .IsRequired()
                    .HasColumnName("ShoppingCartID")
                    .HasColumnType("nvarchar(50)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ShoppingCartItem)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<SpecialOffer>(entity =>
            {
                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SpecialOffer_rowguid")
                    .IsUnique();

                entity.Property(e => e.SpecialOfferId)
                    .HasColumnName("SpecialOfferID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("nvarchar(255)");

                entity.Property(e => e.DiscountPct)
                    .IsRequired()
                    .HasColumnType("money")
                    .HasDefaultValueSql("0.00");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnType("datetime");

                entity.Property(e => e.MaxQty).HasColumnType("int");

                entity.Property(e => e.MinQty).HasColumnType("int");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");
            });

            modelBuilder.Entity<SpecialOfferProduct>(entity =>
            {
                entity.HasKey(e => new { e.SpecialOfferId, e.ProductId });

                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_SpecialOfferProduct_rowguid")
                    .IsUnique();

                entity.Property(e => e.SpecialOfferId)
                    .HasColumnName("SpecialOfferID")
                    .HasColumnType("int");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasColumnType("int");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.SpecialOfferProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SpecialOffer)
                    .WithMany(p => p.SpecialOfferProduct)
                    .HasForeignKey(d => d.SpecialOfferId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<StateProvince>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("AK_StateProvince_Name")
                    .IsUnique();

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_StateProvince_rowguid")
                    .IsUnique();

                entity.HasIndex(e => new { e.StateProvinceCode, e.CountryRegionCode })
                    .HasName("AK_StateProvince_StateProvinceCode_CountryRegionCode")
                    .IsUnique();

                entity.Property(e => e.StateProvinceId)
                    .HasColumnName("StateProvinceID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryRegionCode)
                    .IsRequired()
                    .HasColumnType("nvarchar(3)");

                entity.Property(e => e.IsOnlyStateProvinceFlag)
                    .IsRequired()
                    .HasColumnType("bit")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.Property(e => e.StateProvinceCode)
                    .IsRequired()
                    .HasColumnType("nchar(3)");

                entity.Property(e => e.TerritoryId)
                    .HasColumnName("TerritoryID")
                    .HasColumnType("int");

                entity.HasOne(d => d.CountryRegionCodeNavigation)
                    .WithMany(p => p.StateProvince)
                    .HasForeignKey(d => d.CountryRegionCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Territory)
                    .WithMany(p => p.StateProvince)
                    .HasForeignKey(d => d.TerritoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.HasKey(e => e.BusinessEntityId);

                entity.HasIndex(e => e.Rowguid)
                    .HasName("AK_Store_rowguid")
                    .IsUnique();

                entity.HasIndex(e => e.SalesPersonId);

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int")
                    .ValueGeneratedNever();

                entity.Property(e => e.Demographics).HasColumnType("ntext");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.Rowguid)
                    .IsRequired()
                    .HasColumnName("rowguid")
                    .HasColumnType("uniqueidentifier");

                entity.Property(e => e.SalesPersonId)
                    .HasColumnName("SalesPersonID")
                    .HasColumnType("int");

                entity.HasOne(d => d.BusinessEntity)
                    .WithOne(p => p.Store)
                    .HasForeignKey<Store>(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.SalesPerson)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.SalesPersonId);
            });

            modelBuilder.Entity<TransactionHistory>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => new { e.ReferenceOrderId, e.ReferenceOrderLineId });

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActualCost)
                    .IsRequired()
                    .HasColumnType("money");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasColumnType("int");

                entity.Property(e => e.Quantity).HasColumnType("int");

                entity.Property(e => e.ReferenceOrderId)
                    .HasColumnName("ReferenceOrderID")
                    .HasColumnType("int");

                entity.Property(e => e.ReferenceOrderLineId)
                    .HasColumnName("ReferenceOrderLineID")
                    .HasColumnType("int");

                entity.Property(e => e.TransactionDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnType("nchar(1)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.TransactionHistory)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TransactionHistoryArchive>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => new { e.ReferenceOrderId, e.ReferenceOrderLineId });

                entity.Property(e => e.TransactionId)
                    .HasColumnName("TransactionID")
                    .HasColumnType("int")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActualCost)
                    .IsRequired()
                    .HasColumnType("money");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasColumnType("int");

                entity.Property(e => e.Quantity).HasColumnType("int");

                entity.Property(e => e.ReferenceOrderId)
                    .HasColumnName("ReferenceOrderID")
                    .HasColumnType("int");

                entity.Property(e => e.ReferenceOrderLineId)
                    .HasColumnName("ReferenceOrderLineID")
                    .HasColumnType("int");

                entity.Property(e => e.TransactionDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnType("nchar(1)");
            });

            modelBuilder.Entity<UnitMeasure>(entity =>
            {
                entity.HasKey(e => e.UnitMeasureCode);

                entity.HasIndex(e => e.Name)
                    .HasName("AK_UnitMeasure_Name")
                    .IsUnique();

                entity.Property(e => e.UnitMeasureCode)
                    .HasColumnType("nchar(3)")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.HasKey(e => e.BusinessEntityId);

                entity.HasIndex(e => e.AccountNumber)
                    .HasName("AK_Vendor_AccountNumber")
                    .IsUnique();

                entity.Property(e => e.BusinessEntityId)
                    .HasColumnName("BusinessEntityID")
                    .HasColumnType("int")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasColumnType("nvarchar(15)");

                entity.Property(e => e.ActiveFlag)
                    .IsRequired()
                    .HasColumnType("bit")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CreditRating).HasColumnType("tinyint");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nvarchar(50)");

                entity.Property(e => e.PreferredVendorStatus)
                    .IsRequired()
                    .HasColumnType("bit")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.PurchasingWebServiceUrl)
                    .HasColumnName("PurchasingWebServiceURL")
                    .HasColumnType("nvarchar(1024)");

                entity.HasOne(d => d.BusinessEntity)
                    .WithOne(p => p.Vendor)
                    .HasForeignKey<Vendor>(d => d.BusinessEntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<WorkOrder>(entity =>
            {
                entity.HasIndex(e => e.ProductId);

                entity.HasIndex(e => e.ScrapReasonId);

                entity.Property(e => e.WorkOrderId)
                    .HasColumnName("WorkOrderID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DueDate)
                    .IsRequired()
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.OrderQty).HasColumnType("int");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasColumnType("int");

                entity.Property(e => e.ScrapReasonId)
                    .HasColumnName("ScrapReasonID")
                    .HasColumnType("int");

                entity.Property(e => e.ScrappedQty).HasColumnType("smallint");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.WorkOrder)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.ScrapReason)
                    .WithMany(p => p.WorkOrder)
                    .HasForeignKey(d => d.ScrapReasonId);
            });

            modelBuilder.Entity<WorkOrderRouting>(entity =>
            {
                entity.HasKey(e => new { e.WorkOrderId, e.ProductId, e.OperationSequence });

                entity.HasIndex(e => e.ProductId);

                entity.Property(e => e.WorkOrderId)
                    .HasColumnName("WorkOrderID")
                    .HasColumnType("int");

                entity.Property(e => e.ProductId)
                    .HasColumnName("ProductID")
                    .HasColumnType("int");

                entity.Property(e => e.OperationSequence).HasColumnType("smallint");

                entity.Property(e => e.ActualCost).HasColumnType("money");

                entity.Property(e => e.ActualEndDate).HasColumnType("datetime");

                entity.Property(e => e.ActualResourceHrs).HasColumnType("numeric(9,4)");

                entity.Property(e => e.ActualStartDate).HasColumnType("datetime");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasColumnType("int");

                entity.Property(e => e.ModifiedDate)
                    .IsRequired()
                    .HasColumnType("datetime current_timestamp");

                entity.Property(e => e.PlannedCost)
                    .IsRequired()
                    .HasColumnType("money");

                entity.Property(e => e.ScheduledEndDate)
                    .IsRequired()
                    .HasColumnType("datetime");

                entity.Property(e => e.ScheduledStartDate)
                    .IsRequired()
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.WorkOrderRouting)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.WorkOrder)
                    .WithMany(p => p.WorkOrderRouting)
                    .HasForeignKey(d => d.WorkOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });
        }
    }
}
