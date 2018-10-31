using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeterCokerArrarysExercises
{
    class Q0
    {
        static void Main(string[] args)
        {
            Array oddArray = Array.CreateInstance(Type.GetType("System.Int32"), 5);
            oddArray.SetValue(1, 0); 
            oddArray.SetValue(3, 1);
            oddArray.SetValue(5, 2);
            oddArray.SetValue(7, 3);
            oddArray.SetValue(9, 4);

            Array objArray = Array.CreateInstance(Type.GetType("System.Object"), 5);
            Array.Copy(oddArray, oddArray.GetLowerBound(0), objArray, objArray.GetLowerBound(0),
            4);
            int items1 = objArray.GetUpperBound(0);
            for (int i = 0; i < items1; i++)
                Console.WriteLine(objArray.GetValue(i).ToString());

            //Array stringArray = Array.CreateInstance(typeof(String), 5);
            //stringArray.SetValue("Mahesh", 0);
            //stringArray.SetValue("Raj", 1);
            //stringArray.SetValue("Neel", 2);
            //stringArray.SetValue("Beniwal", 3);
            //stringArray.SetValue("Chand", 4);

            //object name = "Neel";
            //int nameIndex = Array.BinarySearch(stringArray, name);

            //if (nameIndex >= 0)

            //    Console.WriteLine("Item was at " + nameIndex.ToString() + "th position");

            //else

            //    Console.WriteLine("Item not found");

            //Console.WriteLine();

            //Console.WriteLine("Orignial Array");
            //Console.WriteLine("--------");

            //foreach (string str in stringArray)
            //{
            //    Console.WriteLine(str);

            //}

            //Console.WriteLine();
            //Console.WriteLine("Sorted Array");

            //Array.Sort(stringArray);

            //foreach (string str in stringArray)
            //{
            //    Console.WriteLine(str);
            //}










            //int[] intArray = new int[3] { 0, 1, 2 };
            //if (intArray.IsFixedSize)
            //{
            //    Console.WriteLine("Array is fixed size");
            //    Console.WriteLine("Size : {0}", intArray.Length.ToString());
            //    Console.WriteLine("Rank : {0}", intArray.Rank.ToString());
            //}

            //Array stringArray = Array.CreateInstance(typeof(String), 3);
            //stringArray.SetValue("Mahesh Chand", 0);
            //stringArray.SetValue("Raj Kumar", 1);
            //stringArray.SetValue("Neel Beniwal", 2);

            //Array intArray3D = Array.CreateInstance(typeof(Int32), 2, 3, 4);
            //for (int i = intArray3D.GetLowerBound(0); i <= intArray3D.GetUpperBound(0); i++)
            //    for (int j = intArray3D.GetLowerBound(1); j <= intArray3D.GetUpperBound(1); j++)
            //        for (int k = intArray3D.GetLowerBound(2); k <= intArray3D.GetUpperBound(2); k++)
            //        {
            //            intArray3D.SetValue((i * 100) + (j * 10) + k, i, j, k);
            //        }
            //foreach (int ival in intArray3D)
            //{
            //    Console.WriteLine(ival);
            //}





            //Array stringArray = Array.CreateInstance(typeof(string), 5);



            //int[] numberIntArray = new int[3] { 1, 3, 5 };

            //numberIntArray[0] = 1;
            //numberIntArray[1] = 3;
            //numberIntArray[2] = 5;

            //Console.WriteLine(numberIntArray[0]);
            //Console.WriteLine(numberIntArray[1]);
            //Console.WriteLine(numberIntArray[2]);













            Console.ReadLine();
        }
    }
}
