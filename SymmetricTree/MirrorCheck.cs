namespace SymmetricTree;

public class MirrorCheck
{
    public bool IsSymmetric(TreeNode? node)
    {
        return node != null && IsMirror(node.Left, node.Right);
    }

    public bool IsMirror(TreeNode? node1, TreeNode? node2)
    {
        if (node1 == null && node2 == null) return true;
        if (node1 == null || node2 == null || node1.Value != node2.Value) return false;
            return IsMirror(node1.Left, node2.Right) && IsMirror(node1.Right, node2.Left);
    }
}