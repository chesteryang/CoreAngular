using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class SalesOrderHeader
    {
        public SalesOrderHeader()
        {
            SalesOrderDetail = new HashSet<SalesOrderDetail>();
            SalesOrderHeaderSalesReason = new HashSet<SalesOrderHeaderSalesReason>();
        }

        public long SalesOrderId { get; set; }
        public long RevisionNumber { get; set; }
        public string OrderDate { get; set; }
        public string DueDate { get; set; }
        public string ShipDate { get; set; }
        public long Status { get; set; }
        public string OnlineOrderFlag { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string AccountNumber { get; set; }
        public long CustomerId { get; set; }
        public long? SalesPersonId { get; set; }
        public long? TerritoryId { get; set; }
        public long BillToAddressId { get; set; }
        public long ShipToAddressId { get; set; }
        public long ShipMethodId { get; set; }
        public long? CreditCardId { get; set; }
        public string CreditCardApprovalCode { get; set; }
        public long? CurrencyRateId { get; set; }
        public string SubTotal { get; set; }
        public string TaxAmt { get; set; }
        public string Freight { get; set; }
        public string Comment { get; set; }
        public string Rowguid { get; set; }
        public string ModifiedDate { get; set; }

        public Address BillToAddress { get; set; }
        public CreditCard CreditCard { get; set; }
        public CurrencyRate CurrencyRate { get; set; }
        public Customer Customer { get; set; }
        public SalesPerson SalesPerson { get; set; }
        public ShipMethod ShipMethod { get; set; }
        public Address ShipToAddress { get; set; }
        public SalesTerritory Territory { get; set; }
        public ICollection<SalesOrderDetail> SalesOrderDetail { get; set; }
        public ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReason { get; set; }
    }
}
