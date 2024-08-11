using System.Collections.Generic;

namespace longest_consecutive_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 100, 4, 200, 1, 3, 2 };
            LongestConsecutive(nums);
        }

        public static int LongestConsecutive(int[] nums)
        {
            if (nums.Length <2 ) return nums.Length;
            var set = new HashSet<int>(nums);
            int longest = 0;

            foreach (int item in set) 
            {
                if(!set.Contains(item-1))
                {
                    int len = 0; 
                    while(set.Contains(item+len))
                    {
                        len++;
                        longest = Math.Max(longest, len);
                    }
                }
            }
            return longest;

        }
    }
}
