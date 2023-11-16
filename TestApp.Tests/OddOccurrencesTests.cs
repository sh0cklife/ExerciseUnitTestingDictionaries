using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        string[] input = Array.Empty<string>();
        string result = OddOccurrences.FindOdd(input);
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new string[] { "Denis", "Denis" };
        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        // Arrange
        string[] input = new string[] { "Denis" };
        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo("denis"));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        // Arrange
        string[] input = new string[] { "Denis", "Denis", "Denis" };
        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo("denis"));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[] { "DeniS", "DEnis", "DeNis" };
        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo("denis"));
    }
    [Test]
    public void Test_FindOdd_WithUpperCaseWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[] { "DENIS", "DENIS", "DENIS" };
        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo("denis"));
    }
    [Test]
    public void Test_FindOdd_WithUpperCaseDifferentWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[] { "DENIS", "DENIS", "DENIS", "SOFT", "UNI" };
        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo("denis soft uni"));
    }
        [Test]
    public void Test_FindOdd_WithLowerMultiCaseWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[] { "denis", "denis", "denis" };
        // Act
        string result = OddOccurrences.FindOdd(input);

        // Assert
        Assert.That(result, Is.EqualTo("denis"));
    }
    [Test]
    public void Test_FindOdd_WithEvenOccurrences_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new string[] { "denis", "denis", "denis", "denis", "denis", "denis" };
        // Act
        string result = OddOccurrences.FindOdd(input);
        // Assert
        Assert.AreEqual(string.Empty, result);
    }
    [Test]
    public void Test_FindOdd_WithNumbers_ShouldReturnNumberWord()
    {
        // Arrange
        string[] input = new string[] { "denis", "denis", "denis", "denis", "denis", "denis", "1992" };
        // Act
        string result = OddOccurrences.FindOdd(input);
        // Assert
        Assert.AreEqual("1992", result);
    }
    [Test]
    public void Test_FindOdd_WithMixOfDifferentWordTypes_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[] { "word123", "denis", "!@#$%", "789" };
        // Act
        string result = OddOccurrences.FindOdd(input);
        // Assert
        Assert.That(result, Is.EqualTo("word123 denis !@#$% 789"));
    }
    [Test]
    public void Test_FindOdd_WithEmptyArray2_ShouldReturnEmptyString()
    {
        string[] input = Array.Empty<string>();
        string result = OddOccurrences.FindOdd(input);
        Assert.AreEqual(string.Empty, result);
    }
    [Test]
    public void Test_FindOdd_WithEmptyArray3_ShouldReturnEmptyString()
    {
        string[] input = Array.Empty<string>();
        string result = OddOccurrences.FindOdd(input);
        Assert.IsTrue(string.IsNullOrEmpty(result));
    }


}


