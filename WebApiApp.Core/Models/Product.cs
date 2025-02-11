using System.ComponentModel.DataAnnotations;

namespace WebApiApp.Models
{
    public class Product
    {
        public const int MAX_NAME_LENGTH = 100;
        private Product(Guid id, string name, string imgUri, decimal price, string description)
        {
            Id = id;
            Name = name;
            ImgUri = imgUri;
            Price = price;
            Description = description;
        }

        [Key]
        [Required]
        public Guid Id { get; }

        [Required]
        [MaxLength(100)]
        public string Name { get;}

        [Required]
        [Url]
        public string ImgUri { get; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get;}

        public string Description { get; }


        public static (Product Product, String error)  Create(string name, string imgUri, decimal price, string description)
        {
            var error = string.Empty;

            if (string.IsNullOrWhiteSpace(name) || name.Length > MAX_NAME_LENGTH )
            {
                error += "Name is required and must be less than 100 characters";

            }

            var product  = new Product(Guid.NewGuid(), name, imgUri, price, description);
            
            return (product, error);
        }
    }
}