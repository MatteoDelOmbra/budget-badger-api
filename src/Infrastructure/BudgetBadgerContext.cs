using Domain.Enitities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class BudgetBadgerContext : DbContext
{
    public BudgetBadgerContext() { }

    public BudgetBadgerContext(DbContextOptions<BudgetBadgerContext> options)
        : base(options) { }

    public DbSet<Account> Accounts { get; set; }
    public DbSet<Budget> Budgets { get; set; }
    public DbSet<Cashflow> Cashflows { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<DefaultShare> DefaultShares { get; set; }
    public DbSet<Share> Shares { get; set; }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            @"host=localhost:5432;username=postgres;password=P@ssw0rd;database=budget_badger"
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Budget>().HasOne(b => b.Owner).WithMany(u => u.OwnedBudgets);
    }
}
