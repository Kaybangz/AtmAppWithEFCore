using AtmApp.DATA.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtmApp.DATA.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Pin { get; set; }
        public int AccountNumber { get; set; }
        public AccountType AccountType { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal Balance { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
