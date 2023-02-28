using AtmApp.DATA.Enums;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtmApp.DATA.Entities
{
    [Table("Transaction")]
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        public TransactionType TransactionType { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        public Customer Customer { get; set; } = null!;
        public int CustomerId { get; set; }
    }
}
