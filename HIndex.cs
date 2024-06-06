public class Solution {
    public int HIndex(int[] citations) {
        // Step 1: Sort the array in non-decreasing order
        Array.Sort(citations);
        
        int n = citations.Length;
        
        // Step 2: Find the h-index
        for (int i = 0; i < n; i++) {
            int h = n - i;  // Number of papers with at least h citations
            if (citations[i] >= h) {
                return h;
            }
        }
        
        return 0;
    }
}
