using Domain.Enitities;
using Microsoft.EntityFrameworkCore;

namespace Application.Interfaces;

public interface IAppDbContext
{
    DbSet<Account> Accounts { get; set; }
    DbSet<Budget> Budgets { get; set; }
    DbSet<Cashflow> Cashflows { get; set; }
    DbSet<Category> Categories { get; set; }
    DbSet<DefaultShare> DefaultShares { get; set; }
    DbSet<Share> Shares { get; set; }
    DbSet<Transaction> Transactions { get; set; }
    DbSet<User> Users { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
