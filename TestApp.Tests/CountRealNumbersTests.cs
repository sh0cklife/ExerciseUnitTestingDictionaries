using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    // TODO: finish test
    [Test]
    public void Test_Count_WithEmptyArrayThree_ShouldReturnEmptyString()
    {
        // Arrange
        int[] input = Array.Empty<int>();
        // Act
        string result = CountRealNumbers.Count(input);
        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 5 };
        // Act
        string result = CountRealNumbers.Count(input);
        // Assert
        Assert.That(result, Is.EqualTo("5 -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 5, 5, 5 };
        // Act
        string result = CountRealNumbers.Count(input);
        // Assert
        Assert.That(result, Is.EqualTo("5 -> 3"));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { -5, -5, -5 };
        // Act
        string result = CountRealNumbers.Count(input);
        // Assert
        Assert.That(result, Is.EqualTo("-5 -> 3"));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 0 };
        // Act
        string result = CountRealNumbers.Count(input);
        // Assert
        Assert.That(result, Is.EqualTo("0 -> 1"));
    }
    [Test]
    public void Test_Count_WithMix_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { -1, 0, 1 };
        // Act
        string result = CountRealNumbers.Count(input);
        // Assert
        Assert.That(result, Is.EqualTo("-1 -> 1\r\n0 -> 1\r\n1 -> 1"));
    }
    [Test]
    public void Test_Count_WithMultipleZeros_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 0, 0, 0 };
        // Act
        string result = CountRealNumbers.Count(input);
        // Assert
        Assert.That(result, Is.EqualTo("0 -> 3"));
    }
    [Test]
    public void Test_Count_WithMultipleSameNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 1, 1, 1, 1, 1 };
        // Act
        string result = CountRealNumbers.Count(input);
        // Assert
        Assert.That(result, Is.EqualTo("1 -> 5"));
    }
    [Test]
    public void Test_Count_With_LargePositive_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { 1000000 };
        // Act
        string result = CountRealNumbers.Count(input);
        // Assert
        Assert.That(result, Is.EqualTo("1000000 -> 1"));
    }
    [Test]
    public void Test_Count_With_LargeNegative_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { -1000000 };
        // Act
        string result = CountRealNumbers.Count(input);
        // Assert
        Assert.That(result, Is.EqualTo("-1000000 -> 1"));
    }
    [Test]
    public void Test_Count_WithMixedNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] input = new int[] { -1, 0, 1, 2, 1, 3, 2, 1, 0, -1 };
        // Act
        string result = CountRealNumbers.Count(input);
        // Assert
        Assert.That(result, Is.EqualTo("-1 -> 2\r\n0 -> 2\r\n1 -> 3\r\n2 -> 2\r\n3 -> 1"));
    }
}
