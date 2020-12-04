
107. Binary Tree Level Order Traversal II

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {

        IList<IList<int>> result = new List<IList<int>>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        Stack<List<int>> stack = new Stack<List<int>>();
        List<int> tempList = null;
        TreeNode currentNode = null;
        int count = 0;
        
        if (root != null)
        {
            queue.Enqueue(root);
            
            while(queue.Count != 0)
            {
                count = queue.Count;
                tempList = new List<int>();
                
                while(count > 0)
                {
                    currentNode = queue.Dequeue();
                    tempList.Add(currentNode.val);
                    if (currentNode.left != null)
                        queue.Enqueue(currentNode.left);
                    if (currentNode.right != null)
                        queue.Enqueue(currentNode.right);
                
                    count--;
                }
                
                stack.Push(tempList);
            }
            
            while (stack.Count != 0)
                result.Add(stack.Pop());
        }
        
        return result;
    }
}
