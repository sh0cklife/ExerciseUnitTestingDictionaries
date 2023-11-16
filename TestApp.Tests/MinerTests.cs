using NUnit.Framework;

using System;
using System.Linq;

namespace TestApp.Tests;

public class MinerTests
{
    [Test]
    public void Test_Mine_WithEmptyInput_ShouldReturnEmptyString()
    {
        //Arrange
        string[] input = Array.Empty<string>();
        //Act
        string result = Miner.Mine(input);

        //Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_Mine_WithMixedCaseResources_ShouldBeCaseInsensitive()
    {
        //Arrange
        string[] input = new string[] { "Gold 8", "Silver 30" };
        //Act
        string result = Miner.Mine(input);

        //Assert
        Assert.That(result, Is.EqualTo($"gold -> 8{Environment.NewLine}silver -> 30"));
    }

    [Test]
    public void Test_Mine_WithDifferentResources_ShouldReturnResourceCounts()
    {
        //Arrange
        string[] input = new string[] { "Gold 8", "Silver 30", "Copper 100", "golD 10", "silVer 20" };
        //Act
        string result = Miner.Mine(input);

        //Assert
        Assert.That(result, Is.EqualTo($"gold -> 18{Environment.NewLine}silver -> 50{Environment.NewLine}copper -> 100"));
    }
    [Test]
    public void Test_Mine_WithSingleResource_ShouldReturnSingleResourceCount()
    {
        // Arrange
        string[] input = new string[] { "Gold 5" };
        // Act
        string result = Miner.Mine(input);
        // Assert
        Assert.That(result, Is.EqualTo("gold -> 5"));
    }
    [Test]
    public void Test_Mine_WithSameResourceMultipleTimes_ShouldAggregateCounts()
    {
        // Arrange
        string[] input = new string[] { "Gold 5", "Gold 3", "Gold 2", "gold 10" };
        // Act
        string result = Miner.Mine(input);
        // Assert
        Assert.That(result, Is.EqualTo("gold -> 20"));
    }
    [Test]
    public void Test_Mine_WithNegativeResourceCount_ShouldIgnoreNegativeCounts()
    {
        // Arrange
        string[] input = new string[] { "Gold -5", "Silver 10", "Copper -3" };
        // Act
        string result = Miner.Mine(input);
        // Assert
        Assert.That(result, Is.EqualTo("gold -> -5\r\nsilver -> 10\r\ncopper -> -3"));
    }
    [Test]
    public void Test_Mine_WithSingleResourceMixed_ShouldReturnSingleResourceCount()
    {
        // Arrange
        string[] input = new string[] { "GoLD 5" };
        // Act
        string result = Miner.Mine(input);
        // Assert
        Assert.That(result, Is.EqualTo("gold -> 5"));
    }
    [Test]
    public void Test_Mine_WithSingleResourceNegative_ShouldReturnSingleResourceCount()
    {
        // Arrange
        string[] input = new string[] { "GoLD -555" };
        // Act
        string result = Miner.Mine(input);
        // Assert
        Assert.That(result, Is.EqualTo("gold -> -555"));
    }
    [Test]
    public void Test_Mine_WithSingleIntNegative_ShouldReturnSingleResourceCount()
    {
        // Arrange
        string[] input = new string[] { "G 5" };
        // Act
        string result = Miner.Mine(input);
        // Assert
        Assert.That(result, Is.EqualTo("g -> 5"));
    }


}
