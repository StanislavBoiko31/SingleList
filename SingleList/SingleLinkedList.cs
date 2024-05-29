namespace SingleList;

public class SingleLinkedList
{
    private Node? head;

    public SingleLinkedList()
    {
        head = null;
    }

    public Node? FindFirstGreaterThan(int value)
    {
        Node? current = head;
        while (current != null)
        {
            if (current.Data > value)
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }

    public Node? GetHead()
    {
        return head;
    }

    public int SumOfElementsLessThan(int value)
    {
        int sum = 0;
        Node? current = head;
        while (current != null)
        {
            if (current.Data < value)
            {
                sum += current.Data;
            }
            current = current.Next;
        }
        return sum;
    }

    public SingleLinkedList GetListOfElementsGreaterThan(int value)
    {
        SingleLinkedList newList = new SingleLinkedList();
        Node? current = head;
        while (current != null)
        {
            if (current.Data > value)
            {
                newList.Add(current.Data);
            }
            current = current.Next;
        }
        return newList;
    }

    public void Add(int data)
    {
        if (head == null)
        {
            head = new Node(data);
        }
        else
        {
            Node newNode = new Node(data)
            {
                Next = head.Next
            };
            head.Next = newNode;
        }
    }

    public void RemoveElementsAfterMax()
    {
        if (head == null) return;

        Node? current = head;
        Node? maxNode = head;

        while (current != null)
        {
            if (current.Data > maxNode.Data)
            {
                maxNode = current;
            }
            current = current.Next;
        }

        if (maxNode.Next != null)
        {
            maxNode.Next = null;
        }
    }
}

public class Node
{
    public int Data { get; set; }
    public Node? Next { get; set; }

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}