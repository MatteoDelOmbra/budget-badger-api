using Application.Interfaces;
using Domain.Enitities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class AppDbContext(DbContextOptions<AppDbContext> options)
    : DbContext(options),
        IAppDbContext
{
    public required DbSet<User> Users { get; set; }
    public required DbSet<Account> Accounts { get; set; }
    public required DbSet<Budget> Budgets { get; set; }
    public required DbSet<Cashflow> Cashflows { get; set; }
    public required DbSet<Category> Categories { get; set; }
    public required DbSet<DefaultShare> DefaultShares { get; set; }
    public required DbSet<Share> Shares { get; set; }
    public required DbSet<Transaction> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Budget>().HasOne(b => b.Owner).WithMany(u => u.OwnedBudgets);
    }
}
