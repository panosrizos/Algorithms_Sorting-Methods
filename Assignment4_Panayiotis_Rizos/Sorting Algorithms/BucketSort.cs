using Assignment4_Panayiotis_Rizos.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_Panayiotis_Rizos.Sorting_Algorithms
{
    class BucketSort
    {
        public static void SortColorAsc(Shirt[] shirts)
        {
            var minValue = shirts[0].Color;
            var maxValue = shirts[0].Color;

            for (int i = 1; i < shirts.Length; i++)
            {
                if (shirts[i].Color > maxValue)
                    maxValue = shirts[i].Color;
                if (shirts[i].Color < minValue)
                    minValue = shirts[i].Color;
            }

            List<Shirt>[] bucket = new List<Shirt>[maxValue - minValue + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<Shirt>();
            }

            for (int i = 0; i < shirts.Length; i++)
            {
                bucket[shirts[i].Color - minValue].Add(shirts[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        shirts[k] = bucket[i][j];
                        k++;
                    }
                }
            }


        }


        public static void SortSizeAsc(Shirt[] shirts)
        {
            var minValue = shirts[0].Size;
            var maxValue = shirts[0].Size;

            for (int i = 1; i < shirts.Length; i++)
            {
                if (shirts[i].Size > maxValue)
                    maxValue = shirts[i].Size;
                if (shirts[i].Size < minValue)
                    minValue = shirts[i].Size;
            }

            List<Shirt>[] bucket = new List<Shirt>[maxValue - minValue + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<Shirt>();
            }

            for (int i = 0; i < shirts.Length; i++)
            {
                bucket[shirts[i].Size - minValue].Add(shirts[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        shirts[k] = bucket[i][j];
                        k++;
                    }
                }
            }

        }


        public static void SortFabricAsc(Shirt[] shirts)
        {
            var minValue = shirts[0].Fabric;
            var maxValue = shirts[0].Fabric;

            for (int i = 1; i < shirts.Length; i++)
            {
                if (shirts[i].Fabric > maxValue)
                    maxValue = shirts[i].Fabric;
                if (shirts[i].Fabric < minValue)
                    minValue = shirts[i].Fabric;
            }

            List<Shirt>[] bucket = new List<Shirt>[maxValue - minValue + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<Shirt>();
            }

            for (int i = 0; i < shirts.Length; i++)
            {
                bucket[shirts[i].Fabric - minValue].Add(shirts[i]);
            }

            int k = 0;
            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        shirts[k] = bucket[i][j];
                        k++;
                    }
                }
            }

        }





    }
}


