namespace Algorithms.TwoPointer;

class Solution {
    public static ListNode RemoveNthLastNode(ListNode head, int n) {
        ListNode right = head;
        ListNode left = head;

        for (int i = 0; i < n; i++) {
            right = right.next;
        }

        if (right == null) {
            return head.next;
        }

        while (right.next != null) {
            right = right.next;
            left = left.next;
        }

        left.next = left.next.next;

        return head;
    }

    // Driver Code
    public static void Main(string[] args) {
        List<List<int>> inputs = new List<List<int>>()
        {
            new List<int> { 23, 89, 10, 5, 67, 39, 70, 28 },
            new List<int> { 34, 53, 6, 95, 38, 28, 17, 63, 16, 76 },
            new List<int> { 288, 224, 275, 390, 4, 383, 330, 60, 193 },
            new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
            new List<int> { 69, 8, 49, 106, 116, 112, 104, 129, 39, 14, 27, 12 }
        };

        int[] n = { 4, 1, 6, 9, 11 };

        for (int i = 0; i < inputs.Count; i++)
        {
            Console.Write(i + 1);
            
            LinkedList inputLinkedList = new LinkedList(inputs[i], new ListNode(inputs[i][0]));
            Console.Write(".\tOriginal linked list: ");
            PrintList.Display(inputLinkedList.head);
            Console.WriteLine("\tk: " + n[i]);
            Console.Write("\n\tUpdated linked list: ");
            PrintList.Display(RemoveNthLastNode(inputLinkedList.head, n[i]));
            Console.WriteLine(new string('-', 100));
        }
    }
}