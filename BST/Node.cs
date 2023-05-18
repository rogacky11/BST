using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    public class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public TreeNode parent;
        public int value;
        public TreeNode(int item)
        {
            right = null;
            left = null;
            value = item;
        }


    }
}  
    
    



