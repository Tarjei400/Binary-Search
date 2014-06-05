using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
namespace Binary_Search
{
    public class BinarySearchTree<T> where T : class, System.IComparable
    {
        public BinarySearchNode<T> root;
        private int treesize;
        public BinarySearchTree()
        {
            treesize = 0;
        }
        public BinarySearchNode<T> Insert(T value, BinarySearchNode<T> node = null)
        {
            if (node == null) 
                node = new BinarySearchNode<T>(value);
            
            int compare = value.CompareTo(node.value);
            if (compare < 0)
            {
                node.left = Insert(value, node.left);
            }
            else if (compare > 0){
                node.right = Insert(value, node.right);
            } 
            
            return node;
            
        }

        public BinarySearchNode<T> Delete(T value,  BinarySearchNode<T> node)
        {
            BinarySearchNode<T> TmpNode;

            if (node == null)
                return null;

            int compare = value.CompareTo(node.value);
            if (compare < 0)
            {
                node.left = Delete(value, node.left);
            }
            else if (compare > 0)
            {
                node.right = Delete(value,  node.right);
            }
            else if (node.left != null && node.right != null)
            {
                TmpNode = MinFind(node.right);
                node.value = TmpNode.value;
                node.right = Delete(node.value, node.right);
            }
            else {
                TmpNode = node;
                if (node.left == null)
                    node = node.right;
                else if (node.right == null)
                    node = node.left;
                else
                {
                    node = null;
                }


            }
            return node;
        }
        public void Empty(BinarySearchNode<T> node){
            //Empty tree;
            
        }

        public bool isEmpty()
        {
            //Empty tree;
            return treesize == 0;

        }
        public BinarySearchNode<T> Find(T element, BinarySearchNode<T> node)
        {

            return null;
        }
        public BinarySearchNode<T> MinFind(BinarySearchNode<T> node)
        {
            if (node == null)
                return null;

            while (node.left != null)
            {
                node = node.left;

            }
            return node;
        }

        public BinarySearchNode<T> MaxFind(BinarySearchNode<T> node)
        {
            if (node == null)
                return null;

            while (node.right != null)
            {
                node = node.right;

            }
            return node;
        }
        public void PreOrder(BinarySearchNode<T> node)
        {
            if (node == null)
                return;
            Console.WriteLine(node.value.ToString());
            PreOrder(node.right);
            PreOrder(node.left);
        }
        public List<T> InOrder()
        {

            return new List<T>();
        }
        public List<T> PostOrder()
        {

            return new List<T>();
        }
    }
}