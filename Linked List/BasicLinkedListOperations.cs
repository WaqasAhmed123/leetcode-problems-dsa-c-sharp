using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Linked_List
{
    public class BasicLinkedListOperations
    {
        public void Traverse(ListNode head)
        {
            var current = head;
            while (current != null)
            {
                Console.WriteLine("the result is {0}", current.val);
                current = current.next;
            }
        }

        public void AddAtLast(ListNode head, int valueToAdd)
        {
            var current = head;
            while (current != null)
            {
                Console.WriteLine("the result is {0}", current.val);
                current = current.next;
            }
            current = new ListNode(valueToAdd);
            Console.WriteLine("the result is {0}", current.val);
        }
    }
}
