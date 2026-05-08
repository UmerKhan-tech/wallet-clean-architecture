using System;
using System.Collections.Generic;
using System.Text;

namespace Wallet.Domain.Entities
{
    public class WalletEntity
    {
        public int Id { get; set; } 
        public string UserName { get; set; }
        public decimal Balance { get; set; }
    }
}
