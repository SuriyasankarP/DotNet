using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace DB.Models
{
    public class list
    {
        [Key]
        public int ?Id { get; set; }

        [Required]
        public string ?Item { get; set; }

        [Required]
        public string ?Description { get; set; }
    }
}