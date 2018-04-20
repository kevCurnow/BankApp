using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Contracts
{
    public interface IAuth
    {
        string HashPin(string pin);
        bool ValidatePin(string pin);
    }
}
