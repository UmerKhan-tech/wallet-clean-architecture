using Wallet.Application.Interfaces;
using Wallet.Application.Repositories;
using Wallet.Domain.Entities;

namespace Wallet.Infrastructure.Services
{
    public class WalletService : IWalletService
    {
        private readonly IWalletRepository _repo;

        public WalletService(IWalletRepository repo)
        {
            _repo = repo;
        }

        public WalletEntity Create(string user)
        {
            var wallet = new WalletEntity
            {
                UserName = user,
                Balance = 0
            };

            return _repo.Add(wallet);
        }

        public WalletEntity Credit(int id, decimal amount)
        {
            var wallet = _repo.Get(id);
            if (wallet == null) return null;

            wallet.Balance += amount;
            _repo.Update(wallet);

            return wallet;
        }

        public WalletEntity Get(int id)
        {
            return _repo.Get(id);
        }
    }
}