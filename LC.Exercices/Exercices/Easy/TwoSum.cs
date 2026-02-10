namespace LC.Exercices.Exercices.Easy;

public static class TwoSum
{
    public static int[] Solution(int[] nums, int target)
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