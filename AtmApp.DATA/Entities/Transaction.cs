using AtmApp.DATA.Enums;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtmApp.DATA.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public TransactionType TransactionType { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }


        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
    }
}
