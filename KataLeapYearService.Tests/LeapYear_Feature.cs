using Xunit;

namespace KataLeapYearService.Tests;

public class LeapYear_Feature
{
    [Fact]
    public void DoNoting()
    {
        Assert.False(false);
    }

    [Fact]
    public void Year2022ShouldReturnFalse()
    {
        Assert.False(new LeapYear().IsLeap(2022));
    }

    [Fact]
    public void ALeapYearShouldBeDividedBy4()
    {
        Assert.True(new LeapYear().IsLeap(4));
    }

    [Fact]
    public void ALeapYearShouldNotBeDividedBy100()
    {
        Assert.False(new LeapYear().IsLeap(100));
    }

    [Fact]
    public void ALeapYearShouldBeDividedBy100AndBy400()
    {
        Assert.True(new LeapYear().IsLeap(400));
    }

    [Theory]
    [InlineData(2020)]
    [InlineData(2024)]
    [InlineData(2096)]
    [InlineData(2004)]
    public void ALeapYearShouldBeReturnTrue(int annee)
    {
        Assert.True(new LeapYear().IsLeap(annee));
    }

    [Theory]
    [InlineData(2021)]
    [InlineData(2025)]
    [InlineData(1985)]
    [InlineData(1721)]
    public void ANotLeapYearShouldBeReturnFalse(int annee)
    {
        Assert.False(new LeapYear().IsLeap(annee));
    }

}