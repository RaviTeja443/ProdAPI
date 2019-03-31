using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAPI.Models
{
    public class Items
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "ItemId is required")]
        public int ItemId { get; set; }
        [Required(ErrorMessage = "ItemName is required")]
        public string ItemName { get; set; }
    }
}
