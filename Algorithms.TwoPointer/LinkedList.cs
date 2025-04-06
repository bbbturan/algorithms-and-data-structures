namespace Algorithms.TwoPointer;

class LinkedList
{
    public ListNode head;

    // Default constructor
    public LinkedList(ListNode head)
    {
        this.head = head;
        head = null;
    }

    // Constructor to initialize from a list of values
    public LinkedList(List<int> values, ListNode head)
    {
        this.head = head;
        head = null;
        CreateLinkedList(values);
    }

    // Function to create a linked list from a list of values
    private void CreateLinkedList(List<int> values)
    {
        if (values.Count == 0)
        {
            head = null;
            return;
        }

        head = new ListNode(values[0]);
        ListNode current = head;
        for (int i = 1; i < values.Count; i++)
        {
            current.next = new ListNode(values[i]);
            current = current.next;
        }
    }
}

class PrintList{
    // Function to display the linked list
    public static void Display(ListNode head)
    {
        ListNode current = head;
        while (current != null)
        {
            Console.Write(current.val + " -> ");
            current = current.next;
        }
        Console.WriteLine("None");
    }
}