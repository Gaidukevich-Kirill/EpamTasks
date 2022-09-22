using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    public class Tree<T> where T : IComparable
    {
        #region Properties

        public TreeNode<T> HeadNode { get; set; }

        #endregion

        #region AddMethods

        public void Add(T value)
        {
            if (HeadNode == null)
            {
                HeadNode = new TreeNode<T>(value, null, this);
            }
            else
            {
                AddTo(HeadNode, value);
            }
        }

        public void AddTo(TreeNode<T> node, T value)
        {
            if (value.CompareTo(node.Value) < 0)
            {
                if (node.Left == null)
                {
                    node.Left = new TreeNode<T>(value, node, this);
                }
                else
                {
                    AddTo(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new TreeNode<T>(value, node, this);
                }
                else
                {
                    AddTo(node, value);
                }
            }
        }

        #endregion
    }
}
