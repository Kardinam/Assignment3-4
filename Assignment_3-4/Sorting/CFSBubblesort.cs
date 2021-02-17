using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_4.Sorting
{
    class CFSBubblesort
    {

        private static bool less(int value1, int value2)
        {
            return value1 < value2;
        }

        private static bool more(int value1, int value2)
        {
            return value1 > value2;
        }

        public static void SortShirtsAsc(List<Shirt> shirts)
        {
            int size = shirts.Count;
            int i = 0;
            int j = 0;
            Shirt temp;

            for (i = 0; i < size - 1; i++)
            {
                for (j = 0; j < (size - i - 1); j++)
                {
                    if (more((int)shirts[j].Size, (int)shirts[j + 1].Size))
                    {

                        temp = shirts[j];
                        shirts[j] = shirts[j + 1];
                        shirts[j + 1] = temp;
                    }

                }
            }

            for (i = 0; i < size - 1; i++)
            {
                for (j = 0; j < (size - i - 1); j++)
                {
                    if (more((int)shirts[j].Color, (int)shirts[j + 1].Color))
                    {

                        temp = shirts[j];
                        shirts[j] = shirts[j + 1];
                        shirts[j + 1] = temp;
                    }

                }
            }

            for (i = 0; i < size - 1; i++)
            {
                for (j = 0; j < (size - i - 1); j++)
                {
                    if (more((int)shirts[j].Fabric, (int)shirts[j + 1].Fabric))
                    {

                        temp = shirts[j];
                        shirts[j] = shirts[j + 1];
                        shirts[j + 1] = temp;
                    }

                }
            }
        }

        public static void SortShirtsDesc(List<Shirt> shirts)
        {
            int size = shirts.Count;
            bool isSorted = false;
            int lastUnsorted = size - 1;
            Shirt temp;

            while (!isSorted)
            {
                isSorted = true;

                for (int i = 0; i < lastUnsorted; i++)
                {
                    if (less((int)shirts[i].Size, (int)shirts[i + 1].Size))
                    {

                        temp = shirts[i];
                        shirts[i] = shirts[i + 1];
                        shirts[i + 1] = temp;
                        isSorted = false;
                    }
                }
                lastUnsorted--;
            }

            while (!isSorted)
            {
                isSorted = true;

                for (int i = 0; i < lastUnsorted; i++)
                {
                    if (less((int)shirts[i].Color, (int)shirts[i + 1].Color))
                    {

                        temp = shirts[i];
                        shirts[i] = shirts[i + 1];
                        shirts[i + 1] = temp;
                        isSorted = false;
                    }
                }
                lastUnsorted--;
            }
            while (!isSorted)
            {
                isSorted = true;

                for (int i = 0; i < lastUnsorted; i++)
                {
                    if (less((int)shirts[i].Fabric, (int)shirts[i + 1].Fabric))
                    {

                        temp = shirts[i];
                        shirts[i] = shirts[i + 1];
                        shirts[i + 1] = temp;
                        isSorted = false;
                    }
                }
                lastUnsorted--;
            }
        }
    } // Den douleuei tha to diorthosw kai kanw kalitera mesa sto sk logika me allo sort gt mallon kolisa se auti ti vlakeia 
}
