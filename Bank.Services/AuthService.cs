using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Contracts;

namespace Bank.Services
{
    public class AuthService : IAuth
    {
        public string HashPassword(string password)
        {
            throw new NotImplementedException();
        }

        public bool ValidatePassword(string password, string hashedPassword)
        {
            throw new NotImplementedException();
        }

    }
}
