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
    public int MaxDepth(Node root) {
        
        if(root == null) return 0;
        
        int size = 0;
        
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);
        
        while(queue.Count > 0){
            
            var queueSize = queue.Count;
            
            for(int i=0; i<queueSize; i++){
                Node CurrentNode = queue.Dequeue();
                foreach(var child in CurrentNode.children){
                    queue.Enqueue(child);
                }
            }    
            size++;
        }
        
        return size;
            
    }
}
