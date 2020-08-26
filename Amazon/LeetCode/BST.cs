using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Text;

namespace LeetCode
{
    class TreeNode
    {
        internal int data;
        internal TreeNode left = null;
        internal TreeNode right = null;
    }

    class BST
    {
        public TreeNode buildBST(TreeNode root, int val)
        {
            if (root == null)
            {
                TreeNode node = new TreeNode();
                node.data = val;
                root = node;
            }
            else if (val < root.data)
                root.left = buildBST(root.left, val);
            else
               root.right = buildBST(root.right, val);

            return root;
        }
    }
}
