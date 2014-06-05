using System;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
namespace Binary_Search
{

    public class BinarySearchNode<T> : System.IComparable<T> where T :class, System.IComparable<T>
    {
        public BinarySearchNode<T> left;
        public BinarySearchNode<T> right;
        public T value;
        public BinarySearchNode(T value)
        {

            this.left = null;
            this.right = null;
            this.value = value;
        }
        public int CompareTo(object obj)
        {
            BinarySearchNode<T> tmp = obj as BinarySearchNode<T>;
            if (tmp == null) throw new ArgumentException("Wrong generic type sypplied in to binar search tree.");

            return this.value.CompareTo(tmp.value);
        }
    }
}