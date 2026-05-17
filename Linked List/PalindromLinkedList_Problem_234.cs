
namespace LeetCode.Linked_List
{
    public class PalindromLinkedList_Problem_234
    {
        public bool IsPalindrome(ListNode head)
        {

            if (head == null || head.next == null)
            {
                return true;
            }

            ListNode fast = head;
            ListNode slow = head;
            while (fast !=null &&  fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            ListNode prev = null;
            
            while (slow!= null)
            {
                ListNode next = slow.next;
                slow.next = prev;
                prev = slow;
                slow = next;
            }

            // Compare both halves
            ListNode first = head;
            ListNode second = prev;

            while (second != null)
            {
                if (first.val != second.val)
                {
                    return false;
                }

                first = first.next;
                second = second.next;
            }

            return true;

            // below is the brute force approach which is not optimal as it uses extra space for storing the values of the nodes in two lists and then comparing them.
            //if (head.next == null)
            //{
            //    return true;
            //}

            //List<int> forwardList = new List<int>();
            //List<int> backwardList = new List<int>();
            //ListNode current = head;
            //ListNode prev = null;
            //while (current != null)
            //{
            //    ListNode next = current.next;
            //    current.next = prev;
            //    forwardList.Add(current.val);
            //    prev = current;
            //    backwardList.Insert(0, prev.val);
            //    current = next;

            //}

            //return forwardList.SequenceEqual(backwardList);

        }
    }
}
