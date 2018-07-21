using System.IO;
using System.Linq;
using System.Xml.Serialization;
using CoreAngular.AdventureWorks;
using CoreAngular.AdventureWorks.SqliteModel;
using Xunit;

namespace CoreAngular.Db.Tests
{
    public class AdventureWorksSqlite2017Tests
    {
        private readonly Adventureworks2017Context _context = new Adventureworks2017Context();

        [Fact]
        public void CanGetCustomers()
        {
            // Act
            var result = _context.Customer.ToList();

            // Assert
            Assert.NotNull(result);
            Assert.True(result.Count > 0);
        }

        [Fact]
        public void CanResetPasswords()
        {
            var emails = _context.EmailAddress.ToList();
            foreach (var email in emails)
            {
                var password = _context.Password.Single(p => p.BusinessEntityId == email.BusinessEntityId);
                if(password == null) continue;
                var encryptedPassword = SecurityService.GenerateHashedPassword(password.PasswordSalt, email.EmailAddress1);
                if(encryptedPassword == password.PasswordHash) continue;
                password.PasswordHash = encryptedPassword;
                _context.SaveChanges();
            }
        }

        [Fact]
        public void CanGetCustomerAdditionalInfo()
        {
            // Arrange & Act
            var customer = _context.Person.Single(p => p.BusinessEntityId == 291);
            var info = AdditionalContactInfo.Deserialize(customer.AdditionalContactInfo);
            //Assert
            Assert.NotNull(customer);
            Assert.NotNull(info);
        }
    }
}
