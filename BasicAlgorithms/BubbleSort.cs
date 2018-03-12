using System;
using System.Collections;

namespace BasicAlgorithms
{
    public class BubbleSort
    {
        public static void Sort(int[] Items, bool ascending = true)
        {
            int i = 0;
            int j = 0;
            for (i = 0; i <= Items.Length - 1; i++)
            {
                for (j = i + 1; j <= Items.Length - 1; j++)
                {

                    if (IsOrderValid(ascending, Items[i], Items[j]))
                    {
                        int aux = Items[i];
                        Items[i] = Items[j];
                        Items[j] = aux;
                    }


                }
            }


        }

        private static bool IsOrderValid(bool ascending, int a, int b)
        {
            if (ascending == true)
                return a > b;
            else
                return a < b;

        }


    }
}
