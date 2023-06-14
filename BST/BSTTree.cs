using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class BSTTree
    {
        public TreeNode root;

        public BSTTree()
        {
            root = null;
        }

        public TreeNode StartSearch(int value)
        {
            return SearchSelection(root, value);
        }

        private TreeNode SearchSelection(TreeNode x, int value)
        {
            if (x == null) return x;
            if (x.value == value) return x;
            if (value < x.value) return SearchSelection(x.left, value);
            if (value > x.value) return SearchSelection(x.right, value);
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

        private TreeNode InsertSelection(TreeNode x, int value)
        {
            if (x == null) 
            { 
            x = new TreeNode(value);
            return x;
            }
            if (x.value < value)
            {
                x.right = InsertSelection(x.right, value);
            }
            if(x.value > value)
            {
                x.left = InsertSelection(x.left, value);
            }
            return x;

        }

        
        public TreeNode Successor(TreeNode value)
        {
            if (value == null) return value;
            if (value.right != null) return Min(value.right);
            TreeNode successor = null;
            TreeNode x = root;
            while (x != null)
            {
                if (value.value < x.value)
                {
                    successor = x;
                    x = x.left;
                }
                else if (value.value > x.value) x = x.right;
                else break;
            }
            
            return successor;
        }


        public void StartDelete(int value)
        {
            root = Delete(root, value);
        }
        private TreeNode Delete(TreeNode x, int value)
        {
            if (x == null) return x;
            if (value < x.value)
            {
                x.left = Delete(x.left, value);
            }
            else if (value > x.value)
            {
                x.right = Delete(x.right, value);
            }
            else
            {
                if (x.left == null)
                {
                    return x.right;
                }
                else if (x.right == null)
                {
                    return x.left;
                }
                TreeNode successor = Min(x.right);
                x.value = successor.value;
                x.right = Delete(x.right, successor.value);
            }

            return x;
        }



    }

  

    

}
