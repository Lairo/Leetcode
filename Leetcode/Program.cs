namespace Leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsA = [2, 7, 11, 15];
            int numATarget = 9;

            //expected [0,1]

            int[] numsB = [3, 2, 4];
            int numBTarget = 6;

            //expected [1,2]

            int[] numsC = [3, 3];
            int numCTarget = 6;

            Console.WriteLine((Q1TwoSum.TwoSum(numsA, numATarget)));
            Console.WriteLine((Q1TwoSum.TwoSum(numsB, numBTarget)));
            Console.WriteLine((Q1TwoSum.TwoSum(numsC, numCTarget)));
        }
    }
}
