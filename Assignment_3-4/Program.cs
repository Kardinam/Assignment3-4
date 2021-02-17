using Assignment_3_4.Checkout;
using Assignment_3_4.Payment;
using Assignment_3_4.Products;
using Assignment_3_4.Sorting;
using SortingAlgorithmsCB11;
using System;
using System.Collections.Generic;

namespace Assignment_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IProduct shirtA = new Shirt(Enumerators.Color.INDIGO, Enumerators.Size.XL, Enumerators.Fabric.RAYON);
            IProduct shirtB = new Shirt(Enumerators.Color.BLUE, Enumerators.Size.XS, Enumerators.Fabric.SILK);
            IProduct shirtC = new Shirt(Enumerators.Color.RED, Enumerators.Size.L, Enumerators.Fabric.WOOL);


            CheckoutTime checkout = new CheckoutTime(shirtC, new Pay(WayOfPayment.Cash));
            checkout.CheckOut();
            CheckoutTime checkout2 = new CheckoutTime(shirtB, new Pay(WayOfPayment.Cash));
            checkout.CheckOut();
            CheckoutTime checkout3 = new CheckoutTime(shirtA, new Pay(WayOfPayment.Cash));
            checkout.CheckOut();


            MyDatabase db = new MyDatabase();
            var ShirtList = new List<Shirt>(db.Shirts);




            foreach (var shirt in ShirtList)
            {
                shirt.Output();
            }

            //  SizeBubbleSort.SortShirtsAsc(ShirtList);
            //  SizeBubbleSort.SortShirtsDesc(ShirtList);
            //  var sortedListBucketAsc = ColorBucketSort.SortShirtsAsc(ShirtList);
            //  var sortedListBucketsdesc = ColorBucketSort.SortShirtsDesc(ShirtList);
            //  FabricQuickSort.SortShirts(ShirtList);
            //  FabricQuickSort.SortShirtsDesc(ShirtList);











        }
    }
}
