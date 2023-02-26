using AtmApp.DATA.Enums;
using System;
using System.Collections.Generic;

namespace AtmApp.DATA.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Pin { get; set; }
        public int AccountNumber { get; set; }
        public AccountType AccountType { get; set; }
        public decimal Balance { get; set; }
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
