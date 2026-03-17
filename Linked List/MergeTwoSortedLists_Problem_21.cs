using LeetCode.Linked_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Linked_List
{
    public class MergeTwoSortedLists_Problem_21
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode();
            ListNode current = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }

                current = current.next;

            }
            if (list1 != null)
            {
                current.next = list1;
            }
            else
            {
                current.next = list2;
            }

            return dummy.next;
        }

    }
}
