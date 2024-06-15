// Determine the big O notation for the SortArray function.
public static class Sorting {
    public static void Run() {
        var numbers = new[] { 3, 2, 1, 6, 4, 9, 8 };
        SortArray(numbers);
        Console.Out.WriteLine("int[]{{{0}}}", string.Join(", ", numbers)); //int[]{1, 2, 3, 4, 6, 8, 9}
    }

    private static void SortArray(int[] data) {
        //outer loop runs n times. n = array length
        for (var sortPos = data.Length - 1; sortPos >= 0; sortPos--) {
            // Inner loop runs n-1 times, then n-2 times... down to 1 time
            for (var swapPos = 0; swapPos < sortPos; ++swapPos) {
                // swap operation is contant time i.e O(1)
                if (data[swapPos] > data[swapPos + 1]) {
                    (data[swapPos + 1], data[swapPos]) = (data[swapPos], data[swapPos + 1]);
                }
            }
        }
    }
}
// = (n-1) + (n-2) + ... + 1 = n(n-1)/2 = Big Oh notation = O(n^2)