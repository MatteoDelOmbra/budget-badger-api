﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(BudgetBadgerContext))]
    partial class BudgetBadgerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AccountUser", b =>
                {
                    b.Property<string>("AccountsId")
                        .HasColumnType("text");

                    b.Property<string>("OwnersId")
                        .HasColumnType("text");

                    b.HasKey("AccountsId", "OwnersId");

                    b.HasIndex("OwnersId");

                    b.ToTable("AccountUser");
                });

            modelBuilder.Entity("BudgetUser", b =>
                {
                    b.Property<string>("BudgetsId")
                        .HasColumnType("text");

                    b.Property<string>("UsersId")
                        .HasColumnType("text");

                    b.HasKey("BudgetsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("BudgetUser");
                });

            modelBuilder.Entity("Domain.Enitities.Account", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<decimal>("Balance")
                        .HasColumnType("numeric");

                    b.Property<string>("BudgetId")
                        .HasColumnType("text");

                    b.Property<int>("Currency")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BudgetId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Domain.Enitities.Budget", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("OwnerId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Budgets");
                });

            modelBuilder.Entity("Domain.Enitities.Cashflow", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("CategoryId")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TransactionId")
                        .HasColumnType("text");

                    b.Property<int>("Value")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("TransactionId");

                    b.ToTable("Cashflows");
                });

            modelBuilder.Entity("Domain.Enitities.Category", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("BudgetId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("BudgetId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Domain.Enitities.DefaultShare", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("CategoryId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Percentage")
                        .HasColumnType("integer");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("DefaultShares");
                });

            modelBuilder.Entity("Domain.Enitities.Share", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("CashflowId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Debt")
                        .HasColumnType("integer");

                    b.Property<string>("Percentage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CashflowId");

                    b.HasIndex("UserId");

                    b.ToTable("Shares");
                });

            modelBuilder.Entity("Domain.Enitities.Transaction", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("BudgetId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.Property<decimal>("Value")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("BudgetId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Domain.Enitities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsAnonym")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AccountUser", b =>
                {
                    b.HasOne("Domain.Enitities.Account", null)
                        .WithMany()
                        .HasForeignKey("AccountsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Enitities.User", null)
                        .WithMany()
                        .HasForeignKey("OwnersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BudgetUser", b =>
                {
                    b.HasOne("Domain.Enitities.Budget", null)
                        .WithMany()
                        .HasForeignKey("BudgetsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Enitities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Enitities.Account", b =>
                {
                    b.HasOne("Domain.Enitities.Budget", "Budget")
                        .WithMany("Accounts")
                        .HasForeignKey("BudgetId");

                    b.Navigation("Budget");
                });

            modelBuilder.Entity("Domain.Enitities.Budget", b =>
                {
                    b.HasOne("Domain.Enitities.User", "Owner")
                        .WithMany("OwnedBudgets")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("Domain.Enitities.Cashflow", b =>
                {
                    b.HasOne("Domain.Enitities.Category", "Category")
                        .WithMany("Cashflows")
                        .HasForeignKey("CategoryId");

                    b.HasOne("Domain.Enitities.Transaction", "Transaction")
                        .WithMany("Cashflows")
                        .HasForeignKey("TransactionId");

                    b.Navigation("Category");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("Domain.Enitities.Category", b =>
                {
                    b.HasOne("Domain.Enitities.Budget", "Budget")
                        .WithMany("Categories")
                        .HasForeignKey("BudgetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Budget");
                });

            modelBuilder.Entity("Domain.Enitities.DefaultShare", b =>
                {
                    b.HasOne("Domain.Enitities.Category", "Category")
                        .WithMany("DefaultShares")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Enitities.User", "User")
                        .WithMany("DefaultShares")
                        .HasForeignKey("UserId");

                    b.Navigation("Category");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Enitities.Share", b =>
                {
                    b.HasOne("Domain.Enitities.Cashflow", "Cashflow")
                        .WithMany("Shares")
                        .HasForeignKey("CashflowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Enitities.User", "User")
                        .WithMany("Shares")
                        .HasForeignKey("UserId");

                    b.Navigation("Cashflow");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Enitities.Transaction", b =>
                {
                    b.HasOne("Domain.Enitities.Account", "Account")
                        .WithMany("Transactions")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Enitities.Budget", "Budget")
                        .WithMany("Transactions")
                        .HasForeignKey("BudgetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Budget");
                });

            modelBuilder.Entity("Domain.Enitities.Account", b =>
                {
                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Domain.Enitities.Budget", b =>
                {
                    b.Navigation("Accounts");

                    b.Navigation("Categories");

                    b.Navigation("Transactions");
                });

            modelBuilder.Entity("Domain.Enitities.Cashflow", b =>
                {
                    b.Navigation("Shares");
                });

            modelBuilder.Entity("Domain.Enitities.Category", b =>
                {
                    b.Navigation("Cashflows");

                    b.Navigation("DefaultShares");
                });

            modelBuilder.Entity("Domain.Enitities.Transaction", b =>
                {
                    b.Navigation("Cashflows");
                });

            modelBuilder.Entity("Domain.Enitities.User", b =>
                {
                    b.Navigation("DefaultShares");

                    b.Navigation("OwnedBudgets");

                    b.Navigation("Shares");
                });
#pragma warning restore 612, 618
        }
    }
}
