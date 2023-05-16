namespace SymmetricTree;

public class Program
{
    public static void Main(string[] args)
    {
        TreeNode root = new(1)
        {
            Left = new TreeNode(2),
            Right = new TreeNode(2)
        };
        root.Left.Left = new TreeNode(3);
        root.Left.Right = new TreeNode(4);
        root.Right.Left = new TreeNode(4);
        root.Right.Right = new TreeNode(3);

        var mirrorCheck = new MirrorCheck();
        var isSymmetric = mirrorCheck.IsSymmetric(root);
        Console.WriteLine($"Is Binary tree symmetric {isSymmetric}");
    }
}