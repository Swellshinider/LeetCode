using LC.Exercices.Exercices.Medium;
using static LC.Exercices.Exercices.Medium.AddTwoNumbers;

namespace LC.Test.Medium;

public class AddTwoNumbersTest
{
    [Fact]
    public void Test()
    {
        var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
        var expected = new ListNode(7, new ListNode(0, new ListNode(8)));
        var result = new AddTwoNumbers().Solution(l1, l2);
        AssertListNodesEqual(expected, result);
    }

    private static void AssertListNodesEqual(ListNode? expected, ListNode? result)
    {
        while (expected != null && result != null)
        {
            Assert.Equal(expected.Value, result.Value);
            expected = expected.Next;
            result = result.Next;
        }
        Assert.Null(expected);
        Assert.Null(result);
    }
}
