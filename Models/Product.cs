using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Validation;

namespace WebApp.Models
{
    [PhraseAndPrice(Phrase = "Small", Price = "100")]
    public class Product
    {
        public long ProductId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        [Required(ErrorMessage = "Please enter a price")]
        [Range(1, 999999, ErrorMessage = "Please enter a positive price")]
        public decimal Price { get; set; }

        [PrimaryKey(ContextType = typeof(DataContext), DataType = typeof(Category))]
        public long CategoryId { get; set; }
        public Category Category { get; set; }

        [PrimaryKey(ContextType = typeof(DataContext), DataType = typeof(Category))]
        public long SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}
