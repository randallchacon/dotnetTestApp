public static class DSLists
{
    public static void UsingLists()
    {
        //Description: Lists are dynamic arrays, meaning they can grow or shrink in size as needed. They provide methods for adding, removing, searching, and sorting elements. They are essentially a wrapper around an array that handles resizing automatically.
        //When to Use: When you need a dynamic collection of elements of the same type, and you frequently need to add/remove elements or access them by index.
        Declaring();
        Adding();
        AccessingElementsById();
        Inserting();
        Removing();
    }
    private static void Declaring()
    {
        Console.WriteLine("\n**Declaring**\n");
        // 1. Declaring and Initializing a List
        // You create an instance of List<T> using the 'new' keyword.
        List<string> shoppingList = new List<string>(); // An empty list of strings

        // You can also initialize with values directly:
        List<int> primeNumbers = new List<int> { 2, 3, 5, 7, 11 };

        // Or specify an initial capacity (optional, for performance optimization if you know rough size)
        List<double> temperatures = new List<double>(100); // Pre-allocates space for 100 doubles

        Console.WriteLine($"Initial shopping list count: {shoppingList.Count}"); // Output: 0
        Console.WriteLine($"Prime numbers count: {primeNumbers.Count}");     // Output: 5
    }

    private static void Adding()
    {
        Console.WriteLine("\n**Adding**\n");
        List<string> shoppingList = new List<string>(); // An empty list of strings
        // 2. Adding Elements to a List
        shoppingList.Add("Milk");
        shoppingList.Add("Bread");
        shoppingList.Add("Eggs");
        shoppingList.Add("Milk"); // Lists allow duplicate elements

        Console.WriteLine($"Shopping list after additions: {string.Join(", ", shoppingList)}");
        Console.WriteLine($"Shopping list count: {shoppingList.Count}"); // Output: 4

        // Adding a collection of elements (e.g., from an array or another list)
        string[] moreItems = { "Cheese", "Yogurt" };
        shoppingList.AddRange(moreItems);
        Console.WriteLine($"Shopping list after AddRange: {string.Join(", ", shoppingList)}");
        // Output: Milk, Bread, Eggs, Milk, Cheese, Yogurt
    }

    private static void AccessingElementsById()
    {
        Console.WriteLine("\n**Accessing elements by Id**\n");
        List<string> shoppingList = new List<string> { "Milk", "Bread", "Eggs", "Milk" };
        // 3. Accessing Elements by Index
        Console.WriteLine($"First item: {shoppingList[0]}");    // Output: Milk
        Console.WriteLine($"Third item: {shoppingList[2]}");    // Output: Eggs
        Console.WriteLine($"Last item: {shoppingList[shoppingList.Count - 1]}"); // Output: Yogurt

        // You can also modify an element by its index
        shoppingList[1] = "Whole Wheat Bread";
        Console.WriteLine($"Modified second item: {shoppingList[1]}"); // Output: Whole Wheat Bread
        Console.WriteLine($"Shopping list after modification: {string.Join(", ", shoppingList)}");
    }

    private static void Inserting()
    {
        // 4. Inserting Elements at a Specific Index
        Console.WriteLine("\n**Inserting elements at a spec index**\n");
        List<string> shoppingList = new List<string> { "Milk", "Bread", "Eggs", "Milk" };

        shoppingList.Insert(0, "Coffee"); // Inserts at the beginning, shifting others
        Console.WriteLine($"Shopping list after insert at index 0: {string.Join(", ", shoppingList)}");
        // Output: Coffee, Milk, Whole Wheat Bread, Eggs, Milk, Cheese, Yogurt

        shoppingList.Insert(3, "Fruits"); // Inserts at index 3
        Console.WriteLine($"Shopping list after insert at index 3: {string.Join(", ", shoppingList)}");
        // Output: Coffee, Milk, Whole Wheat Bread, Fruits, Eggs, Milk, Cheese, Yogurt
    }

    private static void Removing()
    {
        Console.WriteLine("\n**Removing elements**\n");
        List<string> shoppingList = new List<string> { "Milk", "Bread", "Eggs", "Milk" };
        // 5. Removing Elements
        // Remove(T item): Removes the first occurrence of the specified item.
        shoppingList.Remove("Milk");
        Console.WriteLine($"Shopping list after removing first 'Milk': {string.Join(", ", shoppingList)}");
        // Output: Coffee, Whole Wheat Bread, Fruits, Eggs, Milk, Cheese, Yogurt (note: one Milk is left)

        // RemoveAt(int index): Removes the element at the specified index.
        shoppingList.RemoveAt(0); // Removes "Coffee"
        Console.WriteLine($"Shopping list after RemoveAt(0): {string.Join(", ", shoppingList)}");
        // Output: Whole Wheat Bread, Fruits, Eggs, Milk, Cheese, Yogurt

        // RemoveAll(Predicate<T> match): Removes all elements that match the specified condition.
        shoppingList.RemoveAll(item => item.Contains("Bread")); // Removes "Whole Wheat Bread"
        Console.WriteLine($"Shopping list after RemoveAll (Contains 'Bread'): {string.Join(", ", shoppingList)}");
        // Output: Fruits, Eggs, Milk, Cheese, Yogurt

        // Clear(): Removes all elements from the list.
        // shoppingList.Clear();
        // Console.WriteLine($"Shopping list after Clear: {string.Join(", ", shoppingList)}"); // Output: (empty)
    }

    private static void SearchingAndChecking()
    {
        //Contains
        //IndexOf
        //LastIndexOf
        //Exists
        //Find
        //FindAll
    }
}