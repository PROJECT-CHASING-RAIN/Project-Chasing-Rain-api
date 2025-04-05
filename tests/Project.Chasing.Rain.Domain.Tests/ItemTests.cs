﻿using Project.Chasing.Rain.Domain.Catalog;

namespace Project.Chasing.Rain.Domain.Tests;


[TestClass]
public sealed class ItemTests
{
    [TestMethod]
    public void Can_Create_New_Item()
    {
        // Arrange
        var item = new Item("Name", "Description", "Brand", 10.00m);

        // Act

        // Assert
        Assert.AreEqual("Name", item.Name);
        Assert.AreEqual("Description", item.Description);
        Assert.AreEqual("Brand", item.Brand);
        Assert.AreEqual(10.00m, item.Price);
    }

    [TestMethod]
    public void Can_Create_Add_Rating()
    {
        // Arrange
        var item = new Item("Name", "Description", "Brand", 10.00m);
        var rating = new Rating(5, "Name", "Review");
        
        // Act
        item.AddRating(rating);

        // Assert
        Assert.AreEqual(rating, item.Ratings[0]);
    }
}
