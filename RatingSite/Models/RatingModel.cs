using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace RatingSite.Models
{
	public class RatingModel 
	{
        [Key]
        public int RatingID { get; set; }

        public int RecipeID { get; set; }

        public int UserID { get; set; }

        [Required]
        public required long Rating { get; set; }

        /* 
         -- Create the Ratings table
            CREATE TABLE Ratings (
                * RatingID INT PRIMARY KEY IDENTITY(1,1),
                * RecipeID INT NOT NULL, -- Foreign key to Recipes table
                * UserID INT NOT NULL,   -- Foreign key to Users table
                - Rating INT NOT NULL,
                CONSTRAINT FK_Ratings_Recipes FOREIGN KEY (RecipeID) REFERENCES Recipes(RecipeID),
                CONSTRAINT FK_Ratings_Users FOREIGN KEY (UserID) REFERENCES Users(UserID)
            );
         */
    }
}

