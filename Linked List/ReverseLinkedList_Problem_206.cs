using LeetCode.Linked_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Linked_List
{
    public class ReverseLinkedList_Problem_206
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode current = head;
            while (current != null)
            {
                ListNode nextTemp = current.next;
                current.next = prev;
                prev = current;
                current = nextTemp;
            }

            return prev;

            //second solution, not as efficient as the first one, but it works

            //if (head == null || head.next == null)
            //{
            //    return head;
            //}

            //ListNode current = head;
            //ListNode? reversedHead = new ListNode(current.val, null);
            //ListNode? prev = null;
            //while (current.next != null)
            //{
            //    prev = new ListNode(reversedHead.val, reversedHead.next);
            //    reversedHead = new ListNode(current.val, prev);
            //    current = current.next;

            //}
            //reversedHead = new ListNode(current.val, reversedHead);

            //return reversedHead;
        }
    }
}
