using System.Net;

public static class DSStacks
{
    public static void UsingStacks()
    {
        //Description: Stacks are LIFO (Last-In, First-Out) collections. Think of a stack of plates: the last plate you put on is the first one you take off.
        //Common Operations: Push (add an element to the top), Pop (remove and return the top element), Peek (return the top element without removing it).
        //When to Use: For scenarios like undo/redo functionality, parsing expressions, managing function call stacks (recursion).
        PushingElements();
        PeekingAtTheTop();
        PopingElements();
        CheckingElementExists();
    }

    private static void PushingElements()
    {
        Console.WriteLine("-- Pushing elements --\n");
        // 1. Declaring and Initializing a Stack
        // Create an empty stack of integers
        Stack<int> numberStack = new Stack<int>();

        Console.WriteLine($"Initial stack count: {numberStack.Count}"); // Output: 0

        // 2. Pushing Elements (Adding to the top)
        Console.WriteLine("\nPushing elements onto the stack:");
        numberStack.Push(10); // Stack: [10]
        Console.WriteLine($"Pushed 10. Stack Count: {numberStack.Count}");

        numberStack.Push(20); // Stack: [10, 20] (20 is now at the top)
        Console.WriteLine($"Pushed 20. Stack Count: {numberStack.Count}");

        numberStack.Push(30); // Stack: [10, 20, 30] (30 is now at the top)
        Console.WriteLine($"Pushed 30. Stack Count: {numberStack.Count}");
    }

    private static void PeekingAtTheTop(Stack<int> numberStack = null)
    {
        //Declare a stack with elements through List
        if (numberStack == null)
            numberStack = new Stack<int>(new List<int> { 10, 20, 30 });

        Console.WriteLine("\n-- Peeking at the top element --\n");
        if (numberStack.Count > 0)
        {
            int topElement = numberStack.Peek();
            Console.WriteLine($"Top element: {topElement}"); // Output: 30
            Console.WriteLine($"Stack Count after Peek: {numberStack.Count}"); // Still 3
        }
        else
        {
            Console.WriteLine("Stack is empty, cannot peek.");
        }        
    }

    private static void PopingElements()
    {
        // 4. Popping Elements (Removing from the top)
        Console.WriteLine("\n-- Poping Elements --");
        Stack<int> numberStack = new Stack<int>(new List<int> { 10, 20, 30 });
        Console.WriteLine("\nPopping elements from the stack:");
        if (numberStack.Count > 0)
        {
            int poppedItem1 = numberStack.Pop(); // poppedItem1 = 30
            Console.WriteLine($"Popped: {poppedItem1}. Stack Count: {numberStack.Count}"); // Output: Popped: 30. Stack Count: 2

            int poppedItem2 = numberStack.Pop(); // poppedItem2 = 20
            Console.WriteLine($"Popped: {poppedItem2}. Stack Count: {numberStack.Count}"); // Output: Popped: 20. Stack Count: 1
        }
        else
        {
            Console.WriteLine("Stack is empty, cannot pop.");
        }        
        PeekingAtTheTop(numberStack);
    }

    private static void CheckingElementExists()
    {
        Console.WriteLine("\n-- Checking if element exists --\n");
        Stack<int> numberStack = new Stack<int>(new List<int> { 10, 20, 30 });
        // 5. Checking if an element exists (`Contains`)
        numberStack.Pop();
        numberStack.Pop();
        numberStack.Push(50); // Add some elements back
        numberStack.Push(60);
        Console.WriteLine($"Current stack (after more pushes): {string.Join(", ", numberStack)}");
        // Note: When iterating/joining, the order might seem reversed to you because Push adds to the "front" of the underlying array,
        // but the LIFO principle still holds for Pop/Peek.
        // If you enumerate a stack, it will iterate from top to bottom (LIFO order).

        Console.WriteLine($"Does stack contain 20? {numberStack.Contains(20)}"); // Output: False (20 was popped)
        Console.WriteLine($"Does stack contain 50? {numberStack.Contains(50)}"); // Output: True        
    }
}