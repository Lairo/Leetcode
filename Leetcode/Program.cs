namespace Leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsA = [2, 7, 11, 15];
            int numsATarget = 9;

            //expected [0,1]

            int[] numsB = [3, 2, 4];
            int numsBTarget = 6;

            //expected [1,2]

            int[] numsC = [3, 3];
            int numsCTarget = 6;

            Console.WriteLine($"\t {string.Join(", ", Q1TwoSum.TwoSum(numsA, numsATarget))} Target is {numsATarget}");
            Console.WriteLine($"\t {string.Join(", ", Q1TwoSum.TwoSum(numsB, numsBTarget))} Target is {numsBTarget}");
            Console.WriteLine($"\t {string.Join(", ", Q1TwoSum.TwoSum(numsC, numsCTarget))} Target is {numsCTarget}");            
        }
    }
}
