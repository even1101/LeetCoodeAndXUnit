using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLeetCode
{
    public class EasyService
    {
        #region 1 Two Sum
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dicMap = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int left = target - nums[i];

                if (dicMap.ContainsKey(left))
                {
                    return new int[] { dicMap[left], i };
                }
                dicMap.Add(nums[i], i);
                //if (!dicMap.ContainsKey(nums[i]))
                //{

                //}
            }
            return null;
        }

        #endregion
        #region 7 Reverse Integer
        public int ReverseInteger(int x)
        {
            var res = 0;
            while (x != 0) {
                var v = x % 10;
                var temp = res * 10 + v;
                if ((temp - v) / 10 != res) {
                    return 0;
                }
                res = temp;
                x /= 10;
            }
            return res;
        }
        #endregion
    }
}
