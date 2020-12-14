using System;
using System.Collections.Generic;
using System.Text;

namespace Params
{
    class Min
    {
        public int MinValue(params int[] nums)
        {
            if (nums.Length == 0)
            {
                Console.WriteLine("No nums");
                return 0;
            }

            int m = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] < m)
                {
                    m = nums[i];
                } 
            }
            return m;
        }
    }
}
