using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec18Console
{
    public class AllGenericClass
    {
        public static void ListFuns()
        {
            List<int> l1 = new List<int>(); l1.Add(1);
            List<string> l2 = new List<string>(); l2.Add("Harry");
            l2.Add("Jerry"); l2.Add("Jim"); l2.Add("Tom");
            foreach (var one in l2) { }
            foreach (string one in l2) { }
            int n1 = l2.Capacity;//please check 
            int n2 = l2.Count;
            l2.Remove("Harry"); l2.RemoveAt(1); l2.Clear();//int n3 = l2.RemoveAll("Hello"); 
            l2.Sort();
            //search 
            bool b1 = l2.Contains("Hello");
            Console.WriteLine(b1);
            l2.Insert(2, "Sinha");
            //to view index 
            int n3 = l2.IndexOf("Hello");
        }
        public static void SortedListFuns()
        {
            SortedList<int, string> sl1 = new SortedList<int, string>();
            sl1.Add(81, "xyz");
            sl1.Add(2, "Abc");
            sl1.Remove(2);
            sl1.Clear();
            int n1 = sl1.Count;
            int n2 = sl1.IndexOfKey(81);
            int n3 = sl1.Capacity;//default how many values
            ICollection<int> c1 = sl1.Keys;
            //ICollection<int> c2 = sl1.Values;wrong
            ICollection<string> c2 = sl1.Values;
            foreach (string s1 in c2) { }
            foreach (var v1 in c1) { }
            // here can not use DictonaryEntry ,because it non-generic class

        }
        public static void DictonaryFuns()
        {
            Dictionary<int, int> d1 = new Dictionary<int, int>();
            d1.Add(1, 2); d1.Add(45, 99); d1.Add(3, 22); d1.Add(1, 4);
            //to access
            ICollection<int> c1 = d1.Keys; foreach (int a in c1) { }
            ICollection<int> c2 = d1.Values; foreach (var b in c2) { }
            //to search 
            bool b1 = d1.ContainsKey(1);
            bool b2 = d1.Remove(1);// d1.Remove(1); 
        }
        public static void StackAndQuequeFuns()
        {
            Stack<int> s1 = new Stack<int>(); s1.Push(10); s1.Pop(); int n1 = s1.Peek();
            int n2 = s1.Count;
            Queue<int> q1 = new Queue<int>(); q1.Enqueue(10); q1.Dequeue(); int n = q1.Peek();
            int n3 = q1.Count; bool b1 = q1.Contains(10);
        }
        public static void BothIterators()
        {//List class is Implementing Ienumerator Interface so Method of GetEnumerator()
            List<int> allYears = new List<int>();
            allYears.Add(1990);

            allYears.Add(2001);
            IEnumerable<int> e1 = allYears;
            foreach (int x in e1) { Console.WriteLine(x); }
            IEnumerator<int> emraat = allYears.GetEnumerator();
            while (emraat.MoveNext())
            {
                Console.WriteLine(emraat.Current.ToString());
            }

        }
    }

}

