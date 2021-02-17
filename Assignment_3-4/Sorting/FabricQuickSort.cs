using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_4.Sorting
{
    class FabricQuickSort
    {

        public static void SortShirtsAsc(List<Shirt> shirts)
        {
            QuicksortAsc(shirts, 0, shirts.Count -1);
        }
        public static void SortShirtsDesc(List<Shirt> shirts)
        {
            QuicksortAsc(shirts, 0, shirts.Count - 1);
        }

        private static void QuicksortAsc(List<Shirt> shirts, int left, int right)
        {
            int i = left;
            int j = right;
            var pivot = shirts[(left + right) / 2].Fabric;

            while (i <= j)
            {
                while (shirts[i].Fabric < pivot)
                    i++;
                while (shirts[j].Fabric > pivot)
                    j--;

                if (i <= j)
                {
                    
                    var temp = shirts[i];
                    shirts[i] = shirts[j];
                    shirts[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuicksortAsc(shirts, left, j);
            if (i < right)
                QuicksortAsc(shirts, i, right);
        }

        private static void QuicksortDesc(List<Shirt> shirts, int left, int right)
        {
            int i = left;
            int j = right;
            var pivot = shirts[(left + right) / 2].Fabric;

            while (i <= j)
            {
                while (shirts[i].Fabric > pivot)
                    i++;
                while (shirts[j].Fabric < pivot)
                    j--;

                if (i <= j)
                {

                    var temp = shirts[i];
                    shirts[i] = shirts[j];
                    shirts[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
                QuicksortDesc(shirts, left, j);
            if (i < right)
                QuicksortDesc(shirts, i, right);
        }


    }
}
