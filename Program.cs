using LeetCode.Linked_List;
using LeetCode.Matrix;

class Program
{
    static void Main(string[] args)
    {
        //var solution = new LuckyNumber_Problem_1380();
        //var result = solution.LuckyNumbers([[7, 8], [1, 2]]);

        var solution = new BasicLinkedListOperations();
        ListNode n4 = new ListNode(4); ListNode n3 = new ListNode(3, n4); ListNode n2 = new ListNode(2, n3); ListNode n1 = new ListNode(1, n2);
        //solution.AddAtLast(n1,5);
        solution.DeleteAtLast(n1);

        //Console.WriteLine("the result is",string.Join(",", result));
        //Console.WriteLine("the result is {0}", result);
    }
}