using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Contracts;
using Bank.Data;
using BCr = BCrypt.Net;

namespace Bank.Services
{
    public class AuthService : IAuth
    {
        private Account GetAccountByNumAndPin(BankEntities context, string accountNum, string pin)
        {
            return
                context
                    .Accounts
                    .SingleOrDefault(a => a.AccountNumber == accountNum && a.Pin == pin);
        }

        public bool VerifyUser(string account, string pin)
        {
            Account accountEntity;
            using (var ctx = new BankEntities())
            {
                accountEntity = GetAccountByNumAndPin(ctx, account, pin);
            }

            if (accountEntity == null) return false;
            
            return true;
        }

        public string HashPin(string pin) => BCr.BCrypt.HashPassword(pin);
        public bool ValidatePin(string pin) => BCr.BCrypt.Verify(pin, HashPin(pin));
        //private static string GetRandomSalt()
        //{
        //    return BCr.BCrypt.GenerateSalt(12);
        //}
        //public string HashPin(string pin)
        //{
        //    return BCr.BCrypt.HashPassword(pin, GetRandomSalt());
        //}
        //public bool ValidatePin(string pin, string hashedPassword)
        //{
        //    return BCr.BCrypt.Verify(pin, hashedPassword);
        //}
    }
}
