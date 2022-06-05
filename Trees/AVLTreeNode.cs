using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    internal class AVLTreeNode
    {
        public int data;
        public AVLTreeNode right;
        public AVLTreeNode left;
        public int hight=0;
        public AVLTreeNode(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
            
        }
        
    }
}
