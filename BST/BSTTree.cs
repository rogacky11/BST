﻿using System;
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

        
        public TreeNode Successor(TreeNode x)
        {
            if (x == null) return x;
            if (x.right != null) return Min(x.right);
            TreeNode successor = null;
            TreeNode current = root;
            while (current != null)
            {
                if (x.value < current.value)
                {
                    successor = current;
                    current = current.left;
                }
                else if (x.value > current.value) current = current.right;
                else break;
            }
            
            return successor;
        }

        public TreeNode Delete(TreeNode x)
        {
            TreeNode z, y = null;
            if(x.right == null || x.left == null)
            {
                y = x;
            }
            if (x.right != null && x.left == null)
            {
                y = x.right;

            }
            if (x.right == null && x.left != null)
            {
                y = x.left;
            }
            if (x.right != null && x.left != null)
            {
               
                
                    y = Successor(x);
                
            }


            return y;
        }


    }

  

    

}
