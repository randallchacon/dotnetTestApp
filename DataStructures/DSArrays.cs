public static class DSArrays
{
    public static void UsingArrays()
    {
        //Description: Arrays are fixed-size, strongly-typed collections of elements stored in contiguous memory locations. Elements are accessed by their zero-based index.
        //When to Use: When the number of elements is known in advance and doesn't change frequently.        
        Console.WriteLine($"--ARRAYS--\n");
        Console.WriteLine("int[] numbers = { 1, 2, 3, 4, 5 };");
        Access();
        Modify();
        HandleMultidimensional();
        UsingJaggedArray();
    }

    private static void DeclaringAnArray()
    {
        //1. Without initialization
        //2. Fixed size
        //3. With values
        //4. Using var

        //1. Without initialization
        int[] numbers;
        string[] names;

        //2. Fixed size
        int[] numbers2 = new int[5];
        string[] names2 = new string[5];

        //3. With values
        int[] numbers3 = { 1, 2, 3 };
        string[] names3 = { "Randall", "Angie" };

        //4. Using var
        //C# can infer the type of the array if you provide an initializer list.
        var mixedNumbers = new[] { 1, 2, 3 };
        var mixedNames = new[] { "Ran", "Ang" };
    }

    public static void Access()
    {
        Console.WriteLine("**Access**");
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Value index 0: {numbers[0]}");
    }

    public static void Modify()
    {
        Console.WriteLine("**Modify**");
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Value index 1: {numbers[1]}");
        numbers[1] = 10;
        Console.WriteLine($"Value index 1 after modification: {numbers[1]}");
    }

    public static void HandleMultidimensional()
    {
        Console.WriteLine("**Matrix**");
        //Declaration and initializaton
        int[,] numbersMatrix = new int[1, 2]; //1 rows, 2 cols
        //Assigning values
        numbersMatrix[0, 0] = 1;
        numbersMatrix[0, 1] = 2;

        int[,] matrix ={
            {1, 2 },
            {3, 4}
        };

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write($"{matrix[row, col]} ");
            }
            Console.WriteLine();
        }
    }

    public static void UsingJaggedArray()
    {
        Console.WriteLine("**JaggedArray**");
        // jagged array is an array whose elements are arrays. The length of each inner array can differ.
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[] { 0, 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5, 6 };
        jaggedArray[2] = [7, 8, 9, 10, 11];

        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++) //Iterate through elements in current row
            {
                Console.Write($"{jaggedArray[i][j]} ");
            }
            Console.WriteLine();
        }
    }
}