using LeetCode.Linked_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Linked_List
{
    public class RemoveLinkedListElements_Problem_203
    {
        public ListNode RemoveElements(ListNode head, int val)
        {

            ListNode dummy  = new ListNode(0);
            dummy.next = head;
            
            ListNode current = dummy;
            
            while(current.next != null)
            {
                if (current.next.val == val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }
            return dummy.next;
        }

    }
}
