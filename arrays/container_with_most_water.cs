11. Container With Most Water

public class Solution {
    public int MaxArea(int[] height) {
        
        int left = 0;
        int right = height.Length - 1;
        int max = 0;
        
        while (left < right) {
            int Area = Math.Min(height[left],height[right]) * (right-left);
            if (height[left] > height[right]) right--;
            else left++;
            if(max < Area) max = Area;
        }
        
        return max;
    }
}
