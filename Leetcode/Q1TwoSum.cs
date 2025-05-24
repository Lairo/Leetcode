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



        // grab first digit in the array
        // scan the array from the following digit add the next digit to the first
        // if the addition sum equates to the target stop the scan
        // store the two digits' array addresses as digits into a new third array
        // return that array
        // if the sum does not equate with any member from that array to the target, continue to the following member in the array and continue the scan 
        // from there on out

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
                    if (nums[i] + b == target)
                    {

                        c = a;

                        d = i;
                        Debug.WriteLine($"c is {c}");
                        Debug.WriteLine($"d is {d}");
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




