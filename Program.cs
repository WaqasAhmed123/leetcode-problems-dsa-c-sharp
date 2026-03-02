using LeetCode.Matrix;

class Program
{
    static void Main(string[] args)
    {
        var solution = new LuckyNumber_Problem_1380();
        var result = solution.LuckyNumbers([[7, 8], [1, 2]]);

        Console.WriteLine("the result is",string.Join(",", result));
        Console.WriteLine("the result is {0}", result);
    }
}