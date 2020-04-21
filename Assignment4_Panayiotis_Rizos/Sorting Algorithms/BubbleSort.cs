using Assignment4_Panayiotis_Rizos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Panayiotis_Rizos.Sorting_Algorithms
{
    class BubbleSort
    {

        public static void Sort(List<Shirt> shirts, Func<Shirt, Shirt, bool> compare)  // That Method takes a list of shirts and Func delegate which has Two Shirts as input and returnig Boolean.
        {

            Shirt temp;
            for (int j = 0; j <= shirts.Count - 2; j++)
            {
                for (int i = 0; i <= shirts.Count - 2; i++)
                {
                    if (compare(shirts[i], shirts[i + 1]))
                    {
                        temp = shirts[i + 1];
                        shirts[i + 1] = shirts[i];
                        shirts[i] = temp;
                    }
                }
            }

        }

        public static void SizeColorFabricAsc(List<Shirt> shirts)
        {
            Sort(shirts, (s1, s2) => s1.Fabric > s2.Fabric);
            Sort(shirts, (s1, s2) => s1.Color > s2.Color);
            Sort(shirts, (s1, s2) => s1.Size > s2.Size);

        }
        public static void SizeColorFabricDesc(List<Shirt> shirts)
        {
            Sort(shirts, (s1, s2) => s1.Fabric < s2.Fabric);
            Sort(shirts, (s1, s2) => s1.Color < s2.Color);
            Sort(shirts, (s1, s2) => s1.Size < s2.Size);

        }
    }
}
