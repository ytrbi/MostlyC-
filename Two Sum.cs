/*
The task is to find the indices of two integers nums and target,
ensuring they add up to target, and returning the corresponding values.
*/

public class Solution {
    // Task 2 solved
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Length; i++) {
            for(int j = 1; j < nums.Length; j++) {
                if(nums[j] == target - nums[i])
                    return new int[]{i, j};
            }
        }
        return null;
    }
}

class Program {
    static void Main() {
        Solution solution = new Solution();

        // Test Task 2
        int[] nums1 = {2, 7, 11, 15};
        int target1 = 9;
        int[] result1 = solution.TwoSum(nums1, target1);
        Console.WriteLine("Test Case 1: " + String.Join(", ", result1));
    }
}
