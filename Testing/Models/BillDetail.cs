using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Testing.Models.Base;

namespace Testing.Models
{
    public class BillDetail : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int BillId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Amount { get; set; }

        [ForeignKey("BillId")]
        public Bill Bill { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
