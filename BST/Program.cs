using System;

namespace BST
{
    class Program
    {
        public static void Main(string[] args)
        {
            Functions bst = new Functions();

            bst.StartInsert(15);
            bst.StartInsert(1);
            bst.StartInsert(125);
            bst.StartInsert(16);
            bst.StartInsert(25);
            bst.StartInsert(95);
            bst.StartInsert(5);
            bst.StartSearch(125);

            //if (bst.StartSearch(1) != null) Console.WriteLine("tak");
            //else Console.WriteLine("nie");
            TreeNode minValueNode = bst.Min(bst.root);
            TreeNode maxValueNode = bst.Max(bst.root);


            Console.WriteLine("Minimalna wartość w drzewie: " + minValueNode.value);
            Console.WriteLine("Maksymalna wartość w drzewie: " + maxValueNode.value);
        }

    }
    }

