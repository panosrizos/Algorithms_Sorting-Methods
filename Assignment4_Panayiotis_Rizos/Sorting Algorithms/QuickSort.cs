using Assignment4_Panayiotis_Rizos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Panayiotis_Rizos.Sorting_Algorithms
{
    class QuickSort
    {

        static int partition(Shirt[] shirts, int low, int high, Func<Shirt, Shirt, bool> compare)
        {
            Shirt pivot = shirts[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than the pivot
                if (compare(pivot, shirts[j]))
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    Shirt temp = shirts[i];
                    shirts[i] = shirts[j];
                    shirts[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            Shirt temp1 = shirts[i + 1];
            shirts[i + 1] = shirts[high];
            shirts[high] = temp1;

            return i + 1;
        }


        public static void SortingFacade(Shirt[] shirts, Func<Shirt, Shirt, bool> compare) // Facade
        {
            Sort(shirts, 0, shirts.Length - 1, compare);
        }


        public static void Sort(Shirt[] arr, int low, int high, Func<Shirt, Shirt, bool> compare)
        {
            if (low < high)
            {

                /* pi is partitioning index, arr[pi] is  
                now at right place */
                int pi = partition(arr, low, high, compare);

                // Recursively sort elements before 
                // partition and after partition 
                Sort(arr, low, pi - 1, compare);
                Sort(arr, pi + 1, high, compare);
            }
        }

        public static void SizeColorFabricAsc(Shirt[] shirts)
        {
            SortingFacade(shirts, (s1, s2) => s1.Fabric > s2.Fabric);
            SortingFacade(shirts, (s1, s2) => s1.Color > s2.Color);
            SortingFacade(shirts, (s1, s2) => s1.Size > s2.Size);

        }

        public static void SizeColorFabricDesc(Shirt[]shirts)
        {
            SortingFacade(shirts, (s1, s2) => s1.Fabric > s2.Fabric);
            SortingFacade(shirts, (s1, s2) => s1.Color > s2.Color);
            SortingFacade(shirts, (s1, s2) => s1.Size > s2.Size);

        }

    }

}
