using BenchmarkDotNet.Attributes;

namespace LC.Exercices.Exercices.Medium;

[MemoryDiagnoser]
public class AddTwoNumbers
{
    public class ListNode(int val = 0, ListNode? next = null)
    {
        public int Value { get; set; } = val;
        public ListNode? Next { get; set; } = next;
    }

    [Benchmark]
    [BenchmarkCategory("Medium")]
    public void SolutionBenchmark()
    {
        var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        Solution(l1, l2);
    }

    public ListNode? Solution(ListNode? l1, ListNode? l2, int carry = 0)
    {
        if (l1 == null && l2 == null && carry == 0) 
            return null;

        var val1 = l1 != null ? l1.Value : 0;
        var val2 = l2 != null ? l2.Value : 0;
        var total = val1 + val2 + carry;

        carry = total / 10;
        return new ListNode(total % 10, Solution(l1?.Next, l2?.Next, carry));
    }
}