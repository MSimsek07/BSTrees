using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    internal class AVLtree
    {
        AVLTreeNode root;

        public int height(AVLTreeNode node)
        {
            if (node == null)
            {
                return -1;

            }
            else
                return node.hight;

        }
        public int max(int a, int b)
        {
            return (a > b) ? a : b;
        }


    }
}
