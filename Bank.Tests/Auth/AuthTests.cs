using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bank.Services;
using Bank.Data;

namespace Bank.Tests.Auth
{
    [TestClass]
    public class AuthTests
    {
        [TestMethod]
        public void AuthServiceVerifyTests()
        {
            string accountNum = "1111";
            string pin = "1111";
            BankEntities bank = new BankEntities();
            AuthService authService = new AuthService();

            //Act
            bool test = authService.VerifyUser(accountNum, pin);

            //Assert
            Assert.IsTrue(test);
        }
    }
}
