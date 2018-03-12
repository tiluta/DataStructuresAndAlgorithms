using System;
using System.Collections;

namespace BasicAlgorithms
{
    public class BubbleSort
    {
        public static void Sort(int[] Items, bool userPref = true)
        {
            int i = 0;
            int j = 0;
            for(i= 0; i <= Items.Length - 1; i++)
            {
                for (j = i + 1; j <= Items.Length - 1; j++)
                {
                    if(userPref == true)
                    {
                        if (Items[i] > Items[j])
                        {
                            int aux = Items[i];
                            Items[i] = Items[j];
                            Items[j] = aux;
                        }
                    }
                    else
                    {
                        if (Items[i] < Items[j])
                        {
                            int aux = Items[i];
                            Items[i] = Items[j];
                            Items[j] = aux;
                        }
                    }
                      

                }
            }
        }


    }
}
