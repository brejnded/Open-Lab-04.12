using NUnitLite;
using System;
using System.Linq;

namespace Open_Lab_04._12
{
    public class Numbers
    {
        public int MissingNum(int[] nums)
        {
            int sum = nums.Sum();
            return 55 - sum;
        }
    }
}
