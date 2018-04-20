using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bank.Models.Account_Models;

namespace Bank.Tests.Account
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void NewAccountCreateTest()
        {
            //Arrange
            string accountNum = "7777";
            string pin = "7777";
            int accountType = 1;
            decimal startingBalance = 7777;
            int customerId = 1;

            AccountCreateModel newAccount = new AccountCreateModel
            {
                AccountNumber = accountNum,
                Pin = pin,
                AccountType = accountType,
                Balance = startingBalance,
                CustomerId = customerId
            };

            //Act
            newAccount.AccountNumber = "7777";
            newAccount.Pin = "7777";
            newAccount.AccountType = 1;
            newAccount.Balance = 7777;
            newAccount.CustomerId = 1;

            //Assert
            Assert.AreEqual(newAccount.AccountNumber, accountNum);
            Assert.AreEqual(newAccount.Pin, pin);
            Assert.AreEqual(newAccount.AccountType, accountType);
            Assert.AreEqual(newAccount.Balance, startingBalance);
            Assert.AreEqual(newAccount.CustomerId, customerId);

        }
    }
}

