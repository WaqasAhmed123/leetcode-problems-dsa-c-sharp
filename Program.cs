using LeetCode.Linked_List;

class Program
{
    static void Main(string[] args)
    {

        var solution = new ReverseLinkedList_Problem_206();
        // list1: 1 -> 2 -> 4
        ListNode l1_5 = new ListNode(5, null);
        ListNode l1_4 = new ListNode(4, l1_5);
        ListNode l1_3 = new ListNode(3, l1_4);
        ListNode l1_2 = new ListNode(2, l1_3);
        ListNode l1_1 = new ListNode(1, l1_2);

        // list2: 1 -> 3 -> 4
        ListNode l2_5 = new ListNode(4);
        ListNode l2_4 = new ListNode(8, l2_5);
        ListNode l2_3 = new ListNode(1, l1_3);
        //ListNode l2_3 = new ListNode(1, l2_4);
        ListNode l2_2 = new ListNode(6, l2_3);
        ListNode l2_1 = new ListNode(5, l2_2);

        //create a cylce:
        //ListNode l2_1 = new ListNode(1);
        //ListNode l2_2 = new ListNode(3);
        //ListNode l2_3 = new ListNode(4);

        //// Step 2: Link them normally
        //l2_1.next = l2_2;
        //l2_2.next = l2_3;

        //// Step 3: Create the cycle
        //l2_3.next = l2_2;  // cycle here (node 4 points back to node 3)

        ListNode result = solution.ReverseList(l1_1);

        if (result != null)
        {
            Console.WriteLine("The updated list's head value is {0}", result.val);
        }
        else
        {
            Console.WriteLine("No intersection found.");
        }
    }
}