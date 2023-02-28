using AtmApp.DATA.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtmApp.DATA.Entities
{
    [Table("Customer")]
    public class Customer
    {
        public int CustomerId { get; set; }

        [Column("nvarchar(50)")]
        public string Name { get; set; } = null!;

        [Column("int(5)")]
        public int Pin { get; set; }

        [Column(TypeName = "bigint(15)")]
        public long AccountNumber { get; set; }
        public AccountType AccountType { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal Balance { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
