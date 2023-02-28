using AtmApp.DATA.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtmApp.DATA.Entities
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Firstname { get; set; } = null!;

        [Column(TypeName = "nvarchar(20)")]
        public string? Middlename { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Lastname { get; set; } = null!;

        [Column(TypeName = "nvarchar(15)")]
        public string PhoneNumber { get; set; } = null!;

        [Column(TypeName = "int")]
        public int Pin { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string AccountNumber { get; set; } = null!;
        public AccountType AccountType { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal Balance { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}
