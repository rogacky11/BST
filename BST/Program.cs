using System;

namespace BST
{
    class Program
    {
        public static void Main(string[] args)
        {
            BSTTree bst = new BSTTree();

            bst.StartInsert(3);
            bst.StartInsert(7);
            bst.StartInsert(5);
            bst.StartInsert(18);
            bst.StartInsert(10);
            bst.StartInsert(9);
            bst.StartInsert(13);
            

            if (bst.StartSearch(25) != null) Console.WriteLine("tak");
            else Console.WriteLine("nie");
            TreeNode minValueNode = bst.Min(bst.root);
            TreeNode maxValueNode = bst.Max(bst.root);


            Console.WriteLine("Minimalna wartość w drzewie: " + minValueNode.value);
            Console.WriteLine("Maksymalna wartość w drzewie: " + maxValueNode.value);
            Console.WriteLine(bst.root.value);
        }

    }
    }

