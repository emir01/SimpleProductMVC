using System.ComponentModel.DataAnnotations;

namespace ProductApplication.ViewModels
{
    public class ProductEditViewModel
    {
        public int? Id { get; set; }

        [Required]
        [MinLength(5)]
        public string Name { get; set; }
        
        [Required]
        public string Category { get; set; }

        public string Description { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}