using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AtmApp.DATA.Entities
{
    [Table("Transfer")]
    public class Transfer
    {
        [Key]
        public int TransferId { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }


        public Customer Sender { get; set; } = null!;
        public int? SenderId { get; set; }


        public Customer Receiver { get; set; } = null!;
        public int? ReceiverId { get; set; }
        
    }
}
