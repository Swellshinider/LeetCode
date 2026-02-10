using BenchmarkDotNet.Attributes;

namespace LC.Exercices.Exercices.Easy;

[MemoryDiagnoser]
public class TwoSum
{
    [Benchmark]
    [BenchmarkCategory("Easy")]
    [Arguments(new int[] { 2, 7, 11, 15 }, 9)]
    [Arguments(new int[] { 3, 2, 4 }, 6)]
    [Arguments(new int[] { 3, 3 }, 6)]
    public int[] Solution(int[] nums, int target)
    {
        var hashMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (hashMap.TryGetValue(target - nums[i], out int value))
                return [value, i];
            hashMap[nums[i]] = i;
        }

        return [];
    }
}