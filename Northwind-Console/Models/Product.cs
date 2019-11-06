using System;
using System.ComponentModel.DataAnnotations;

namespace NorthwindConsole.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required (ErrorMessage = "Please enter a product name.")]
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public Int16? UnitsInStock { get; set; }
        public Int16? UnitsOnOrder { get; set; }
        public Int16? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }

        public int? CategoryId { get; set; }
        public int? SupplierId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
