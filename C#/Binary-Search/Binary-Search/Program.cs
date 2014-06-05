using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binary_Search
{

    
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



            Console.WriteLine("Binary Int Tree implementation PreOrder.");
            m_tree.PreOrder(m_tree.root);
            Console.WriteLine();
            Console.WriteLine("Binary Int Tree implementation InOrder.");
            m_tree.InOrder(m_tree.root);
            Console.WriteLine();
            Console.WriteLine("Binary Int Tree implementation PostOrder.");
            m_tree.PostOrder(m_tree.root);
            Console.WriteLine();
            Console.WriteLine("Binary Int Tree implementation end.");

            BinarySearchTree<StringComparable> m_stringtree = new BinarySearchTree<StringComparable>();

            String[] str_arr = { "Adrian", "Ada", "Zuzanna", "Marcin", "Katarzyna", "Felicjan"};
            List<String> stringset = new List<String>(str_arr);
            foreach (String v in stringset)
            {
                StringComparable v1 = new StringComparable(v);
                m_stringtree.root = m_stringtree.Insert(v1, m_stringtree.root);
            }
            Console.WriteLine("Binary String Tree implementation PreOrder.");
            m_stringtree.PreOrder(m_stringtree.root);
            Console.WriteLine();
            Console.WriteLine("Binary String Tree implementation InOrder.");
            m_stringtree.InOrder(m_stringtree.root);
            Console.WriteLine();
            Console.WriteLine("Binary String Tree implementation PostOrder.");
            m_stringtree.PostOrder(m_stringtree.root);
            Console.WriteLine();
            Console.WriteLine("Binary String Tree implementation end.");
            Console.ReadLine();



        }
    }
}
