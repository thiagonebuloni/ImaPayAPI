﻿using ImaPayAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ImaPayAPI.Context
{
    public class ImayPayContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionHistory> TransactionsHistory { get; set; }

        public Dictionary<string, User> userToken = new Dictionary<string, User>();


        public ImayPayContext(DbContextOptions options) : base(options)
        {
        }
    }
}
