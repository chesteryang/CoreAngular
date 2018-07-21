using System;
using System.Collections.Generic;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class CreditCard
    {
        public CreditCard()
        {
            PersonCreditCard = new HashSet<PersonCreditCard>();
            SalesOrderHeader = new HashSet<SalesOrderHeader>();
        }

        public long CreditCardId { get; set; }
        public string CardType { get; set; }
        public string CardNumber { get; set; }
        public long ExpMonth { get; set; }
        public long ExpYear { get; set; }
        public string ModifiedDate { get; set; }

        public ICollection<PersonCreditCard> PersonCreditCard { get; set; }
        public ICollection<SalesOrderHeader> SalesOrderHeader { get; set; }
    }
}
