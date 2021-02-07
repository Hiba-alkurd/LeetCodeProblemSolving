public class Solution {
    
    public int MaxDepth(TreeNode root) {
        
        if(root == null) return 0;
        if(root.right == null && root.left == null) return 1;
        if(root.right == null) return MaxDepth(root.left) + 1;
        if(root.left == null) return MaxDepth(root.right) + 1;
        
        
        return Math.Max(MaxDepth(root.right) + 1, MaxDepth(root.left) + 1);
        
    }
    
}