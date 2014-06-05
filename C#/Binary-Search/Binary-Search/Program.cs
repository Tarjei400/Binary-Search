using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binary_Search
{
   public class IntComparable: System.IComparable
    {
       public int value;
       public IntComparable(int v) { value = v; }
       public int CompareTo(object obj)
       {
           IntComparable tmp = obj as IntComparable;

           if (value < tmp.value)
               return -1;
           else if (value > tmp.value)
               return 1;

            return 0;
        }
       public override String ToString()
       {
           return "" + this.value;
       }

       }  
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Tree implementation test.");
            BinarySearchTree<IntComparable> m_tree = new BinarySearchTree<IntComparable>();

            int[] arr = {1, 34, 5, 6, 8, 9};
            List<int> set = new List<int>(arr);
            foreach (int v in set){
                 IntComparable v1 = new IntComparable(v); 
                 m_tree.root =  m_tree.Insert(v1 , m_tree.root);
            }
            

          

            m_tree.PreOrder(m_tree.root);

            Console.WriteLine("Binary Tree implementation end.");
            Console.ReadLine();

        }
    }
}
