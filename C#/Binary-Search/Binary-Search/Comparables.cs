using System;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
namespace Binary_Search
{
    public class IntComparable : System.IComparable
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
    public class StringComparable : System.IComparable
    {
        public String value;
        public StringComparable(String v) { value = v; }
        public int CompareTo(object obj)
        {
            StringComparable tmp = obj as StringComparable;

            return value.CompareTo(tmp.value);

        }
        public override String ToString()
        {
            return  this.value;
        }

    }  
      

}