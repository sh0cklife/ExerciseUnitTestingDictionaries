using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.Tests;

public class GroupingTests
{
    // TODO: finish test
    [Test]
    public void Test_GroupNumbers_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<int> list = new();
        // Act
        string result = Grouping.GroupNumbers(list);
        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GroupNumbers_WithEvenAndOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new() { 1, 2, 3, 4 };
        // Act
        string result = Grouping.GroupNumbers(list);
        // Assert
        Assert.That(result, Is.EqualTo("Odd numbers: 1, 3\r\nEven numbers: 2, 4"));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new() { 2, 4, 6, 8 };
        // Act
        string result = Grouping.GroupNumbers(list);
        // Assert
        Assert.That(result, Is.EqualTo("Even numbers: 2, 4, 6, 8"));

    }

    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new() { 1, 3, 5, 7 };
        // Act
        string result = Grouping.GroupNumbers(list);
        // Assert
        Assert.That(result, Is.EqualTo("Odd numbers: 1, 3, 5, 7"));

    }

    [Test]
    public void Test_GroupNumbers_WithNegativeOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new() { -1, -3, -5, -7 };
        // Act
        string result = Grouping.GroupNumbers(list);
        // Assert
        Assert.That(result, Is.EqualTo("Odd numbers: -1, -3, -5, -7"));
    }
    [Test]
    public void Test_GroupNumbers_WithNegativeEvenNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new() { -2, -4, -6, -8 };
        // Act
        string result = Grouping.GroupNumbers(list);
        // Assert
        Assert.That(result, Is.EqualTo("Even numbers: -2, -4, -6, -8"));
    }
    [Test]
    public void Test_GroupNumbers_WithZero_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new() { 0 };
        // Act
        string result = Grouping.GroupNumbers(list);
        // Assert
        Assert.That(result, Is.EqualTo("Even numbers: 0"));
    }
    [Test]
    public void Test_GroupNumbers_WithOnlyLargeOddNumbers_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new() { 13333, 13335, 13337, 133337 };
        // Act
        string result = Grouping.GroupNumbers(list);
        // Assert
        Assert.That(result, Is.EqualTo("Odd numbers: 13333, 13335, 13337, 133337"));

    }
    [Test]
    public void Test_GroupNumbers_WithOnlyOddNumber_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new() { 3 };
        // Act
        string result = Grouping.GroupNumbers(list);
        // Assert
        Assert.That(result, Is.EqualTo("Odd numbers: 3"));
    }
    [Test]
    public void Test_GroupNumbers_WithOnlyEvenNumber_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new() { 2 };
        // Act
        string result = Grouping.GroupNumbers(list);
        // Assert
        Assert.That(result, Is.EqualTo("Even numbers: 2"));

    }
    [Test]
    public void Test_GroupNumbers_WithOneEvenOneOddNumber_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new() { 2, 3 };
        // Act
        string result = Grouping.GroupNumbers(list);
        // Assert
        Assert.That(result, Is.EqualTo("Even numbers: 2\r\nOdd numbers: 3"));

    }
    [Test]
    public void Test_GroupNumbers_WithOneEvenOneOddAndZeroNumber_ShouldReturnGroupedString()
    {
        // Arrange
        List<int> list = new() { 0, 2, 3 };
        // Act
        string result = Grouping.GroupNumbers(list);
        // Assert
        Assert.That(result, Is.EqualTo("Even numbers: 0, 2\r\nOdd numbers: 3"));
    }
}
