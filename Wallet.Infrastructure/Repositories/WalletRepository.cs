using Wallet.Application.Repositories;
using Wallet.Domain.Entities;
using Wallet.Infrastructure.Data;

namespace Wallet.Infrastructure.Repositories
{
    public class WalletRepository : IWalletRepository
    {
        private readonly AppDbContext _context;

        public WalletRepository(AppDbContext context)
        {
            _context = context;
        }

        public WalletEntity Add(WalletEntity wallet)
        {
            _context.Wallets.Add(wallet);
            _context.SaveChanges();
            return wallet;
        }

        public WalletEntity Get(int id)
        {
            return _context.Wallets.Find(id);
        }

        public void Update(WalletEntity wallet)
        {
            _context.Wallets.Update(wallet);
            _context.SaveChanges();
        }
    }
}