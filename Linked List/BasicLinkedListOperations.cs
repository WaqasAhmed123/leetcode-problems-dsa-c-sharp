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
            while (current.next != null)
            {
                Console.WriteLine("the result is {0}", current.val);
                current = current.next;
            }
            ListNode newNode = new ListNode(valueToAdd);
            current.next = newNode;
            Console.WriteLine("the result is {0}", current.val);
        }

        public void DeleteAtLast(ListNode head)
        {
            var current = head;
            while (current.next.next != null)
            {
                Console.WriteLine("the result is {0}", current.val);
                current = current.next;
            }
            current.next = null;
            Console.WriteLine("the result is {0}", current.val);
        }
    }
}
