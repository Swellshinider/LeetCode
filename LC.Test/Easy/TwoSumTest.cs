using LC.Exercices.Exercices.Easy;

namespace LC.Test.Easy;

public class TwoSumTest
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void TwoSum_Should_ReturnCorrentValue(int[] nums, int target, int[] result)
    {
        var res = TwoSum.Solution(nums, target);
        Assert.Equal(result, res);
    }

    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 1, new int[] { })]
    public void TwoSum_Should_ReturnEmptyArray(int[] nums, int target, int[] result)
    {
        var res = TwoSum.Solution(nums, target);

        Assert.Empty(res);
        Assert.Equal(result, res);
    }
}