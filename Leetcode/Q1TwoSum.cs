using System.Diagnostics;

namespace Leetcode
{
    internal class Q1TwoSum
    {
        //int[] numsA = [2, 7, 11, 15];
        //int numsATarget = 9;

        ////expected [0,1]

        //int[] numsB = [3, 2, 4];
        //int numsBTarget = 6;

        ////expected [1,2]

        //int[] numsC = [3, 3];
        //int numsCTarget = 6;

        ////expected [0,1]

        //int[] numsD = [1, 3, 4, 2];
        //int numsDTarget = 6;

        ////expected [2,3]

        //Console.WriteLine($"\t {string.Join(", ", Q1TwoSum.TwoSum(numsA, numsATarget))} Target is {numsATarget}");
        //Console.WriteLine($"\t {string.Join(", ", Q1TwoSum.TwoSum(numsB, numsBTarget))} Target is {numsBTarget}");
        //Console.WriteLine($"\t {string.Join(", ", Q1TwoSum.TwoSum(numsC, numsCTarget))} Target is {numsCTarget}");            
        //Console.WriteLine($"\t {string.Join(", ", Q1TwoSum.TwoSum(numsD, numsDTarget))} Target is {numsDTarget}"); 

        // Runtime 52ms (slow) beats 12%
        // Memory 47.88 (amazing) beats 98.71%

        public static int[] TwoSum(int[] nums, int target)
        {
            int a = 0;
            int b = nums[a];
            int c = 0;
            int d = 0;

            int[] result = new int[2];

            while (d == 0)
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    if(i == a)
                        i++;
                    
                    if (nums[i] + b == target)
                    {
                        c = a;
                        d = i;
                    }
                }
                if (d == 0 && c == 0)
                {
                    a = a + 1;
                    b = nums[a];
                }
            }
            result[0] = c;
            result[1] = d;
            return result;
        }


    }

}




