using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingKids.MyTasks
{
    class ArrayTasks
    {
        public static int[] GetSampleArray()
        {
            int[] nums;
            nums = new int[4];
            nums[0] = 6;
            nums[1] = 19;
            nums[2] = 44;
            nums[3] = 42;
            return nums;
        }

        public static void Start()
        {
            var list = new List<String>() { "Én", "elmentem", "a", "vásárba", "fél", "pénzzel" };

            for (var i = 0; i < list.Count; i++)
            {
                var item = list[i];
                //...
            }

            var szoveg = "";
            foreach (var item in list)
            {
                szoveg += item + " ";
            }
            szoveg = szoveg.Trim() + ".";
            Console.WriteLine(szoveg);

            // --

            var j = 0;
            while (j < list.Count)
            {
                // Ez itt pont ugyanolyan, mint egy for ciklus

                j++;
            }

            var list2 = new List<int>() { 1, 2, 3, 3, 3, 4, 5, 6 };

            var vettemKiValamit = true;
            while (vettemKiValamit)
            {
                vettemKiValamit = list2.Remove(3);
            }

            Console.WriteLine();
        }

        private static void Feladat3()
        {
            var list = new List<String>() { "Én", "elmentem", "a", "vásárba", "fél", "pénzzel" };
            //Console.WriteLine(list[0]);
            //Console.WriteLine(list[1]);
            //Console.WriteLine(list[2]);
            //Console.WriteLine(list[3]);
            //Console.WriteLine(list[4]);
            //Console.WriteLine(list[5]);

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            //for (int i = 0; i < list.Count; i++)
            //{
            //    Console.Write(list[i]);                // \n \t 
            //    Console.Write(" ");
            //}
            //Console.WriteLine();

            var szoveg = "";
            for (int i = 0; i < list.Count; i++)
            {
                szoveg = szoveg + list[i] + " ";
            }
            // "   asdasd     "
            szoveg = szoveg.Trim();
            //szoveg = szoveg.Remove(szoveg.Length - 1);
            szoveg = szoveg + ".";
            Console.WriteLine(szoveg);
        }

        private static void Elemelet()
        {
            var array = new int[10];
            var dictionary = new Dictionary<int, int>();
            var list = new List<int>();

            //array.Length
            //dictionary.Count
            //list.Count

            //dictionary[0] = 100;
            //dictionary.Add(0, 100);

            //dictionary.ContainsKey(0);
            //dictionary.ContainsValue(100);

            //dictionary.Remove(0);

            //dictionary.Clear();

            //list.Add(0);
            //list.Clear();
            //list.Contains();
            //list.IndexOf(123);
            //list.LastIndexOf(123);
            //list.Insert(0, 123);
            //list.Remove(61);
            //list.RemoveAt(3);
            //list.RemoveRange(4, 10);
            //list.Reverse();
            //list.Sort();
            ////list.BinarySearch();
            //list.ToArray().ToList().ToArray().ToList();
            //list.ToList();

            //array.ToArray();
        }

        private static void Feladat2()
        {
            var sampleArray = GetSampleArray();
            //var sum = sampleArray[0] + sampleArray[1] + sampleArray[2] + sampleArray[3];

            int sum2 = 0;
            for (int i = 0; i < sampleArray.Length; i++)
            {
                sum2 += sampleArray[i];
            }
            Console.WriteLine("Az osszeg: " + sum2);

            for (var i = 0; i < sampleArray.Length; i++)
            {
                var bal = i;
                var jobb = sampleArray[i];
            }
        }

        private static void Feladat1()
        {
            var sampleArray = GetSampleArray();
            //sampleArray[0];
            //GetSampleArray()[0];

            //int[][] aaa = new int[2][];
            //aaa[0] = new int[5];
            //aaa[1] = new int[100];

            // Feladat1: A tomb osszes elemet írd ki a képernyőre
            //Console.WriteLine(sampleArray[0]);
            //Console.WriteLine(sampleArray[1]);
            //Console.WriteLine(sampleArray[2]);
            //Console.WriteLine(sampleArray[3]);
            //Console.WriteLine(sampleArray[4]);
            //Console.WriteLine(sampleArray[5]);
            //Console.WriteLine(sampleArray[6]);
            for (int i = 0; i < sampleArray.Length; i++)
            {
                // 0: 6
                // 1: 19
                // ...
                var message = i + ": " + sampleArray[i];
                Console.WriteLine(message);
            }
        }
    }
}