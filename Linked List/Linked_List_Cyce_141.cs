using LeetCode.Linked_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Linked_List
{
    public class Linked_List_Cyce_141
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null) return false;
            var current = head;
            HashSet<ListNode> nodesVisited = new HashSet<ListNode>();
            while (current.next != null)
            {
                if (nodesVisited.Contains(current.next))
                {
                    return true;
                }
                nodesVisited.Add(current.next);
                current = current.next;
            }
            return false;
        }
    }
}
