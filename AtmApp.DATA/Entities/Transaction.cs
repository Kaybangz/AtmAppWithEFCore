using AtmApp.DATA.Enums;
using System;


namespace AtmApp.DATA.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public TransactionType TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }


        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
    }
}
