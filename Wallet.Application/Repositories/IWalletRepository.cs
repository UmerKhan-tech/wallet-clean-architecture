using Wallet.Domain.Entities;

namespace Wallet.Application.Repositories
{
    public interface IWalletRepository
    {
        WalletEntity Add(WalletEntity wallet);
        WalletEntity Get(int id);
        void Update(WalletEntity wallet);
    }
}