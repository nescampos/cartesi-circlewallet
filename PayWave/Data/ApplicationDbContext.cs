﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PayWave.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Receiver> Receivers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}