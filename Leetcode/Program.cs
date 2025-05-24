namespace Leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] al1 = [2, 4, 3];
            int[] al2 = [5, 6, 4];

            string solveA = "[7,0,8]";
            // expected [7,0,8]
            // explanation 342 + 465 = 807

            int[] bl1 = [0];
            int[] bl2 = [0];

            string solveB = "[0]";
            // expected [0]

            int[] cl1 = [9, 9, 9, 9, 9, 9, 9];
            int[] cl2 = [9, 9, 9, 9];

            string solveC = "[8, 9, 9, 9, 0, 0, 0, 1]";
            // expected [8,9,9,9,0,0,0,1]

            //expected [2,3]

            Console.WriteLine($"\t {string.Join(", ", Q2AddTwoNumbers.Solution(al1, al2))} Expected Solution {solveA}");
            Console.WriteLine($"\t {string.Join(", ", Q2AddTwoNumbers.Solution(bl1, bl2))} Expected Solution {solveB}");
            Console.WriteLine($"\t {string.Join(", ", Q2AddTwoNumbers.Solution(cl2, cl2))} Expected Solution {solveC}");
        }
    }
}
