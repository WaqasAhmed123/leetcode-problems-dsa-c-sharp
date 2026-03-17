using LeetCode.Linked_List;
using LeetCode.Matrix;

class Program
{
    static void Main(string[] args)
    {

        var solution = new MergeTwoSortedLists_Problem_21();
        // list1: 1 -> 2 -> 4
        ListNode l1_3 = new ListNode(4);
        ListNode l1_2 = new ListNode(2, l1_3);
        ListNode l1_1 = new ListNode(1, l1_2);

        // list2: 1 -> 3 -> 4
        ListNode l2_3 = new ListNode(4);
        ListNode l2_2 = new ListNode(3, l2_3);
        ListNode l2_1 = new ListNode(1, l2_2);

        ListNode result = solution.MergeTwoLists(l1_1, l2_1);

        //Console.WriteLine("the result is",string.Join(",", result));
        //Console.WriteLine("the result is {0}", result);
    }
}