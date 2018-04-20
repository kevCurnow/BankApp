using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Models.CustomerModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bank.Tests.Customer
{
    [TestClass()]
    public class CustomerATMControllerTests
    {
        [TestMethod()]
        public void Should_Be_Able_To_Create_CustomerCreateModel_Object()
        {
            //Arrange
            int ssn = 888;
            string firstName = "Dwight";
            string lastName = "Eisenhower";

            CustomerCreateModel user = new CustomerCreateModel
            {
                SocialSecurityNumber = ssn,
                FirstName = firstName,
                LastName = lastName
            };

            //Act
            user.FirstName = "Dwight";

            //Assert
            Assert.AreEqual(user.FirstName, firstName);
            Assert.AreNotSame(user.FirstName, lastName);
        }
    }
}
