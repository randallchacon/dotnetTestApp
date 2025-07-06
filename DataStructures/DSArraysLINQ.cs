using System.Net;

public static class DSArraysLINQ
{
    public static void UsingArraysLINQ()
    {
        Console.WriteLine($"\n--ARRAYS With LINQ--");
        int[] originalNumbers = { 5, 2, 8, 1, 9, 4, 7, 3, 6 };
        Console.WriteLine($"\nOriginal array: {string.Join(", ", originalNumbers)}");
        Sorting();
        Copying();
        Searching();
        CheckingExists();
        SummingElements();
        AverageOfElements();
        FindingMaxAndMin();
    }
    private static void Sorting()
    {
        int[] originalNumbers = { 5, 2, 8, 1, 9, 4, 7, 3, 6 };
        // 1. Sorting an Array
        Array.Sort(originalNumbers);
        Console.WriteLine($"Sorted array:   {string.Join(", ", originalNumbers)}"); // Output: 1, 2, 3, 4, 5, 6, 7, 8, 9

        // 2. Reversing an Array
        Array.Reverse(originalNumbers);
        Console.WriteLine($"Reversed array: {string.Join(", ", originalNumbers)}"); // Output: 9, 8, 7, 6, 5, 4, 3, 2, 1        
    }

    private static void Copying()
    {
        int[] originalNumbers = { 5, 2, 8, 1, 9, 4, 7, 3, 6 };
        // 3. Copying an Array
        int[] copiedNumbers = new int[originalNumbers.Length];
        Array.Copy(originalNumbers, copiedNumbers, originalNumbers.Length);
        Console.WriteLine($"Copied array:   {string.Join(", ", copiedNumbers)}"); // Output: 9, 8, 7, 6, 5, 4, 3, 2, 1
    }

    private static void Searching()
    {
        int[] originalNumbers = { 5, 2, 8, 1, 9, 4, 7, 3, 6 };
        // 4. Searching for an element (returns the first index, or -1 if not found)
        int index = Array.IndexOf(originalNumbers, 2);
        Console.WriteLine($"Index of 2: {index}"); // Output: Index of 2: 1 (since it's reversed)
    }

    private static void CheckingExists()
    {
        int[] originalNumbers = { 5, 2, 8, 1, 9, 4, 7, 3, 6 };
        // 5. Checking if an element exists (using LINQ)
        bool containsFive = originalNumbers.Contains(5);
        Console.WriteLine($"Contains 5: {containsFive}"); // Output: Contains 5: True
    }

    private static void SummingElements()
    {
        int[] originalNumbers = { 5, 2, 8, 1, 9, 4, 7, 3, 6 };
        // 6. Summing elements (using LINQ)
        int sum = originalNumbers.Sum();
        Console.WriteLine($"Sum of elements: {sum}"); // Output: 45
    }

    private static void AverageOfElements()
    {
        int[] originalNumbers = { 5, 2, 8, 1, 9, 4, 7, 3, 6 };
        // 7. Average of elements (using LINQ)
        double average = originalNumbers.Average();
        Console.WriteLine($"Average of elements: {average}"); // Output: 5
    }

    private static void FindingMaxAndMin()
    {
        int[] originalNumbers = { 5, 2, 8, 1, 9, 4, 7, 3, 6 };
        // 8. Finding Max/Min (using LINQ)
        int max = originalNumbers.Max();
        int min = originalNumbers.Min();
        Console.WriteLine($"Max element: {max}, Min element: {min}"); // Output: Max element: 9, Min element: 1                
    }    
}