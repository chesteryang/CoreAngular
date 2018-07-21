using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class Product
    {
        public Product()
        {
            BillOfMaterialsComponent = new HashSet<BillOfMaterials>();
            BillOfMaterialsProductAssembly = new HashSet<BillOfMaterials>();
            ProductCostHistory = new HashSet<ProductCostHistory>();
            ProductDocument = new HashSet<ProductDocument>();
            ProductInventory = new HashSet<ProductInventory>();
            ProductListPriceHistory = new HashSet<ProductListPriceHistory>();
            ProductProductPhoto = new HashSet<ProductProductPhoto>();
            ProductReview = new HashSet<ProductReview>();
            ProductVendor = new HashSet<ProductVendor>();
            PurchaseOrderDetail = new HashSet<PurchaseOrderDetail>();
            ShoppingCartItem = new HashSet<ShoppingCartItem>();
            SpecialOfferProduct = new HashSet<SpecialOfferProduct>();
            TransactionHistory = new HashSet<TransactionHistory>();
            WorkOrder = new HashSet<WorkOrder>();
        }

        public long ProductId { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public string MakeFlag { get; set; }
        public string FinishedGoodsFlag { get; set; }
        public string Color { get; set; }
        public long SafetyStockLevel { get; set; }
        public long ReorderPoint { get; set; }
        public string StandardCost { get; set; }
        public string ListPrice { get; set; }
        public string Size { get; set; }
        public string SizeUnitMeasureCode { get; set; }
        public string WeightUnitMeasureCode { get; set; }
        public string Weight { get; set; }
        public long DaysToManufacture { get; set; }
        public string ProductLine { get; set; }
        public string Class { get; set; }
        public string Style { get; set; }
        public long? ProductSubcategoryId { get; set; }
        public long? ProductModelId { get; set; }
        public string SellStartDate { get; set; }
        public string SellEndDate { get; set; }
        public string DiscontinuedDate { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public ProductModel ProductModel { get; set; }
        public ProductSubcategory ProductSubcategory { get; set; }
        public UnitMeasure SizeUnitMeasureCodeNavigation { get; set; }
        public UnitMeasure WeightUnitMeasureCodeNavigation { get; set; }
        public ICollection<BillOfMaterials> BillOfMaterialsComponent { get; set; }
        public ICollection<BillOfMaterials> BillOfMaterialsProductAssembly { get; set; }
        public ICollection<ProductCostHistory> ProductCostHistory { get; set; }
        public ICollection<ProductDocument> ProductDocument { get; set; }
        public ICollection<ProductInventory> ProductInventory { get; set; }
        public ICollection<ProductListPriceHistory> ProductListPriceHistory { get; set; }
        public ICollection<ProductProductPhoto> ProductProductPhoto { get; set; }
        public ICollection<ProductReview> ProductReview { get; set; }
        public ICollection<ProductVendor> ProductVendor { get; set; }
        public ICollection<PurchaseOrderDetail> PurchaseOrderDetail { get; set; }
        public ICollection<ShoppingCartItem> ShoppingCartItem { get; set; }
        public ICollection<SpecialOfferProduct> SpecialOfferProduct { get; set; }
        public ICollection<TransactionHistory> TransactionHistory { get; set; }
        public ICollection<WorkOrder> WorkOrder { get; set; }
    }
}
