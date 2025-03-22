namespace Project.Chasing.Rain.Domain.Catalog
{
    // Represents a rating for an item in the catalog
    public class Rating
    {
        //Primary key for rating
        public int Id { get; set;}
        // Number of stars given in the rating (1 to 5)
        public int Stars { get; set; }

        // Name of the user who provided the rating
        public string UserName { get; set; }

        // Review text provided by the user
        public string Review { get; set; }

        // Constructor to initialize a rating with required properties
        public Rating(int stars, string userName, string review)
        {
            // Validate that the star rating is between 1 and 5
            if (stars < 1 || stars > 5)
            {
                throw new ArgumentException("Star rating must be an integer of: 1, 2, 3, 4, 5.");
            }

            // Validate that the user name is not null or empty
            if (string.IsNullOrEmpty(userName))
            {
                throw new ArgumentException("UserName cannot be null");
            }

            // Assign values to properties
            this.Stars = stars;
            this.UserName = userName;
            this.Review = review;
        }
    }
}