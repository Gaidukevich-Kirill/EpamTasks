using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    public class TreeNode <T> where T : IComparable
    {
        private Tree<T> _tree;
        private TreeNode<T> _left;
        private TreeNode<T> _right;

        #region Constructor

        public TreeNode(T value, TreeNode<T> parent, Tree<T> tree)
        {
            Value = value;
            Parent = parent;
            _tree = tree;
        }

        #endregion

        #region Properties

        public T Value { get; set; } //Value of current node

        public TreeNode<T> Parent { get; set; } //Parent node

        public TreeNode<T> Left
        {
            get
            {
                return _left;
            }

            set
            {
                _left = value;

                if (_left != null)
                {
                    _left.Parent = this;
                }
            }
        }

        public TreeNode<T> Right
        {
            get
            {
                return _right;
            }

            set
            {
                _right = value;

                if (_right != null)
                {
                    _right.Parent = this;
                }
            }
        }

        #endregion

        #region CompareTo

        public int CompareTo(T other)
        {
            return Value.CompareTo(other);
        }

        #endregion

        #region Balance

        public void Balance()
        {
            if (State == TreeState.RightHeavy)
            {
                if (Right != null && Right.BalanceFactor < 0)
                {
                    LeftRightRotation();
                }
                else
                {
                    LeftRotation();
                }
            }
            else if (State == TreeState.LeftHeavy)
            {
                if (Left != null && Left.BalanceFactor > 0)
                {
                    RightLeftRotation();
                }
                else
                {
                    RightRotation();
                }
            }
        }

        public int BalanceFactor
        {
            get
            {
                return RightHeight - LeftHeight;
            }
        }

        private int MaxChildHeight(TreeNode<T> node)
        {
            if (node != null)
            {
                return 1 + Math.Max(MaxChildHeight(node.Left), MaxChildHeight(node.Right));
            }

            return 0;
        }

        private int LeftHeight
        {
            get
            {
                return MaxChildHeight(Left);
            }
        }

        private int RightHeight
        {
            get
            {
                return MaxChildHeight(Right);
            }
        }

        private TreeState State
        {
            get
            {
                if (LeftHeight - RightHeight > 1)
                {
                    return TreeState.LeftHeavy;
                }

                if (RightHeight - LeftHeight > 1)
                {
                    return TreeState.RightHeavy;
                }

                return TreeState.Balanced;
            }
        }

        private enum TreeState
        {
            Balanced,
            LeftHeavy,
            RightHeavy,
        }

        #endregion

        #region LeftRotation

        private void LeftRotation()
        {
            //   1(this)              2
            //    \                  / \
            //      2               1   3
            //       \
            //        3
            var newRoot = Right;
            ReplaceRoot(newRoot);

            Right = newRoot.Left;

            newRoot.Left = this;
        }

        #endregion

        #region RightRotation

        private void RightRotation()
        {
            //  (this)1      2
            //       /      / \
            //      2      1   3
            //     /
            //    3

            var newRoot = Left;
            ReplaceRoot(newRoot);

            Left = newRoot.Right;

            newRoot.Right = this;
        }

        #endregion

        #region LeftRightRotation

        public void LeftRightRotation()
        {
            Right.RightRotation();
            Left.RightRotation();
        }

        #endregion

        #region RightLeftRotation

        private void RightLeftRotation()
        {
            Left.LeftRotation();
            RightRotation();
        }

        #endregion

        #region ReplaceRoot

        private void ReplaceRoot(TreeNode<T> newRoot)
        {
            if (this.Parent != null)
            {
                if (this.Parent.Left == this)
                {
                    this.Parent.Left = newRoot;
                }
                else if (this.Parent.Right == this)
                {
                    this.Parent.Right = newRoot;
                }

                newRoot.Parent = this.Parent;
                this.Parent = newRoot;
            }
        }

        #endregion
    }
}
