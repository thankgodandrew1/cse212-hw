public static class ArraysTester {
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run() {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    }
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    private static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        
            
        // Plan: 
        // 1. first, i'll create an array to store the multiples that will be generated. 
        // 2. i'll create a loop to calculate each multiple starting from number 
        // 3. Return the array of generated multiples.

        double[] result = new double[length];
        
        for (int i = 0; i < length; i++) {
            result[i] = number * (i + 1);
        }
        
        return result;
    }
    
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 and 
    /// data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list, rather than returning a new list.
    /// </summary>
    private static void RotateListRight(List<int> data, int amount)
    {
        // Plan:
        // 1. first, i'll  find the real rotation amount by using modulud to adjust the rotation amount ====== amount % data.Count.
        // 2. important, check If amount is 0, if it is, return 0
        // 3. Cut the list into two parts and recombine them in the rotated order, ill first put the last part in front of the first part.
        // 4. lastly, update the original list with the rotated list.
        
        int n = data.Count;
        amount = amount % n; // step 1

        // step 2
        if (amount == 0) return;

        //Step 3
        List<int> rotatedList = new List<int>();

        for (int i = n - amount; i < n; i++) {
            rotatedList.Add(data[i]);
        }
        for (int i = 0; i < n - amount; i++) {
            rotatedList.Add(data[i]);
        }

        // step 4
        for (int i = 0; i < n; i++) {
            data[i] = rotatedList[i];
        }
    }
}
