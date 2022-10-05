using System;
using System.Collections.Generic;
using System.Text;

namespace Task5
{
    public class TreeNode<TNode> 
        where TNode : IComparable<TNode>
    {
        Tree<TNode> _tree;

        TreeNode<TNode> _left; // left child
        TreeNode<TNode> _right; // right child


        #region Constructor

        public TreeNode(TNode value, TreeNode<TNode> parent, Tree<TNode> tree)
        {
            Value = value;
            Parent = parent;
            _tree = tree;
        }

        #endregion

        #region Properties

        public TreeNode<TNode> Left
        {
            get { return _left; }

            set
            {
                _left = value;

                if (_left != null)
                {
                    _left.Parent = this; // setting pointer for parent element
                }
            }
        }

        public TreeNode<TNode> Right
        {
            get { return _right; }

            internal set
            {
                _right = value;

                if (_right != null)
                {
                    _right.Parent = this; // setting pointer for parent element
                }
            }
        }

        
        public TreeNode<TNode> Parent { get; internal set; } //pointer for parent element

        public TNode Value { get; private set; } //value of current node

        #endregion

        #region CompareTo

        public int CompareTo(TNode other)
        {
            return Value.CompareTo(other);
        }

        #endregion

        #region Balance

        internal void Balance()
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

        private int MaxChildHeight(TreeNode<TNode> node)
        {
            if (node != null)
            {
                return 1 + Math.Max(MaxChildHeight(node.Left), MaxChildHeight(node.Right));
            }

            return 0;
        }

        private int LeftHeight
        {
            get { return MaxChildHeight(Left); }
        }

        private int RightHeight
        {
            get { return MaxChildHeight(Right); }
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

        private int BalanceFactor
        {
            get { return RightHeight - LeftHeight; }
        }

        enum TreeState
        {
            Balanced,
            LeftHeavy,
            RightHeavy,
        }

        #endregion

        #region LeftRotation

        private void LeftRotation()
        {
            //     1(this)                     2(this)  
            //      \                         / \
            //       2            =>         1   3
            //        \     
            //         3     

            var newRoot = Right;
            ReplaceRoot(newRoot);

            Right = newRoot.Left;
            
            newRoot.Left = this;
        }

        #endregion

        #region RightRotation

        private void RightRotation()
        {
            //     1(this)                          2(this)     
            //    /                                / \
            //   2                                1   3
            //  /     
            // 3     

            var newRoot = Left;
            ReplaceRoot(newRoot);

            Left = newRoot.Right;

            newRoot.Right = this;
        }

        #endregion

        #region LeftRightRotation

        private void LeftRightRotation()
        {
            Right.RightRotation();
            LeftRotation();
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

        private void ReplaceRoot(TreeNode<TNode> newRoot)
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
            }
            else
            {
                _tree.Head = newRoot;
            }

            newRoot.Parent = this.Parent;
            this.Parent = newRoot;
        }

        #endregion
    }
}
