using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec18Console
{
    public class AllCollections
    {
        //arraylist
        public static void ArrayListFuns()
        {
            ArrayList ar1 = new ArrayList();
            ar1.Add("hello");
            ar1.Add(2);
            ar1.Add(3.3);
            //non generic no having fixed data type collection classes allw a=values of any data type in same object(ar1), class arrayList
            ArrayList ar2 = new ArrayList(); ar2.Add("hello");
            ar2.Add("world");
            ar2.Add("Today is monday");
            // to access and display
            // foreach(string oneValue in ar2) { }
            foreach (var item in ar2) { Console.WriteLine(item); }
            // to remove
            //   ar2.Remove("world");// value is parameter
            //   ar2.RemoveAt(1);// 1 is index number of value
            //   ar2.RemoveRange(1, 4);//(start index, number of values ) 2,3,4,5 values 
            //  ar2.Clear();//all gone
            int n1 = ar2.Capacity; Console.WriteLine("capacity " + n1);
            ar2.Capacity = 10;
            int n2 = ar2.Count; Console.WriteLine("values we saved in collection " + n2);
            ar2.Insert(1, "sai");//hello sai world today is monday start index,value
                                 // ar2.InsertRange(1,ICollectionObje)
            bool b1 = ar2.Contains("hello");
            int n3 = ar2.IndexOf("sai"); Console.WriteLine(n3);
            // collection values will take dynamic
        }
        public static void HashTableFuns()
        {
            Hashtable ht1 = new Hashtable();
            ht1.Add(1, "a"); ht1.Add(2.2, 9); ht1.Add("h", "k");
            Hashtable ht2 = new Hashtable();
            ht2.Add(1, "harry"); ht2.Add(45, "tim");
            ht2.Add(33, "tom"); ht2.Add(9, "jim");
            // to access all keys ICollection is interface in vs I menas interface
            ICollection allKeys = ht2.Keys;
            foreach (var oneKey in allKeys) { Console.WriteLine(oneKey); }
            // to access values
            ICollection allValues = ht2.Values;
            foreach (var onValue in allValues) { Console.WriteLine(onValue); }
            // how to both 
            foreach (DictionaryEntry de in ht2) { Console.WriteLine("Key is " + de.Key); Console.WriteLine("Values is " + de.Value); }
            //to search by key
            bool b1 = ht2.ContainsKey("a"); Console.WriteLine(b1);   // to search by value
            bool b2 = ht2.ContainsValue(2); Console.WriteLine(b2);
            bool b3 = ht2.Contains(25);// pass key as parameter
            int n1 = ht2.Count;// returns number of keys
                               // ht2.CopyTo(array,arrayIndex) from ht2 to array 
            ht2.Remove(99);// by key as parameter 

        }
        public static void SortedListFuns()
        {
            SortedList sl1 = new SortedList();
            sl1.Add(1, "a");
            sl1.Add(33, "xyz");
            sl1.Add(9, "abc");
            // to display sl1 is sorted automatic , that never happens in hashtable
            ICollection c1 = sl1.Keys;
            foreach (var k1 in sl1.Keys) { Console.WriteLine("key is " + k1); }
            ICollection c2 = sl1.Values;
            foreach (var v1 in c2) { Console.WriteLine("the value is " + v1); }
            // to display key and value
            foreach (DictionaryEntry de in sl1) { Console.WriteLine(" key is {0} value is {1} ", de.Key, de.Value); }
            // search 
            bool b1 = sl1.Contains(1);//takes key 
            bool b2 = sl1.ContainsValue("abc");
            bool b3 = sl1.ContainsKey(33);
            int n1 = sl1.Capacity;
            int n2 = sl1.Count;
            sl1.RemoveAt(1);
        }
        public static void StackFuns()
        {
            Stack s1 = new Stack();//adding
            s1.Pop();//correct but without knowing what it is removing
            s1.Push(10); s1.Push(99); s1.Push(45);
            object obj1 = s1.Pop();// returns value of removed
            object obj2 = s1.Peek();
            bool b1 = s1.Contains(33);
            // s1.CopyTo(array ,int index) from stack to array
            // s1.Clear();//all gone            
        }
        public static void QuequeFuns()
        {
            Queue q1 = new Queue();
            q1.Enqueue(22); q1.Enqueue(7); q1.Enqueue(45); //to add
                                                           //to remove
            object obj1 = q1.Dequeue();// removes
            object obj2 = q1.Peek();//without removing
            bool b1 = q1.Contains(45);


        }

    }
}
