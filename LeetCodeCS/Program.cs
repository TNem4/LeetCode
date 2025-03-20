// 01
int[] TwoSum(int[] nums, int target)
{
    for (int k = 0; k < nums.Length; k++)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[k] + nums[i] == target)
            {
                return new int[] { k, i };
            }
        }
    }
    return null;
}