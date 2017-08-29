using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    
    class Tree 
{
    private Node root;
    private int count;

    public Tree()
    {
        root = null;
        
    }
    public bool isEmpty()
    {
        return root == null;
    }

    public void insert(int d)
    {
        if (isEmpty())
        {
            root = new Node(d);
        }
        else
        {
            root.insertData(ref root, d);
        }
    }

    public bool search(int s)
    {
        return root.search(root, s);
    }


    public void display()
    {
        if(!isEmpty())
        root.display(root);
    }

}
}
