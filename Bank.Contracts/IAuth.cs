using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Contracts
{
    public interface IAuth
    {
        string HashPassword(string password);
        bool ValidatePassword(string password, string hashedPassword);
    }
}
