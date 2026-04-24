using LeetCode.Linked_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Linked_List
{
    public class RemoveDuplicatesfromSortedListProblem_83
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return null;
            HashSet<int> visited = new HashSet<int>();
            ListNode current = head;
            visited.Add(current.val);
            while (current.next != null)
            {
                if (visited.Contains(current.next.val))
                {
                    current.next = current.next.next;
                }
                else
                {
                    visited.Add(current.next.val);
                    current = current.next;
                }
            }
            return head;
        }

    }
}
