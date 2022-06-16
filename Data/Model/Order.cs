using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Customer Customer { get; set; }
       
        public List<QuantitiesForProduct> Quantities { get; set; }
        [Required]
        public decimal Price { get; set; }
        
        public string Comment { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public OrderStatus Status { get; set; }
    }
}
