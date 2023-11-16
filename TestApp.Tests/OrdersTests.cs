using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        string[] input = Array.Empty<string>();
        string output = Orders.Order(input);
        Assert.That(output, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] 
        {
            "apple 5.97 1",
            "banana 3.75 1",
            "orange 1.98 1"
        };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 5.97{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 1.98"));
    }
    [Test]
    public void Test_Order_WithMultipleOrdersCount_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[]
        {
            "apple 1.99 3",
            "banana 0.75 5",
            "orange 0.99 2"
        };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 5.97{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 1.98"));
    }
    [Test]
    public void Test_Order_WithMultipleOrdersSplit_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[]
        {
            "apple 1.99 2",
            "banana 0.75 4",
            "orange 0.99 2",
            "apple 1.99 1",
            "banana 0.75 1"
        };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 5.97{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 1.98"));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[]
        {
            "apple 1.989999 3",
            "banana 0.7500 5",
            "orange 0.9899999 2"
        };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 5.97{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 1.98"));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[]
        {
            "apple 2.00 4.5",
            "banana 3.00 2.5",
            "orange 1.00 3.5"
        };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 9.00{Environment.NewLine}banana -> 7.50{Environment.NewLine}orange -> 3.50"));
    }
}
