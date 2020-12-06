704. Binary Search

public class Solution {
    public int Search(int[] nums, int target) {
        
        int left = 0;
        int right = nums.Length-1;

        while(left <= right){
            var m = (left+right)/2;
            if(nums[m] == target) return m;
            if(nums[m] < target) left=m+1;
            if(nums[m] > target) right=m-1;
        }
        return -1;
    }
}
