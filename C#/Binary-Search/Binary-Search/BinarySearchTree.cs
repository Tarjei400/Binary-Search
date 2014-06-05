using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
namespace Binary_Search
{
    public class BinarySearchTree<T> where T : class, System.IComparable<T>
    {
        public BinarySearchNode<T> root;
        private int treesize;
        public BinarySearchTree()
        {
            treesize = 0;
        }
        public BinarySearchNode<T> Insert(T value,ref BinarySearchNode<T> node )
        {
            if (node == null) 
                node = new BinarySearchNode<T>(value);
            
            int compare = value.CompareTo(node.value);
            if (compare < 0)
            {
                node.left = Insert(value,ref node.left);
            }
            else if (compare > 0){
                node.right = Insert(value,ref node.right);
            } 
            
            return node;
            
        }

        public void Delete(T value, ref BinarySearchNode<T> node)
        {
                if 
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
        public List<T> PreOrder()
        {

            return new List<T>();
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