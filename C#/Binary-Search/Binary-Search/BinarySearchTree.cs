using System;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
namespace Binary_Search
{
    public class BinarySearchTree<T> where T : System.IComparable
    {
        public BinarySearchNode<T> root;
        public BinarySearchTree()
        {
            
        }
        public void Insert(T value)
        {

        }
        public void Empty(BinarySearchNode<T> node){
            //Empty tree;

        }

        public bool isEmpty()
        {
            //Empty tree;
            return true;

        }
        public BinarySearchNode<T> Find(T element, BinarySearchNode<T> node)
        {

            return null;
        }
        public BinarySearchNode<T> MinFind(BinarySearchNode<T> node)
        {
            return null;
        }

        public BinarySearchNode<T> MaxFind(BinarySearchNode<T> node)
        {
            return null;
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