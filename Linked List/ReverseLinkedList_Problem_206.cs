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
            ListNode? next = null;
            ListNode? prev = null;
            ListNode? untouchedNext = null;
            bool isFirst = false;
            while (current.next != null)
            {
                prev = current; // 1
                next = current.next; // 2
                next.next = prev;
                current = current.next; // 2
                //current.next = prev; //1

                if (!isFirst)
                {
                    prev.next = null;
                    isFirst = true;
                }
            }

            return current;
        }
    }
}
