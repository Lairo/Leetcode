namespace Leetcode
{
    internal class Q1TwoSum
    {
        //int[] numsA = [2, 7, 11, 15];
        //int numATarget = 9;

        ////expected [0,1]

        //int[] numsB = [3, 2, 4];
        //int numBTarget = 6;

        ////expected [1,2]

        //int[] numsC = [3, 3];
        //int numCTarget = 6;

        ////expected [0,1]

        // grab first digit in the array
        // scan the array from the following digit add the next digit to the first
        // if the addition sum equates to the target stop the scan
        // store the two digits' array addresses as digits into a new third array
        // return that array
        // if the sum does not equate with any member from that array to the target, continue to the following member in the array and continue the scan 
        //from there on out

        public static int[] TwoSum(int[] nums, int target)
        {
            int a = nums[0];
            int[] result = new int[2];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] + a == target)
                {
                    result[0] = a;
                    result[1] = nums[i];
                }
                return result;
            }
            return result;


        }

    }
}



