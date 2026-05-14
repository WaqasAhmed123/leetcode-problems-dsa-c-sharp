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
            if (head == null || head.next == null)
            {
                return head;
            }

            ListNode current = head;
            ListNode updated_head = new ListNode(current.next.val);
            while (current.next != null)
            {
                updated_head.next = new ListNode(current.val);
                updated_head = updated_head.next;
                //updated_head.next = current.;
                //head = current.next;
                //updated_head.next = current;
                //head.next = current;
                current = current.next;

            }

            return updated_head;
        }
    }
}
