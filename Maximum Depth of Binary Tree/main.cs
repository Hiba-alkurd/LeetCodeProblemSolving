public class Solution {
    
    public int MaxDepth(TreeNode root) {
        
        if(root == null) return 0;
        
        return Math.Max(MaxDepth(root.right) + 1, MaxDepth(root.left) + 1);
        
    }
    
}