using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class Functions
    {
        public TreeNode root;

        public Functions()
        {
            root = null;
        }

        public TreeNode StartSearch(int value)
        {
            return SearchSelection(root, value);
        }

        private TreeNode SearchSelection(TreeNode root, int value)
        {
            if (root == null) return root;
            if (root.value == value) return root;
            if (value < root.value) return SearchSelection(root.left, value);
            if (value > root.value) return SearchSelection(root.right, value);
            else return null;

        }

        public TreeNode Min(TreeNode x)
        {
            
            if (x == null) return x;
            while (x.left != null)
            {
                x = x.left;
            }
            return x;
        }

        public TreeNode Max(TreeNode x)
        {
        
            if (root == null) return x;
            while (x.right != null)
            {
                x = x.right;
            }
            return x;
        }


        public void StartInsert(int value)
        {
            root = InsertSelection(root, value);
        }

        private TreeNode InsertSelection(TreeNode root, int value)
        {
            if (root == null) 
            { 
            root = new TreeNode(value);
            return root;
            }
            if (root.value < value)
            {
                root.left = InsertSelection(root.left, value);
            }
            if(root.value > value)
            {
                root.right = InsertSelection(root.right, value);
            }
            return root;

        }

    }

  

    

}
