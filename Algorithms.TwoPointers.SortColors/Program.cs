namespace Algorithms.TwoPointers.SortColors;

public class Solution {
    public static int[] SortColors (int[] colors)
    {
        int start = 0;
        int current = 0;
        int end = colors.Length - 1;

        while (current <= end) {
            if (colors[current] == 0) {
                (colors[start], colors[current]) = (colors[current], colors[start]);
                current++;
                start++;
            }
            else if (colors[current] == 1) {
                current++;
            }
            else {
                (colors[current], colors[end]) = (colors[end], colors[current]);
                end--;
            }
        }

        return colors;
    }
    
    public static void Main (string[] args) {
        List<int[]> inputs = new List<int[]> () {
            new int[] { 0, 0, 2, 1, 1, 0, 1, 2, 0 },
            new int[] { 1, 2, 0 },
            new int[] { 0, 0, 0 },
            new int[] { 1, 1, 1 }
        };

        for (int i = 0; i < inputs.Count; i++) {
            Console.WriteLine ($"Input: [{string.Join(", ", inputs[i])}]");
            Console.WriteLine ($"Output: [{string.Join(", ", SortColors (inputs[i]))}]");
        }
    }
}