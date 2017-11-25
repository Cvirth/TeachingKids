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
                var bal  = i;
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