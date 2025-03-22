using System;

namespace Project.Chasing.Rain.Domain.Catalog
{
    // Represents an item in the catalog
    public class Item
    {
        // Unique identifier for the item
        public int Id { get; set; }

        // Name of the item
        public string? Name { get; set; }

        // Description of the item
        public string? Description { get; set; }

        // Brand of the item
        public string? Brand { get; set; }

        // Price of the item
        public decimal Price { get; set; }

        // List of ratings associated with the item
        public List<Rating>? Ratings { get; set; } = new List<Rating>();

        // Adds a rating to the item
        public void AddRating(Rating rating)
        {
            this.Ratings.Add(rating);
        }

        // Constructor to initialize an item with required properties
        public Item(string name, string description, string brand, decimal price)
        {
            // Validate that the name is not null or empty
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(name);
            }

            // Validate that the description is not null or empty
            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentNullException(description);
            }

            // Validate that the brand is not null or empty
            if (string.IsNullOrEmpty(brand))
            {
                throw new ArgumentNullException(brand);
            }

            // Validate that the price is greater than or equal to zero
            if (price < 0.00m)
            {
                throw new ArgumentException("Price must be greater than zero.");
            }

            // Assign values to properties
            this.Name = name;
            this.Description = description;
            this.Brand = brand;
            this.Price = price;
            this.Ratings = new List<Rating>();
        }
    }
}