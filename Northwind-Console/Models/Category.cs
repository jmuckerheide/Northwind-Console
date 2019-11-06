using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NorthwindConsole.Models
{
    public class Category
    {
        [Key]
        [Required(ErrorMessage = "No ID")]
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "YO - Enter the name!")]
        public string CategoryName { get; set; }
        [Range(1, 100, ErrorMessage = "Please enter a description between 1 and 100 characters" )]
        public string Description { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
