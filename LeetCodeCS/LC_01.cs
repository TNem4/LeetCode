using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCS
{
    internal class LC_01
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int newTarget = target - nums[i];
                if (dict.ContainsKey(newTarget))
                {
                    return new int[] { dict[newTarget], i };
                }
                dict[nums[i]] = i;
            }
            return null;
        }
    }
}
