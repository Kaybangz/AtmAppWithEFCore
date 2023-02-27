using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace AtmApp.DATA.Entities
{
    public class Transfer
    {
        public int Id { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }


        public Customer Sender { get; set; } = null!;
        public int? SenderId { get; set; }


        public Customer Receiver { get; set; } = null!;
        public int? ReceiverId { get; set; }
        
    }
}
