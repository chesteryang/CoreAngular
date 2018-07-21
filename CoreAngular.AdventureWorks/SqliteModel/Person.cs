using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace CoreAngular.AdventureWorks.SqliteModel
{
    public partial class Person
    {
        public Person()
        {
            BusinessEntityContact = new HashSet<BusinessEntityContact>();
            Customer = new HashSet<Customer>();
            EmailAddress = new HashSet<EmailAddress>();
            PersonCreditCard = new HashSet<PersonCreditCard>();
            PersonPhone = new HashSet<PersonPhone>();
        }

        public long BusinessEntityId { get; set; }
        public string PersonType { get; set; }
        public string NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public long EmailPromotion { get; set; }
        public string AdditionalContactInfo { get; set; }
        [JsonIgnore]
        public string Demographics { get; set; }
        [JsonIgnore]
        public string Rowguid { get; set; }
        [JsonIgnore]
        public string ModifiedDate { get; set; }

        public BusinessEntity BusinessEntity { get; set; }
        public Employee Employee { get; set; }
        [JsonIgnore]
        public Password Password { get; set; }
        public ICollection<BusinessEntityContact> BusinessEntityContact { get; set; }
        public ICollection<Customer> Customer { get; set; }
        public ICollection<EmailAddress> EmailAddress { get; set; }
        [JsonIgnore]
        public ICollection<PersonCreditCard> PersonCreditCard { get; set; }
        [JsonIgnore]
        public ICollection<PersonPhone> PersonPhone { get; set; }
    }
}
