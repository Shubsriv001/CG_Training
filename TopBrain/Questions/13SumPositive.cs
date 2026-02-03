using System;

class SumPositive
{
    public static void Main()
    {
        int []arr={1,2,3,4,5,6,-1,0,2,5};
    Console.WriteLine(SumPositive.SumPositiveNum(arr));

    }

    public static int SumPositiveNum(int[] nums)
    {
        int sum=0;
        for(int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
            {
                break;
            }
            else if (nums[i] > 0)
            {
                sum+=nums[i];
            }
            else if (nums[i] < 0)
            {
                continue;
            }
        }
        return sum;
    }
}