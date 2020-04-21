using Assignment4_Panayiotis_Rizos.Enumerations;
using Assignment4_Panayiotis_Rizos.Sorting_Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment4_Panayiotis_Rizos.Entities;

namespace Assignment4_Panayiotis_Rizos
{
    class Application
    {


        public static void Run() 
        {
            MyDatabase db = new MyDatabase();


            var bubbleShirts = db.Shirts;
            var quickshirts = db.Shirts.ToArray();
            var bucketShirts = db.Shirts.ToArray();

            //// ---------------------------------------------------------------------------------------------- BUBBLE SORT-------------------------------------------------------------------


            Console.WriteLine("---BUBBLE SORTING---");


            BubbleSort.Sort(bubbleShirts, (s1, s2) => s1.Size > s2.Size);  //Sorting Asceding by the Size.
            PrintAllItems(bubbleShirts, Element.Size, Order.Asceding);

            BubbleSort.Sort(bubbleShirts, (s1, s2) => s1.Color > s2.Color);  //Sorting Asceding by the Color.
            PrintAllItems(bubbleShirts, Element.Color, Order.Asceding);

            BubbleSort.Sort(bubbleShirts, (s1, s2) => s1.Fabric > s2.Fabric);  //Sorting Asceding by the Fabric.
            PrintAllItems(bubbleShirts, Element.Fabric, Order.Asceding);



            BubbleSort.Sort(bubbleShirts, (s1, s2) => s1.Size < s2.Size);  //Sorting Desceding by the Size.
            PrintAllItems(bubbleShirts, Element.Size, Order.Desceding);

            BubbleSort.Sort(bubbleShirts, (s1, s2) => s1.Color < s2.Color);  //Sorting Desceding by the Color.
            PrintAllItems(bubbleShirts, Element.Color, Order.Desceding);

            BubbleSort.Sort(bubbleShirts, (s1, s2) => s1.Fabric < s2.Fabric);  //Sorting Desceding by the Fabric.
            PrintAllItems(bubbleShirts, Element.Fabric, Order.Desceding);





            BubbleSort.SizeColorFabricAsc(bubbleShirts);  // Facade tha gives (ASC) ordered  Shirts By ---  Size,Color,Fabric ---
            PrintAllItems(bubbleShirts, Element.Everything, Order.Asceding);

            BubbleSort.SizeColorFabricDesc(bubbleShirts);  // Facade tha gives (DESc) ordered Shirts By ---  Size,Color,Fabric ---
            PrintAllItems(bubbleShirts, Element.Everything, Order.Desceding);






            //// ---------------------------------------------------------------------------------------------- QUICK SORT-------------------------------------------------------------------



            Console.WriteLine("---QUICK SORTING---");


            QuickSort.SortingFacade(quickshirts, (s1, s2) => s1.Size > s2.Size);  //Sorting Asceding by the Size.
            PrintAllItems(quickshirts, Element.Size, Order.Asceding);

            QuickSort.SortingFacade(quickshirts, (s1, s2) => s1.Color > s2.Color);   //Sorting Asceding by the Color.
            PrintAllItems(quickshirts, Element.Color, Order.Asceding);

            QuickSort.SortingFacade(quickshirts, (s1, s2) => s1.Fabric > s2.Fabric);   //Sorting Asceding by the Fabric.
            PrintAllItems(quickshirts, Element.Fabric, Order.Asceding);




            QuickSort.SortingFacade(quickshirts, (s1, s2) => s1.Size < s2.Size);  //Sorting Desceding by the Size.
            PrintAllItems(quickshirts, Element.Size, Order.Desceding);

            QuickSort.SortingFacade(quickshirts, (s1, s2) => s1.Color < s2.Color);   //Sorting Desceding by the Color.
            PrintAllItems(quickshirts, Element.Color, Order.Desceding);

            QuickSort.SortingFacade(quickshirts, (s1, s2) => s1.Fabric < s2.Fabric);   //Sorting Desceding by the Fabric.
            PrintAllItems(quickshirts, Element.Fabric, Order.Desceding);


            QuickSort.SizeColorFabricAsc(quickshirts);
            PrintAllItems(quickshirts, Element.Everything, Order.Asceding);       // Facade tha gives (ASC) ordered  Shirts By ---  Size,Color,Fabric ---
            QuickSort.SizeColorFabricDesc(quickshirts);
            PrintAllItems(quickshirts, Element.Everything, Order.Desceding);     // Facade tha gives (DESc) ordered Shirts By ---  Size,Color,Fabric ---



            //// ---------------------------------------------------------------------------------------------- BUCKET SORT-------------------------------------------------------------------


            Console.WriteLine("---BUCKET SORTING---");


            BucketSort.SortColorAsc(bucketShirts);
            PrintAllItems(bucketShirts, Element.Color, Order.Asceding);

            BucketSort.SortSizeAsc(bucketShirts);
            PrintAllItems(bucketShirts, Element.Size, Order.Asceding);

            BucketSort.SortFabricAsc(bucketShirts);
            PrintAllItems(bucketShirts, Element.Fabric, Order.Asceding);
        }

        public static void PrintAllItems(IEnumerable<Shirt> shirts, Element element, Order order)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("All Clothes sorting by {0} in {1} order", element, order);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0,-15}{1,-15}{2,-15}", "Size", "Color", "Fabric");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in shirts)
            {
                item.Output();
            }

            Console.WriteLine("--------------------------------------------------------");
        }
    }
}
