using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmApp.DATA.Entities
{
    public class Transfer
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }


        public int SenderId { get; set; }
        public Customer Sender { get; set; } = null!;



        public int ReceiverId { get; set; }
        public Customer Receiver { get; set; } = null!;
    }
}
