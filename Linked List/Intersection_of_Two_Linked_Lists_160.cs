using LeetCode.Linked_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Linked_List
{
    public class Intersection_of_Two_Linked_Lists_160
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            HashSet<ListNode> visited = new HashSet<ListNode>();
            ListNode currentA = headA;
            while (currentA != null)
            {
                visited.Add(currentA);
                currentA = currentA.next;
            }
            ListNode currentB = headB;
            while (currentB != null)
            {
                if (visited.Contains(currentB))
                {
                    return currentB;
                }
                currentB = currentB.next;
            }
            return null;
        }
    }
}
