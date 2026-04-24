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
            ListNode current = head;
            if (current == null)
                return head;
            else if (current.val == val)
            {
                head = current.next;
                current = head;
            }
            else
            {
                while (current.next != null)
                {
                    if (current.next.val == val && current.next.next.val != null && current.next.next.val != val )
                    {
                        current.next = current.next.next;
                    }
                    else
                    {
                        current = current.next;
                    }
                }
            }
            return head;
        }
    
    }
}
