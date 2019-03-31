using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsAPI.Models
{
    public class ItemsPrice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        
        [ForeignKey("Items")]
        public int ItemId { get; set; }
        [Required(ErrorMessage = "ItemPrice is required")]
        public double ItemPrice { get; set; }
    }
}
