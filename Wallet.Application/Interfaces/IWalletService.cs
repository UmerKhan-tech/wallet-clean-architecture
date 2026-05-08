using System;
using System.Collections.Generic;
using System.Text;
using Wallet.Domain.Entities;


namespace Wallet.Application.Interfaces
{
    public interface IWalletService
    {
        WalletEntity Create(string user);
        WalletEntity Credit(int id, decimal amount);
        WalletEntity Get(int id);
    }
}
