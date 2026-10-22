using Grades;

namespace Grades.Tests;

public class GradeCalculatorTests
{
    [Theory]
    [InlineData(100, 5)]
    [InlineData(90, 5)]
    [InlineData(89, 4)]
    [InlineData(75, 4)]
    [InlineData(74, 3)]
    [InlineData(60, 3)]
    [InlineData(59, 2)]
    [InlineData(0, 2)]
    public void ToGrade_ReturnsExpectedGrade(int points, int expected)
    {
        Assert.Equal(expected, GradeCalculator.ToGrade(points));
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(101)]
    public void ToGrade_Throws_WhenPointsOutOfRange(int points)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => GradeCalculator.ToGrade(points));
    }

    [Fact]
    public void Average_KeepsFractionalPart()
    {
        Assert.Equal(82.5, GradeCalculator.Average(new[] { 80, 85 }));
    }

    [Fact]
    public void Average_ReturnsZero_ForEmptyList()
    {
        Assert.Equal(0, GradeCalculator.Average(Array.Empty<int>()));
    }
}
