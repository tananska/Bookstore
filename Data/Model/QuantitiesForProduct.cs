using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class QuantitiesForProduct
    {

        [Key]
        [Column(Order = 1)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 2)]
        public Order Order { get; set; }

        [Key]
        [Column(Order = 3)]
        public Product Product { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
