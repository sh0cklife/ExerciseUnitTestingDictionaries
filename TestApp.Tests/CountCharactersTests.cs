using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Text;

namespace TestApp.Tests;

public class CountCharactersTests
{
    [Test]
    public void Test_Count_WithEmptyList_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Count_WithNoCharacters_ShouldReturnEmptyString()
    {
        // Arrange
        List<string> input = new() { "", "", "" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleCharacter_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "d" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("d -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "de", "dde", "dddd" };

        StringBuilder sb = new();
        sb.AppendLine("d -> 7");
        sb.AppendLine("e -> 2");
        string expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Count_WithSpecialCharacters_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "@", "@@", "ddd@" };

        StringBuilder sb = new();
        sb.AppendLine("@ -> 4");
        sb.AppendLine("d -> 3");
        string expected = sb.ToString().Trim();

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
    [Test]
    public void Test_Count_WithSingleCharacterUpperCase_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "D", "DD", "DDD" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("D -> 6"));
    }
    [Test]
    public void Test_Count_WithSingleCharacterNumber_ShouldReturnCountString()
    {
        // Arrange
        List<string> input = new() { "1", "11", "111" };

        // Act
        string result = CountCharacters.Count(input);

        // Assert
        Assert.That(result, Is.EqualTo("1 -> 6"));
    }
}
