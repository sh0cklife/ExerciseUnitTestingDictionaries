using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        string[] input = Array.Empty<string>();
        string output = Orders.Order(input);
        Assert.That(output, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = new string[] { "@==\\=" };
        // Act
        string result = Plants.GetFastestGrowing(plants);
        // Assert
        Assert.That(result, Is.EqualTo("Plants with 5 letters:\r\n@--\\-"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] plants = new string[] 
        {
            "@==\\=", 
            "*=\\=", 
            "-----="
        };
        // Act
        string result = Plants.GetFastestGrowing(plants);
        // Assert
        Assert.That(result, Is.EqualTo("Plants with 4 letters:\r\n*=\\=\r\n" +
                                             "Plants with 5 letters:\r\n@==\\=\r\n" +
                                                      "Plants with 6 letters:\r\n-----="));

    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] plants = new string[]
        {
            "rOse",
            "liLy",
            "Sunflower",
            "Orchid"
        };
        // Act
        string result = Plants.GetFastestGrowing(plants);
        // Assert
        Assert.That(result, Is.EqualTo("Plants with 4 letters:\r\nrOse\r\nliLy\r\n" +
                                             "Plants with 6 letters:\r\nOrchid\r\n" +
                                             "Plants with 9 letters:\r\nSunflower"));
    }
}
