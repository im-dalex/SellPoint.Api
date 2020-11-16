using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Testing.Models.Base;

namespace Testing.Models
{
    public class Bill : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
    }
}
