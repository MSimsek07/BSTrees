using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    internal class Bstree
    {
        public Node root;
        public Bstree()
        {
            root = null;
        }
        public Node newNode(int data)
        {
            root = new Node(data);
            Console.WriteLine(data+" ağaca eklendi ");
            return root;
        }
        public Node insert(Node root, int data)
        {
            if (root != null)
            {
                if (data< root.data)
                {
                    root.left = insert(root.left, data);
                }
                else
                {
                    root.right = insert(root.right, data);
                }
            }
            else
            {
                root=newNode(data);
            }
            return root;
        }
        public Boolean search(Node root,int wanted) // SINAVDA GELSE BUNU YAZ
        {
            bool found = false;
            while ((root != null) && !found)
            {
                int rval = root.data;
                if (wanted < rval)
                    root = root.left;
                else if (wanted > rval)
                    root = root.right;
                else
                {
                    found = true;
                    break;
                }
                found = search(root, wanted);
            }
            return found;

        }
        public Node enKucukBul(Node root) // EN KUCUK BULMA RECURSIVE
        {
            if( root.left != null)
            {
                    return enKucukBul(root.left);
            }
            return root;
        }
        public Node enBuyukBul(Node root)  // EN BUYUK BULMA RECURSIVE
        {
            
            if (root.right != null)
            {
                return enBuyukBul(root.right);
            }

            return root;
        }
        public Node search_Recursive(Node root, int key)
        {
          
            if (root == null || root.data == key)
                return root;
            
            if (root.data > key)
                return search_Recursive(root.left, key); 

            return search_Recursive(root.right, key);
        }
        public Node search(int data, Node root)
        {

           
            if (root == null || root.data == data)
            {
                return root;
            }

          
            else if (data < root.data)
            {
                return search(data, root.left);
            }

           
            return search(data, root.right);
        }

    }
}
