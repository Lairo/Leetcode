
namespace Leetcode
{
    internal class Q2AddTwoNumbers
    {
        //int[] al1 = [2, 4, 3];
        //int[] al2 = [5, 6, 4];

        //// expected  [7,0,8]
        //// explanation 342 + 465 = 807

        //int[] bl1 = [0];
        //int[] bl2 = [0];

        //// expected [0]

        //int[] cl1 = [9, 9, 9, 9, 9, 9, 9];
        //int[] cl2 = [9, 9, 9, 9];

        //// expected [8,9,9,9,0,0,0,1]

        // reverse each array
        // concatenate each member in each array to produce a single digit from each array
        // add two new integers
        // break the new integer and store it in a new array (each digit as a separate member inside the array )
        // return the new list

        



        public static int[] Solution(int[] list1, int[] list2)
        {
            int[] result = [1];
            string temp1 = "";
            string temp2 = "";

            while(l1 != null)
            {
                temp1 = l1.val.ToString();

            }



            int x = Extracting(list1) + Extracting(list2);
            int reverse = 0;
            int[] z = [x.ToString().Count()+1];

            while(x > 0)
            {
                int i = 0;
                int remainder = x % 10;
                z[i] = remainder;
                reverse = (reverse * 10) + remainder;
                x = x / 10;
            }
            Console.WriteLine(reverse);            

            return z;
        }

        public static int Extracting(int[] e)
        {
            string a = "";
            foreach (var _ in e)
            {
                a += _.ToString();
            }

            if(int.TryParse(a, out int digit))
            {
            return digit;

            }

            return 0;            

        }
    }

    public class ListNode()
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
            
        }
    }
}
