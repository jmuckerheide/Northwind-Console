using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NorthwindConsole.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        [Required (ErrorMessage = "Please enter a company name.")]
        public string CompanyName { get; set; }
        [Required(ErrorMessage = "Please enter a contact name.")]
        public string ContactName { get; set; }
        [StringLength(12, ErrorMessage = "Contact title must be less than 12 characters.")]
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        public virtual List<Product> Products { get; set; }
    }
}
