// 559. Maximum Depth of N-ary Tree

/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    int maxDepth;
    public int MaxDepth(Node root) {
        if(root == null) return 0;        
        GetMaxDepth(root, 1);
        return maxDepth;
    }
    
    
    public void GetMaxDepth(Node node, int depth){
        if(node == null) return;
        maxDepth = Math.Max(depth,maxDepth);
        
        foreach(Node child in node.children)
           GetMaxDepth(child, depth+1);   
    }
}
