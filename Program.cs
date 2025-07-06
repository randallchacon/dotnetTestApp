using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        string menu =
@"-- Menu ---
1. Using arrays
2. Using arrays with LINQ
3. Using lists

Enter your choice: ";

        Console.Write(menu);
        string ?optionSelected = Console.ReadLine();
        Console.WriteLine();
        switch (optionSelected)
        {
            case "1":
                DSArrays.UsingArrays();
                break;
            case "2":
                DSArraysLINQ.UsingArraysLINQ();
                break;
            case "3":
                DSLists.UsingLists();
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }
        Console.WriteLine();
    }

    public void UsingStacks()
    {
        //Description: Stacks are LIFO (Last-In, First-Out) collections. Think of a stack of plates: the last plate you put on is the first one you take off.
        //Common Operations: Push (add an element to the top), Pop (remove and return the top element), Peek (return the top element without removing it).
        //When to Use: For scenarios like undo/redo functionality, parsing expressions, managing function call stacks (recursion).
        Stack<int> numbers = new Stack<int>();
        numbers.Push(10);
        numbers.Push(20);
        numbers.Push(30);

        numbers.Pop();
    }

    public void UsingQueues()
    {
        //Description: Queues are FIFO (First-In, First-Out) collections. Think of a line at a store: the first person in line is the first one served.
        //Common Operations: Enqueue (add an element to the back), Dequeue (remove and return the front element), Peek (return the front element without removing it).
        //When to Use: For managing tasks, processing requests in order (e.g., print queues, message queues), breadth-first search algorithms.
        Queue<int> numbers = new Queue<int>();

        numbers.Enqueue(10);
        numbers.Enqueue(20);

        numbers.Dequeue();
    }

    public void UsingDictionaries()
    {
        //Description: Dictionaries are collections of key-value pairs. Each key must be unique, and it maps to a specific value. They provide very fast lookups based on the key. Internally, they use hash tables.
        //When to Use: When you need to store and retrieve data based on a unique identifier, like looking up a person's age by their name, or a product's price by its SKU.        
        Dictionary<int, int> numbers = new Dictionary<int, int>();
        numbers.Add(1, 1);
    }

    public void HashSets()
    {
        //Description: HashSets are unordered collections of unique elements. They are highly optimized for fast checks of whether an element exists in the set (membership testing) and for performing set operations (union, intersection, etc.).
        // When to Use: When you need to store a collection of distinct items and perform quick lookups or set-theoretic operations. Order is not guaranteed.
        HashSet<int> uniqueNumbers = new HashSet<int>();

        uniqueNumbers.Add(1);
        uniqueNumbers.Add(2);
        uniqueNumbers.Add(3);
    }

    public void LinkList()
    {
        //Description: A linked list is a linear data structure where elements (nodes) are not stored in contiguous memory locations. Each node contains the data and a reference (or link) to the next node in the sequence. A LinkedList<T> in C# is a doubly linked list, meaning each node also has a reference to the previous node.
        //When to Use: When frequent insertions or deletions are needed anywhere in the list, as these operations are efficient (O(1)) compared to arrays/lists (O(n)). Random access by index is slow (O(n)).
        LinkedList<string> numbers = new LinkedList<string>();
        
    }
}