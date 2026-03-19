using LeetCode.Linked_List;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Linked_List
{
    public class Remove_Duplicates_from_Sorted_List_Problem_83
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            HashSet<int> visited = new HashSet<int>();
            visited.Add(head.val);
            ListNode current = head;
            while (current.next != null)
            {
                if (visited.Contains(current.next.val))
                {

                    while (visited.Contains(current.next.val))
                    //while (current.next.next != null && !visited.Contains(current.next.next.val))
                    {
                        if (!visited.Contains(current.next.val))
                        {
                            current = current.next;
                            Console.WriteLine("the result is {0}", current.val);
                        }
                        //current.next = current.next.next;
                    }
                    //if (visited.Contains(current.next.val))
                    //{
                    //    current.next = current.next.next;
                    //}
                }
                else { visited.Add(current.next.val); }
                Console.WriteLine("the result is {0}", current.val);
                current = current.next;
            }
            if (visited.Contains(current.val))
            {
                current.next = null;
            }
            Console.WriteLine("the result is {0}", current.val);
            return current;

        }

    }
}
